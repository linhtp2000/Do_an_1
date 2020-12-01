create database TimeTable
USE TimeTable
GO

CREATE TABLE LoaiPhong
(
Lab int PRIMARY KEY,
GhiChu varchar(10)
)

CREATE TABLE Phong
(
MaPhong varchar(10) PRIMARY KEY,
TenPhong nvarchar(100), --LÝ THUYẾT HAY PHÒNG LAB
SoLuong int,
Lab int FOREIGN KEY(Lab) REFERENCES LoaiPhong(Lab),
Tinhtrang int
)

CREATE TABLE MonHoc
(
MaMon varchar(10) PRIMARY KEY,
TenMon nvarchar(100),
SoTietTrongTuan int,
Lab int FOREIGN KEY(Lab) REFERENCES LoaiPhong(Lab),
)
CREATE TABLE GiaoVien
(
MaGV varchar(10) PRIMARY KEY,
HoTen nvarchar(100),
Email nvarchar(max),
MaMon varchar(10)REFERENCES MonHoc(MaMon),
Tinhtrang int
--GioiTinh nvarchar(3),
--DiaChi nvarchar(100),
)

--CREATE TABLE Lop
--(
--MaLop varchar(10) PRIMARY KEY,
--TenLop varchar(100),
--SiSo int,
--)

CREATE TABLE KhoaHoc
(
MaKH int PRIMARY KEY,
--Tinhtrang int
)
CREATE TABLE ChuongTrinh
(
MaCT varchar(20) PRIMARY KEY,
MaKH int FOREIGN KEY(MaKH) REFERENCES KhoaHoc(MaKH),
MaHK varchar(10),
MaMon varchar(10)REFERENCES MonHoc(MaMon),
--PRIMARY KEY(MaKH, MaHK,MaMon)
--Tinhtrang int
)

CREATE TABLE ThoiGian
(
MaTG varchar(10) PRIMARY KEY,
Tuan int,
Ngay date,
TietBatDau int,
TietKetThuc int,
Tinhtrang int
)
CREATE TABLE ThoiGianSlot
(
MaTGS varchar(10) PRIMARY KEY,
MaTG varchar(10) FOREIGN KEY(MaTG) REFERENCES ThoiGian(MaTG),
ThoiLuong int,
TietBatDau int,
TietKetThuc int,
Tinhtrang int
)

CREATE TABLE ThoiKhoaBieu
(
MaTKB varchar(10)PRIMARY KEY,
MaTG varchar(10) FOREIGN KEY(MaTG) REFERENCES ThoiGian(MaTG),
MaCT varchar(20) FOREIGN KEY(MaCT) REFERENCES ChuongTrinh(MaCT),
MaMon varchar(10) FOREIGN KEY(MaMon) REFERENCES MonHoc(MaMon),
MaGV varchar(10)FOREIGN KEY(MaGV) REFERENCES GiaoVien(MaGV),
--MaLop varchar(10),
MaPhong varchar(10) FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong)
)
use BachHoaXanh

drop database TimeTable


