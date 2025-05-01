INSERT INTO `uuuisa`.`akun` (`username`, `password`, `role_idrole`) VALUES
('admin', 'iIngRhZ1tQLVe/XEkeEKJZsyrAVLvRzTUC55DfNiZRA=', '1');
-- pass = admin


INSERT INTO `uuuisa`.`role` (`role`) VALUES 
('Admin'), 
('Guru'), 
('Siswa'), 
('Pustakawan');


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


INSERT INTO `uuuisa`.`status_peminjaman` (`id`, `status`) VALUES 
('1', 'diajukan'), 
('2', 'diterima'), 
('3', 'ditolak');



