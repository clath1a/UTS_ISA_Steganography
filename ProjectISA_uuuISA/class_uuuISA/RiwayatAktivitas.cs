using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class RiwayatAktivitas
    {
        int idRiwayatAktivitas;
        DateTime waktuMasuk;
        DateTime waktuKeluar;
        int durasiWaktu;
        Akun idAkun;

        public int IdRiwayatAktivitas { get => idRiwayatAktivitas; set => idRiwayatAktivitas = value; }
        public DateTime WaktuMasuk { get => waktuMasuk; set => waktuMasuk = value; }
        public DateTime WaktuKeluar { get => waktuKeluar; set => waktuKeluar = value; }
        public int DurasiWaktu { get => durasiWaktu; set => durasiWaktu = value; }
        internal Akun IdAkun { get => idAkun; set => idAkun = value; }
    }
}
