create database ThoiKhoaBieu
USE ThoiKhoaBieu
GO
CREATE TABLE GiaoVien
(
MaGV varchar(10) PRIMARY KEY,
HoTen nvarchar(100),
Email nvarchar(max)
--GioiTinh nvarchar(3),
--DiaChi nvarchar(100),
)

CREATE TABLE MonHoc
(
MaMon varchar(10) PRIMARY KEY,
TenMon nvarchar(100),
SoTietTrongTuan int,
MaPhong varchar(10) --Mã phòng LÝ THUYẾT HAY PHÒNG LAB
)

CREATE TABLE Phong
(
MaPhong varchar(10) PRIMARY KEY,
TenPhong nvarchar(100), --LÝ THUYẾT HAY PHÒNG LAB
Tinhtrang int
)
CREATE TABLE Lop
(
MaLop varchar(10) PRIMARY KEY,
TenLop varchar(100),
SiSo int,
MaPhong varchar(10), --mã phòng LÝ THUYẾT HAY PHÒNG LAB 
MaHK varchar(10) --1 hoặc 2
)
CREATE TABLE HocKy
(
MaHK varchar(10) PRIMARY KEY,
HocKy varchar(10)
--NamHoc varchar(10)
)
CREATE TABLE Thu
(
MaThu varchar(10) PRIMARY KEY,
TenThu varchar(100)
)
CREATE TABLE PhanCongGiangDay
(
MaGiaoVien varchar(10),
MaLop varchar(10),
MaMon varchar(10),
MaThu varchar(10),
ThoiLuong int,
TietBatDau int,
TietKetThuc int,
PRIMARY KEY(MaGiaoVien, MaLop, MaMon,MaThu)
)
ALTER TABLE  MonHoc ADD FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong);
ALTER TABLE  Lop ADD FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong);
ALTER TABLE  Lop ADD FOREIGN KEY(MaHK) REFERENCES HocKy(MaHK);
ALTER TABLE  PhanCongGiangDay ADD FOREIGN KEY(MaGiaoVien) REFERENCES GiaoVien(MaGV);
ALTER TABLE  PhanCongGiangDay ADD FOREIGN KEY(MaLop) REFERENCES Lop(MaLop);
ALTER TABLE  PhanCongGiangDay ADD FOREIGN KEY(MaMon) REFERENCES MonHoc(MaMon);
ALTER TABLE  PhanCongGiangDay ADD FOREIGN KEY(MaThu) REFERENCES Thu(MaThu);



