-- MySQL Workbench Synchronization
-- Generated: 2025-04-16 21:35
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: chellyne

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- 1. Buat tabel-tabel dasar terlebih dahulu
CREATE TABLE IF NOT EXISTS uuuisa.role (
  idrole INT(11) NOT NULL AUTO_INCREMENT,
  role VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (idrole))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.akun (
  idAkun INT(11) NOT NULL AUTO_INCREMENT,
  username VARCHAR(45) NOT NULL,
  password VARCHAR(255) NOT NULL,
  role_idrole INT(11) NOT NULL,
  PRIMARY KEY (idAkun),
  INDEX fk_akun_role1_idx (role_idrole ASC),
  CONSTRAINT fk_akun_role1
    FOREIGN KEY (role_idrole)
    REFERENCES uuuisa.role (idrole)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.kelas (
  idKelas INT(11) NOT NULL AUTO_INCREMENT,
  namaKelas VARCHAR(45) NULL DEFAULT NULL,
  kapasitasKelas INT(11) NULL DEFAULT NULL,
  lantaiRuangan VARCHAR(45) NULL DEFAULT NULL,
  jenjang VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (idKelas))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.mataPelajaran (
  idmataPelajaran INT(11) NOT NULL AUTO_INCREMENT,
  namaMataPelajaran VARCHAR(45) NULL DEFAULT NULL,
  durasiPembelajaran INT(11) NULL DEFAULT NULL,
  statusMataPelajaran VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (idmataPelajaran))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.nisbi (
  idnisbi INT(11) NOT NULL AUTO_INCREMENT,
  nama VARCHAR(45) NOT NULL,
  deskripsi VARCHAR(45) NOT NULL,
  batas_nilai_atas INT(11) NOT NULL,
  batas_nilai_bawah INT(11) NOT NULL,
  PRIMARY KEY (idnisbi))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

-- 2. Buat tabel-tabel yang memiliki foreign key ke tabel dasar
CREATE TABLE IF NOT EXISTS uuuisa.guru (
  idGuru INT(11) NOT NULL AUTO_INCREMENT,
  nama VARCHAR(45) NULL DEFAULT NULL,
  email VARCHAR(45) NULL DEFAULT NULL,
  nomorTlp VARCHAR(45) NULL DEFAULT NULL,
  tanggalLahir DATE NULL DEFAULT NULL,
  pendidikanTerakhir VARCHAR(45) NULL DEFAULT NULL,
  akun_idAkun INT(11) NOT NULL,
  PRIMARY KEY (idGuru),
  INDEX fk_guru_akun1_idx (akun_idAkun ASC),
  CONSTRAINT fk_guru_akun1
    FOREIGN KEY (akun_idAkun)
    REFERENCES uuuisa.akun (idAkun)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.siswa (
  idsiswa INT(11) NOT NULL AUTO_INCREMENT,
  nama VARCHAR(45) NULL DEFAULT NULL,
  tanggalLahir DATE NULL DEFAULT NULL,
  alamatRumah VARCHAR(45) NULL DEFAULT NULL,
  tahunMasuk YEAR NULL DEFAULT NULL,
  emailSekolah VARCHAR(45) NULL DEFAULT NULL,
  akun_idAkun INT(11) NOT NULL,
  kelas_idKelas INT(11) NOT NULL,
  PRIMARY KEY (idsiswa),
  INDEX fk_siswa_akun1_idx (akun_idAkun ASC),
  INDEX fk_siswa_kelas1_idx (kelas_idKelas ASC),
  CONSTRAINT fk_siswa_akun1
    FOREIGN KEY (akun_idAkun)
    REFERENCES uuuisa.akun (idAkun)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_siswa_kelas1
    FOREIGN KEY (kelas_idKelas)
    REFERENCES uuuisa.kelas (idKelas)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.pustakawan (
  idpustakawan INT(11) NOT NULL AUTO_INCREMENT,
  Nama VARCHAR(45) NOT NULL,
  akun_idAkun INT(11) NOT NULL,
  PRIMARY KEY (idpustakawan),
  INDEX fk_pustakawan_akun1_idx (akun_idAkun ASC),
  CONSTRAINT fk_pustakawan_akun1
    FOREIGN KEY (akun_idAkun)
    REFERENCES uuuisa.akun (idAkun)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.buku (
  idbuku INT(11) NOT NULL AUTO_INCREMENT,
  judulBuku VARCHAR(45) NOT NULL,
  jenisBuku VARCHAR(45) NOT NULL,
  jumlahHalaman INT(11) NOT NULL,
  jumlahBuku INT(11) NOT NULL,
  lokasiBuku VARCHAR(45) NOT NULL,
  bahasaBuku VARCHAR(45) NOT NULL,
  pengarangBuku VARCHAR(45) NOT NULL,
  PRIMARY KEY (idbuku))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.Rapot (
  idRapot INT(11) NOT NULL AUTO_INCREMENT,
  siswa_idsiswa INT(11) NOT NULL,
  PRIMARY KEY (idRapot),
  INDEX fk_Rapot_siswa1_idx (siswa_idsiswa ASC),
  CONSTRAINT fk_Rapot_siswa1
    FOREIGN KEY (siswa_idsiswa)
    REFERENCES uuuisa.siswa (idsiswa)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

-- 3. Buat tabel-tabel junction/relasi
CREATE TABLE IF NOT EXISTS uuuisa.siswa_has_mataPelajaran (
  siswa_idsiswa INT(11) NOT NULL,
  mataPelajaran_idmataPelajaran INT(11) NOT NULL,
  PRIMARY KEY (siswa_idsiswa, mataPelajaran_idmataPelajaran),
  INDEX fk_siswa_has_mataPelajaran_mataPelajaran1_idx (mataPelajaran_idmataPelajaran ASC),
  INDEX fk_siswa_has_mataPelajaran_siswa1_idx (siswa_idsiswa ASC),
  CONSTRAINT fk_siswa_has_mataPelajaran_siswa1
    FOREIGN KEY (siswa_idsiswa)
    REFERENCES uuuisa.siswa (idsiswa)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_siswa_has_mataPelajaran_mataPelajaran1
    FOREIGN KEY (mataPelajaran_idmataPelajaran)
    REFERENCES uuuisa.mataPelajaran (idmataPelajaran)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.guru_has_mataPelajaran (
  guru_idGuru INT(11) NOT NULL,
  mataPelajaran_idmataPelajaran INT(11) NOT NULL,
  PRIMARY KEY (guru_idGuru, mataPelajaran_idmataPelajaran),
  INDEX fk_guru_has_mataPelajaran_mataPelajaran1_idx (mataPelajaran_idmataPelajaran ASC),
  INDEX fk_guru_has_mataPelajaran_guru1_idx (guru_idGuru ASC),
  CONSTRAINT fk_guru_has_mataPelajaran_guru1
    FOREIGN KEY (guru_idGuru)
    REFERENCES uuuisa.guru (idGuru)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_guru_has_mataPelajaran_mataPelajaran1
    FOREIGN KEY (mataPelajaran_idmataPelajaran)
    REFERENCES uuuisa.mataPelajaran (idmataPelajaran)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.kelas_has_guru (
  kelas_idKelas INT(11) NOT NULL,
  guru_idGuru INT(11) NOT NULL,
  PRIMARY KEY (kelas_idKelas, guru_idGuru),
  INDEX fk_kelas_has_guru_guru1_idx (guru_idGuru ASC),
  INDEX fk_kelas_has_guru_kelas1_idx (kelas_idKelas ASC),
  CONSTRAINT fk_kelas_has_guru_kelas1
    FOREIGN KEY (kelas_idKelas)
    REFERENCES uuuisa.kelas (idKelas)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_kelas_has_guru_guru1
    FOREIGN KEY (guru_idGuru)
    REFERENCES uuuisa.guru (idGuru)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.mataPelajaran_has_guru (
  mataPelajaran_idmataPelajaran INT(11) NOT NULL,
  guru_idGuru INT(11) NOT NULL,
  PRIMARY KEY (mataPelajaran_idmataPelajaran, guru_idGuru),
  INDEX fk_mataPelajaran_has_guru_guru1_idx (guru_idGuru ASC),
  INDEX fk_mataPelajaran_has_guru_mataPelajaran1_idx (mataPelajaran_idmataPelajaran ASC),
  CONSTRAINT fk_mataPelajaran_has_guru_mataPelajaran1
    FOREIGN KEY (mataPelajaran_idmataPelajaran)
    REFERENCES uuuisa.mataPelajaran (idmataPelajaran)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_mataPelajaran_has_guru_guru1
    FOREIGN KEY (guru_idGuru)
    REFERENCES uuuisa.guru (idGuru)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.riwayat_peminjaman (
  siswa_idsiswa INT(11) NOT NULL,
  buku_idbuku INT(11) NOT NULL,
  tanggal_peminjaman DATE NOT NULL,
  tanggal_pengembalian DATE NOT NULL,
  pustakawan_idpustakawan INT(11) NOT NULL,
  PRIMARY KEY (siswa_idsiswa, buku_idbuku),
  INDEX fk_siswa_has_buku_buku1_idx (buku_idbuku ASC),
  INDEX fk_siswa_has_buku_siswa1_idx (siswa_idsiswa ASC),
  INDEX fk_riwayat_peminjaman_pustakawan1_idx (pustakawan_idpustakawan ASC),
  CONSTRAINT fk_siswa_has_buku_siswa1
    FOREIGN KEY (siswa_idsiswa)
    REFERENCES uuuisa.siswa (idsiswa)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_siswa_has_buku_buku1
    FOREIGN KEY (buku_idbuku)
    REFERENCES uuuisa.buku (idbuku)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_riwayat_peminjaman_pustakawan1
    FOREIGN KEY (pustakawan_idpustakawan)
    REFERENCES uuuisa.pustakawan (idpustakawan)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.penilaian (
  idmataPelajaran INT(11) NOT NULL,
  idRapot INT(11) NOT NULL,
  nilai INT(11) NOT NULL,
  semester ENUM('ganjil', 'genap') NOT NULL,
  tahun_ajaran SMALLINT(6) NOT NULL,
  deskripsi_penilaian VARCHAR(200) NOT NULL,
  nisbi_idnisbi INT(11) NOT NULL,
  PRIMARY KEY (idmataPelajaran, idRapot),
  INDEX fk_mataPelajaran_has_Rapot_Rapot1_idx (idRapot ASC),
  INDEX fk_mataPelajaran_has_Rapot_mataPelajaran1_idx (idmataPelajaran ASC),
  INDEX fk_penilaian_nisbi1_idx (nisbi_idnisbi ASC),
  CONSTRAINT fk_mataPelajaran_has_Rapot_mataPelajaran1
    FOREIGN KEY (idmataPelajaran)
    REFERENCES uuuisa.mataPelajaran (idmataPelajaran)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_mataPelajaran_has_Rapot_Rapot1
    FOREIGN KEY (idRapot)
    REFERENCES uuuisa.Rapot (idRapot)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_penilaian_nisbi1
    FOREIGN KEY (nisbi_idnisbi)
    REFERENCES uuuisa.nisbi (idnisbi)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS uuuisa.riwayat_aktivitas (
  idriwayat_aktivitas INT(11) NOT NULL AUTO_INCREMENT,
  waktu_masuk DATETIME NOT NULL,
  waktu_keluar DATETIME NOT NULL,
  durasi_aktif TIME NOT NULL,
  akun_idAkun INT(11) NOT NULL,
  PRIMARY KEY (idriwayat_aktivitas),
  INDEX fk_riwayat_aktivitas_akun1_idx (akun_idAkun ASC),
  CONSTRAINT fk_riwayat_aktivitas_akun1
    FOREIGN KEY (akun_idAkun)
    REFERENCES uuuisa.akun (idAkun)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;