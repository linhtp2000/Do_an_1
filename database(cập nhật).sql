create database ThoiKhoaBieu
USE ThoiKhoaBieu
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

--CREATE TABLE MonHoc
--(
--MaMon varchar(10) PRIMARY KEY,
--TenMon nvarchar(100),
--SoLuongSV int,
--Lab int FOREIGN KEY(Lab) REFERENCES LoaiPhong(Lab),
--)
CREATE TABLE GiaoVien_Mon
(
MaGV varchar(10),
HoTen nvarchar(100),
Email nvarchar(max),
MonHoc nvarchar(100),
MaMon varchar(10),
SoTiet1Tuan int,
PRIMARY KEY(MaGV, MaMon)
--Tinhtrang int
--GioiTinh nvarchar(3),
--DiaChi nvarchar(100),
)

CREATE TABLE SinhVien
(
MaNhomSV varchar(10) PRIMARY KEY,
TenNhomSV varchar(100)
)
CREATE TABLE Lop
(
MaLop varchar(10) PRIMARY KEY,
TenLop varchar(100),
SiSo int,
MaNhomSV varchar(10) FOREIGN KEY(MaNhomSV) REFERENCES SinhVien(MaNhomSV)
)
CREATE TABLE BaiGiang
(
MaBG varchar(10) PRIMARY KEY,
MaNhomSV varchar(10)REFERENCES SinhVien(MaNhomSV),
MaMon varchar(10),-- FOREIGN KEY(MaMon) REFERENCES GiaoVien_Mon(MaMon),
MaGV varchar(10),-- FOREIGN KEY(MaGV) REFERENCES GiaoVien_Mon(MaGV),
MaPhong varchar(10) FOREIGN KEY(MaPhong) REFERENCES Phong(MaPhong),
Tuan int,
Thu int,
TietBatDau int,
TietKetThuc int,
FOREIGN KEY(MaGV, MaMon) REFERENCES GiaoVien_Mon(MaGV, MaMon)
)



