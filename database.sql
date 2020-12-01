create database TimeTable
USE TimeTable
GO

--CREATE TABLE LoaiPhong
--(
--Lab int PRIMARY KEY,
--GhiChu varchar(10)
--)

CREATE TABLE Phong
(
MaPhong varchar(10) PRIMARY KEY,
TenPhong nvarchar(100), --LÝ THUYẾT HAY PHÒNG LAB
SoLuong int,
--Lab int FOREIGN KEY(Lab) REFERENCES LoaiPhong(Lab),
--Tinhtrang int
)

CREATE TABLE MonHoc
(
MaMon varchar(10) PRIMARY KEY,
TenMon nvarchar(100),
--SoLuongSV int,
--Lab int FOREIGN KEY(Lab) REFERENCES LoaiPhong(Lab),
)
CREATE TABLE GiaoVien
(
MaGV varchar(10) PRIMARY KEY,
HoTen nvarchar(100),
Email nvarchar(max),
--MaMon varchar(10)REFERENCES MonHoc(MaMon),
--Tinhtrang int
--GioiTinh nvarchar(3),
--DiaChi nvarchar(100),
)

CREATE TABLE Lop
(
MaLop varchar(10) PRIMARY KEY,
TenLop varchar(100),
SiSo int,
)

CREATE TABLE HocSinh
(
MaSV varchar(10) PRIMARY KEY,
TenSV varchar(100)
)
CREATE TABLE BaiGiang
(
MaBG varchar(10) PRIMARY KEY,
MaSV varchar(10)REFERENCES HocSinh(MaSV),
MaMon varchar(10)REFERENCES MonHoc(MaMon),
MaGV varchar(10)FOREIGN KEY(MaGV) REFERENCES GiaoVien(MaGV),
MaPhong varchar(10) FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong),
Tuan int,
Thu int,
TietBatDau int,
TietKetThuc int,
)
use BachHoaXanh

drop database TimeTable


