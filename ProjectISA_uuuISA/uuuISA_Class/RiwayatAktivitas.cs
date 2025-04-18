using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    public class RiwayatAktivitas
    {
        #region DATA MEMBER
        int idRiwayatAktivitas;
        DateTime waktuMasuk;
        DateTime waktuKeluar;
        int durasiWaktu;
        Akun idAkun;
        #endregion

        #region PROPERTIES
        public int IdRiwayatAktivitas { get => idRiwayatAktivitas; set => idRiwayatAktivitas = value; }
        public DateTime WaktuMasuk { get => waktuMasuk; set => waktuMasuk = value; }
        public DateTime WaktuKeluar { get => waktuKeluar; set => waktuKeluar = value; }
        public int DurasiWaktu { get => durasiWaktu; set => durasiWaktu = value; }
        public Akun IdAkun { get => idAkun; set => idAkun = value; }
        #endregion
    }
}
