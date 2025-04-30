using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Text;

public static class Steganography_Raport
{
    public static Bitmap EmbedText(string text, Bitmap image)//ngehidden msg
    {
        if (text == null) throw new ArgumentNullException(nameof(text), "Text cannot be null");
        if (image == null) throw new ArgumentNullException(nameof(image), "Image cannot be null");

        byte[] compressed = Compress(text); //calling compress method
        BitArray bits = new BitArray(compressed);

        int bitIndex = 0;
        int totalBits = bits.Length;

        // Create a defensive copy of the image
        Bitmap newImage = null;
        try
        {
            // Use a more robust way to copy the bitmap
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                newImage = new Bitmap(ms);
            }
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Failed to create a copy of the image", nameof(image), ex);
        }

        for (int y = 0; y < newImage.Height; y++) //panjang gambar
        {
            for (int x = 0; x < newImage.Width; x++) //lebar gambar
            {
                if (bitIndex >= totalBits)
                    return newImage;

                Color pixel = newImage.GetPixel(x, y); //ambil warna gambar
                byte r = SetLeastBit(pixel.R, bits[bitIndex++]);
                byte g = (bitIndex < totalBits) ? SetLeastBit(pixel.G, bits[bitIndex++]) : pixel.G;
                byte b = (bitIndex < totalBits) ? SetLeastBit(pixel.B, bits[bitIndex++]) : pixel.B;

                newImage.SetPixel(x, y, Color.FromArgb(r, g, b));
            }
        }

        return newImage;
    }

    public static string ExtractText(Bitmap image) //reading hidden text
    {
        List<bool> bits = new List<bool>();

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);
                bits.Add(GetLeastBit(pixel.R));
                bits.Add(GetLeastBit(pixel.G));
                bits.Add(GetLeastBit(pixel.B));
            }
        }

        byte[] data = BitsToBytes(bits);
        return Decompress(data);
    }

    private static byte SetLeastBit(byte b, bool bit) //ganti last bit from a byte
    {
        b = (byte)(b & 0xFE); // Clear last bit
        if (bit)
            b |= 1; // Set bit if needed
        return b;
    }

    private static bool GetLeastBit(byte b)
    {
        return (b & 1) == 1;
    }

    private static byte[] Compress(string text) //pake Gzip buat ngurangin ukuran text
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);

        using (MemoryStream output = new MemoryStream())
        {
            using (GZipStream gzip = new GZipStream(output, CompressionMode.Compress))
            {
                gzip.Write(bytes, 0, bytes.Length);
            }
            return output.ToArray();
        }
    }

    private static string Decompress(byte[] compressed)
    {
        using (MemoryStream input = new MemoryStream(compressed))
        using (GZipStream gzip = new GZipStream(input, CompressionMode.Decompress))
        using (MemoryStream output = new MemoryStream())
        {
            gzip.CopyTo(output);
            return Encoding.UTF8.GetString(output.ToArray());
        }
    }

    private static byte[] BitsToBytes(List<bool> bits) //biar akses per-bit, not bytes
    {
        int numBytes = (bits.Count + 7) / 8;
        byte[] bytes = new byte[numBytes];

        for (int i = 0; i < bits.Count; i++)
        {
            if (bits[i])
            {
                bytes[i / 8] |= (byte)(1 << (i % 8));
            }
        }
        return bytes;
    }
}