INSERT INTO `uuuisa`.`role` (`role`) VALUES 
('Admin'), 
('Guru'), 
('Siswa'), 
('Pustakawan');

INSERT INTO `uuuisa`.`akun` (`username`, `password`, `role_idrole`) VALUES 
('admin1', SHA2('admin123', 256), 1),
('guru1', SHA2('guru123', 256), 2),
('siswa1', SHA2('siswa123', 256), 3),
('pustakawan1', SHA2('pustaka123', 256), 4),
('guru2', SHA2('guru456', 256), 2),
('siswa2', SHA2('siswa456', 256), 3);

INSERT INTO `uuuisa`.`kelas` (`namaKelas`, `kapasitasKelas`, `lantaiRuangan`, `jenjang`) VALUES 
('X IPA 1', 30, '1', 'SMA'),
('X IPA 2', 32, '1', 'SMA'),
('XI IPS 1', 28, '2', 'SMA'),
('XII IPA 1', 30, '3', 'SMA');

INSERT INTO `uuuisa`.`mataPelajaran` (`namaMataPelajaran`, `durasiPembelajaran`, `statusMataPelajaran`) VALUES 
('Matematika', 90, 'Aktif'),
('Bahasa Indonesia', 80, 'Aktif'),
('Fisika', 90, 'Aktif'),
('Sejarah', 80, 'Aktif'),
('Bahasa Inggris', 80, 'Aktif');

INSERT INTO `uuuisa`.`guru` (`nama`, `email`, `nomorTlp`, `tanggalLahir`, `pendidikanTerakhir`, `akun_idAkun`) VALUES 
('Budi Santoso', 'budi@uuuisa.sch.id', '08123456789', '1980-05-15', 'S2 Pendidikan Matematika', 2),
('Ani Wijaya', 'ani@uuuisa.sch.id', '08129876543', '1985-08-20', 'S1 Pendidikan Fisika', 5),
('Citra Dewi', 'citra@uuuisa.sch.id', '081511223344', '1978-11-30', 'S2 Pendidikan Bahasa', 2);

INSERT INTO `uuuisa`.`siswa` (`nama`, `tanggalLahir`, `alamatRumah`, `tahunMasuk`, `emailSekolah`, `akun_idAkun`, `kelas_idKelas`) VALUES 
('Andi Pratama', '2007-03-10', 'Jl. Merdeka No. 12', 2023, 'andi.pratama@uuuisa.sch.id', 3, 1),
('Bella Putri', '2007-06-25', 'Jl. Sudirman No. 45', 2023, 'bella.putri@uuuisa.sch.id', 6, 1),
('Cahyo Nugroho', '2006-09-15', 'Jl. Diponegoro No. 78', 2022, 'cahyo.nugroho@uuuisa.sch.id', 3, 3);

INSERT INTO `uuuisa`.`pustakawan` (`Nama`, `akun_idAkun`) VALUES 
('Dewi Kartini', 4);

INSERT INTO `uuuisa`.`buku` (`judulBuku`, `jenisBuku`, `jumlahHalaman`, `jumlahBuku`, `lokasiBuku`, `bahasaBuku`, `pengarangBuku`) VALUES 
('Matematika SMA Kelas X', 'Buku Pelajaran', 250, 50, 'Rak A1', 'Indonesia', 'Tim Guru Matematika'),
('Fisika Dasar', 'Buku Referensi', 300, 30, 'Rak B2', 'Indonesia', 'Prof. Ahmad Sanusi'),
('English Grammar', 'Buku Bahasa', 200, 40, 'Rak C3', 'Inggris', 'Betty Schrampfer');

INSERT INTO `uuuisa`.`nisbi` (`nama`, `deskripsi`, `batas_nilai_atas`, `batas_nilai_bawah`) VALUES 
('A', 'Sangat Baik', 100, 90),
('B', 'Baik', 89, 80),
('C', 'Cukup', 79, 70),
('D', 'Kurang', 69, 60),
('E', 'Sangat Kurang', 59, 0);

-- Insert data rapot
INSERT INTO `uuuisa`.`Rapot` (`siswa_idsiswa`) VALUES (1), (2), (3);

INSERT INTO `uuuisa`.`penilaian` 
(`idmataPelajaran`, `idRapot`, `nilai`, `semester`, `tahun_ajaran`, `deskripsi_penilaian`, `nisbi_idnisbi`) 
VALUES 
(1, 1, 85, 'ganjil', 2023, 'Sangat baik dalam memahami konsep dasar', 2),
(2, 1, 90, 'ganjil', 2023, 'Kemampuan berbahasa sangat baik', 1),
(1, 2, 78, 'ganjil', 2023, 'Perlu peningkatan dalam menyelesaikan soal cerita', 3),
(3, 3, 88, 'ganjil', 2023, 'Memahami konsep fisika dengan baik', 2)
ON DUPLICATE KEY UPDATE 
nilai = VALUES(nilai),
semester = VALUES(semester),
tahun_ajaran = VALUES(tahun_ajaran),
deskripsi_penilaian = VALUES(deskripsi_penilaian),
nisbi_idnisbi = VALUES(nisbi_idnisbi);

-- Siswa mengambil mata pelajaran
INSERT INTO `uuuisa`.`siswa_has_mataPelajaran` 
(`siswa_idsiswa`, `mataPelajaran_idmataPelajaran`) 
VALUES 
(1, 1), (1, 2), (1, 3),
(2, 1), (2, 2),
(3, 1), (3, 3)
ON DUPLICATE KEY UPDATE 
siswa_idsiswa = VALUES(siswa_idsiswa),
mataPelajaran_idmataPelajaran = VALUES(mataPelajaran_idmataPelajaran);

-- Guru mengajar mata pelajaran
INSERT INTO `uuuisa`.`guru_has_mataPelajaran` (`guru_idGuru`, `mataPelajaran_idmataPelajaran`) VALUES 
(1, 1), (1, 3),
(2, 3),
(3, 2), (3, 5);

-- Riwayat peminjaman buku 
INSERT INTO `uuuisa`.`riwayat_peminjaman` (`siswa_idsiswa`, `buku_idbuku`, `tanggal_peminjaman`, `tanggal_pengembalian`, `pustakawan_idpustakawan`) VALUES 
(1, 1, '2023-08-10', '2023-08-17', 1),
(2, 3, '2023-08-12', '2023-08-19', 1),
(3, 2, '2023-08-15', '2023-08-22', 1);

INSERT INTO `uuuisa`.`riwayat_aktivitas` (`waktu_masuk`, `waktu_keluar`, `durasi_aktif`, `akun_idAkun`) VALUES 
('2023-08-01 08:00:00', '2023-08-01 12:30:00', '04:30:00', 3),
('2023-08-01 13:00:00', '2023-08-01 15:45:00', '02:45:00', 6),
('2023-08-02 07:30:00', '2023-08-02 11:20:00', '03:50:00', 2);

INSERT INTO `uuuisa`.`status_peminjaman` (`id`, `status`) VALUES 
('1', 'diajukan'), 
('2', 'diterima'), 
('3', 'ditolak');
