using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public static class AES
    {
        private static string keyString = "ssecretkeykelompokuuuisasemangat"; //AES-256, pakai 32 karakter

        public static string Encrypt(string plainText)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            if (key.Length != 32) throw new ArgumentException("Key harus 256 bit (32 bytes)!"); //pengecekan jumlah karakter (harus 32)

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC; //CBC mode: blok plaintext dienkripsi dengan cipher + XOR + blok cipher sebelumnya sebelum dienkripsi
                aes.Padding = PaddingMode.PKCS7;

                aes.GenerateIV(); //IV = initialization vector, untuk first blocknya. Buat mulai bakal pakai IV ini dulu (anggepannya blok cipher paling pertama)
                byte[] iv = aes.IV; //biar ciphernya jadi double

                using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, iv))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                    // Gabungkan IV dan ciphertext menjadi satu array byte dan encode ke Base64
                    byte[] result = new byte[iv.Length + encryptedBytes.Length]; //simpan IV sama ciphertextnya
                    Array.Copy(iv, 0, result, 0, iv.Length);
                    Array.Copy(encryptedBytes, 0, result, iv.Length, encryptedBytes.Length);

                    return Convert.ToBase64String(result); //hasil dalam bentuk string Base64, biar acak
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            if (key.Length != 32) throw new ArgumentException("Key harus 256 bit (32 bytes)@");

            byte[] cipherBytes = Convert.FromBase64String(cipherText); //narik hasil encryptnya (string base64)
                        
            byte[] iv = new byte[16]; //ambil IV dari ciphertext (16 bytes pertama)
            Array.Copy(cipherBytes, 0, iv, 0, iv.Length);
                        
            byte[] encryptedBytes = new byte[cipherBytes.Length - iv.Length]; //16 sisa terakhir adalah ciphertext
            Array.Copy(cipherBytes, iv.Length, encryptedBytes, 0, encryptedBytes.Length);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    return Encoding.UTF8.GetString(decryptedBytes); //balikkan dalam bentuk string
                }
            }
        }
    }
}
