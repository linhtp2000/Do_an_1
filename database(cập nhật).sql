create database ThoiKhoaBieu
USE ThoiKhoaBieu
GO

CREATE TABLE Phong
(
MaPhong nvarchar(10) PRIMARY KEY,
TenPhong nvarchar(100),
SoLuong int
)
CREATE TABLE GiaoVien
(
MaGV nvarchar(10),
TenGV nvarchar(100),
Email nvarchar(max),
PRIMARY KEY(MaGV)
)

CREATE TABLE SinhVien
(
MaNhomSV nvarchar(10) PRIMARY KEY,
TenNhomSV nvarchar(100)
)
CREATE TABLE MonHoc
(
MaMon nvarchar(10) PRIMARY KEY,
TenMon nvarchar(100),
SoTC int,
SinhVien nvarchar(10) FOREIGN KEY(SinhVien) REFERENCES SinhVien(MaNhomSV),
GiaoVien nvarchar(10) FOREIGN KEY(GiaoVien) REFERENCES GiaoVien(MaGV),
--Lab int FOREIGN KEY(Lab) REFERENCES LoaiPhong(Lab),
)

CREATE TABLE Lop
(
MaLop nvarchar(10) PRIMARY KEY,
TenLop nvarchar(100),
SiSo int,
SinhVien nvarchar(10) FOREIGN KEY(SinhVien) REFERENCES SinhVien(MaNhomSV)
)
CREATE TABLE ThoiGian
(
MaTG int PRIMARY KEY,
Buoi nvarchar(100),
Thu nvarchar(100),
TietBD int,
TietKT int
)

CREATE TABLE BaiGiang
(
MaBG int PRIMARY KEY,
ThoiGian int ,
Phong nvarchar(10), 
MonHoc nvarchar(10),
GiaoVien nvarchar(10),
Lop nvarchar(10) 
)
alter table BaiGiang add  FOREIGN KEY(Phong) REFERENCES Phong(MaPhong);
alter table BaiGiang add FOREIGN KEY(MonHoc) REFERENCES MonHoc(MaMon);
alter table BaiGiang add   FOREIGN KEY(GiaoVien) REFERENCES GiaoVien(MaGV);
alter table BaiGiang add  FOREIGN KEY(Lop) REFERENCES Lop(MaLop);
alter table BaiGiang add  FOREIGN KEY(ThoiGian) REFERENCES ThoiGian(MaTG);

INSERT INTO SinhVien VALUES ('1',N'Sinh Vien nam 1');
INSERT INTO SinhVien VALUES ('2',N'Sinh Vien nam 2');
INSERT INTO SinhVien VALUES ('3',N'Sinh Vien nam 3');
INSERT INTO SinhVien VALUES ('4',N'Sinh Vien nam 4');

INSERT INTO GiaoVien VALUES ('1',N'Lê Mai Hiền Trang','');
INSERT INTO GiaoVien VALUES ('2',N'Nguyễn Ngọc Anh Trang','');
INSERT INTO GiaoVien VALUES ('3',N'Trần Đình Thanh Long','');
INSERT INTO GiaoVien VALUES ('4',N'Huỳnh Thị Mỹ Vân','');
INSERT INTO GiaoVien VALUES ('5',N'Hoàng Trọng Mai Sương','');
INSERT INTO GiaoVien VALUES ('6',N'Lê Quốc Kiệt','');
INSERT INTO GiaoVien VALUES ('7',N'Hứa Trần Phương Thảo','');
INSERT INTO GiaoVien VALUES ('8',N'Nguyễn Trung Hiếu','');
INSERT INTO GiaoVien VALUES ('9',N'Nguyễn Đình Thu','');
INSERT INTO GiaoVien VALUES ('10',N'Trần Hưng Việt','');
INSERT INTO GiaoVien VALUES ('11',N'Trịnh Ngọc Thành','');
INSERT INTO GiaoVien VALUES ('12',N'Nguyễn Đăng Quang','');
INSERT INTO GiaoVien VALUES ('13',N'Nguyễn Trần Thi Văn','');
INSERT INTO GiaoVien VALUES ('14',N'Lê Văn Vinh','');
INSERT INTO GiaoVien VALUES ('15',N'Lê Vĩnh Thịnh','');
INSERT INTO GiaoVien VALUES ('16',N'Trần Công Tú','');
INSERT INTO GiaoVien VALUES ('17',N'Nguyễn Thiên Bảo','');
INSERT INTO GiaoVien VALUES ('18',N'Trần Nhật Quang','');
INSERT INTO GiaoVien VALUES ('19',N'Huỳnh Xuân Phụng','');
INSERT INTO GiaoVien VALUES ('20',N'Trần Tiến Đức','');
INSERT INTO GiaoVien VALUES ('21',N'Từ Tuyết Hồng','');
INSERT INTO GiaoVien VALUES ('22',N'Nguyễn Minh Đạo','');
INSERT INTO GiaoVien VALUES ('23',N'Nguyễn Thị Thanh Vân','');
INSERT INTO GiaoVien VALUES ('24',N'Dương Thị Kim Oanh','');
INSERT INTO GiaoVien VALUES ('25',N'Lê Thị Thanh Hải','');


INSERT INTO MonHoc VALUES ('EHQT130137',N'Anh văn 1',2,'1','1');
INSERT INTO MonHoc VALUES ('MATH143001',N'Đại số tuyến tính và cấu trúc đại số',2,'1','1');
INSERT INTO MonHoc VALUES ('PHED110513',N'Giáo dục thể chất 1',2,'1','2');
INSERT INTO MonHoc VALUES ('INPR130285',N'Nhập môn lập trình',3,'1','2');
INSERT INTO MonHoc VALUES ('INIT130185',N'Nhập môn ngành CNTT',2,'1','3');
INSERT INTO MonHoc VALUES ('GELA220405',N'Pháp luật đại cương',2,'1','3');
INSERT INTO MonHoc VALUES ('MATH132401',N'Toán 1',3,'1','4');
INSERT INTO MonHoc VALUES ('PHYS130902',N'Vật lý 1',2,'1','4');
INSERT INTO MonHoc VALUES ('EHQT130237',N'Anh văn 2',2,'1','5');
INSERT INTO MonHoc VALUES ('EEEN234162',N'Điện tử căn bản',2,'1','5');
INSERT INTO MonHoc VALUES ('PHED110613',N'Giáo dục thể chất 2',1,'2','6');
INSERT INTO MonHoc VALUES ('PRTE230385',N'Kỹ thuật lập trình',2,'2','6');
INSERT INTO MonHoc VALUES ('PHYS111202',N'Thí nghiệm Vật lý 1',1,'2','7');
INSERT INTO MonHoc VALUES ('MATH132501',N'Toán 2',3,'2','7');
INSERT INTO MonHoc VALUES ('DIGR230485',N'Toán rời rạc và lý thuyết đồ thị',3,'2','8');
INSERT INTO MonHoc VALUES ('LLCT120314',N'Tư tưởng Hồ Chí Minh',2,'2','8');
INSERT INTO MonHoc VALUES ('MATH132901',N'Xác suất – Thống kê ứng dụng',2,'2','9');
INSERT INTO MonHoc VALUES ('EHQT230337',N'Anh văn 3',2,'2','9');
INSERT INTO MonHoc VALUES ('DASA230179',N'Cấu trúc dữ liệu và giải thuật',3,'2','10');
INSERT INTO MonHoc VALUES ('DBSY230184',N'Cơ sở dữ liệu',2,'2','10');
INSERT INTO MonHoc VALUES ('IVNC320905',N'Cơ sở văn hóa Việt Nam',2,'3','11');
INSERT INTO MonHoc VALUES ('PHED130715',N'Giáo dục thể chất 3 ',1,'3','11');
INSERT INTO MonHoc VALUES ('CAAL230180',N'Kiến trúc máy tính và hợp ngữ',2,'3','12');
INSERT INTO MonHoc VALUES ('LESK120190',N'Kỹ năng học tập đại học',2,'3','12');
INSERT INTO MonHoc VALUES ('WOPS120390',N'Kỹ năng làm việc trong môi trường kỹ thuật',2,'3','13');
INSERT INTO MonHoc VALUES ('PLSK120290',N'Kỹ năng xây dựng kế hoạch',2,'3','13');
INSERT INTO MonHoc VALUES ('OOPR230279',N'Lập trình hướng đối tượng',3,'3','14');
INSERT INTO MonHoc VALUES ('INLO220405',N'Nhập môn logic học',2,'3','14');
INSERT INTO MonHoc VALUES ('IQMA220205',N'Nhập môn quản trị chất lượng',2,'3','15');
INSERT INTO MonHoc VALUES ('INSO321005',N'Nhập môn xã hội học',2,'3','15');
INSERT INTO MonHoc VALUES ('LLCT150105',N'Những nguyên lý cơ bản CN Mác-Lênin',1,'4','16');
INSERT INTO MonHoc VALUES ('REME320690',N'Phương pháp nghiên cứu khoa học',2,'4','16');
INSERT INTO MonHoc VALUES ('PRBE214262',N'Thực tập điện tử căn bản',1,'4','17');
INSERT INTO MonHoc VALUES ('EHQT230437',N'Hệ điều hành',3,'4','17');
INSERT INTO MonHoc VALUES ('WIPR230579',N'Lập trình trên Windows',3,'4','18');
INSERT INTO MonHoc VALUES ('NEES330380',N'Mạng máy tính căn bản',2,'4','18');
INSERT INTO MonHoc VALUES ('ARIN330585',N'Trí tuệ nhân tạo',2,'4','19');
INSERT INTO MonHoc VALUES ('SYTH220491',N'Tư duy hệ thống',2,'4','19');
INSERT INTO MonHoc VALUES ('INSE330380',N'An toàn thông tin',2,'4','20');
INSERT INTO MonHoc VALUES ('EHQT330537',N'Anh văn 5',2,'4','20');
INSERT INTO MonHoc VALUES ('ADDB331784',N'Cơ sở dữ liệu nâng cao',2,'4','21');
INSERT INTO MonHoc VALUES ('WISE432380',N'An toàn mạng không dây & di động',2,'4','21');
INSERT INTO MonHoc VALUES ('PROJ215879',N'Đồ án CNTT',1,'4','22');
INSERT INTO MonHoc VALUES ('DBMS330284',N'Hệ quản trị cơ sở dữ liệu',2,'1','22');
INSERT INTO MonHoc VALUES ('NSMS432280',N'Hệ thống giám sát an toàn mạng',2,'1','23');
INSERT INTO MonHoc VALUES ('ESYS431080',N'Hệ thống nhúng',2,'2','23');
INSERT INTO MonHoc VALUES ('MALE431085',N'Học máy',2,'2','24');
INSERT INTO MonHoc VALUES ('GEFC220105',N'Kinh tế học đại cương',2,'2','24');
INSERT INTO MonHoc VALUES ('WEPR330479',N'Lập trình Web',3,'3','25');
INSERT INTO MonHoc VALUES ('FOIT331380',N'Lý thuyết thông tin',3,'3','25');

INSERT INTO Phong VALUES ('1','A1-101',30);
INSERT INTO Phong VALUES ('2','A1-102',30);
INSERT INTO Phong VALUES ('3','A1-103',30);
INSERT INTO Phong VALUES ('4','A1-104',30);
INSERT INTO Phong VALUES ('5','A1-105',30);
INSERT INTO Phong VALUES ('6','A2-201',30);
INSERT INTO Phong VALUES ('7','A2-202',30);
INSERT INTO Phong VALUES ('8','A2-203',30);
INSERT INTO Phong VALUES ('9','A2-204',30);
INSERT INTO Phong VALUES ('10','A2-205',30);
INSERT INTO Phong VALUES ('11','A3-301',30);
INSERT INTO Phong VALUES ('12','A3-302',30);
INSERT INTO Phong VALUES ('13','A3-303',30);
INSERT INTO Phong VALUES ('14','A3-304',30);
INSERT INTO Phong VALUES ('15','A3-305',30);
INSERT INTO Phong VALUES ('16','A4-401',30);
INSERT INTO Phong VALUES ('17','A4-402',30);
INSERT INTO Phong VALUES ('18','A4-403',30);
INSERT INTO Phong VALUES ('19','A4-404',30);
INSERT INTO Phong VALUES ('20','A4-405',30);
INSERT INTO Phong VALUES ('21','A5-501',30);
INSERT INTO Phong VALUES ('22','A5-502',30);
INSERT INTO Phong VALUES ('23','A5-503',30);
INSERT INTO Phong VALUES ('24','A5-504',30);
INSERT INTO Phong VALUES ('25','A1-201',30);
INSERT INTO Phong VALUES ('26','A1-202',30);
INSERT INTO Phong VALUES ('27','A2-101',30);
INSERT INTO Phong VALUES ('28','A2-102',30);
INSERT INTO Phong VALUES ('29','A3-101',30);
INSERT INTO Phong VALUES ('30','A3-102',30);
--INSERT INTO Phong VALUES ('31','A3-103',30);
--INSERT INTO Phong VALUES ('32','A4-101',30);
--INSERT INTO Phong VALUES ('33','A4-102',30);
--INSERT INTO Phong VALUES ('34','A5-101',30);
--INSERT INTO Phong VALUES ('35','A5-102',30);


INSERT INTO Lop VALUES ('1','201101A',30,'1');
INSERT INTO Lop VALUES ('2','201101B',30,'1');
INSERT INTO Lop VALUES ('3','201101C',30,'1');
INSERT INTO Lop VALUES ('4','201101D',30,'1');
INSERT INTO Lop VALUES ('5','201101E',30,'1');
INSERT INTO Lop VALUES ('6','191101A',30,'2');
INSERT INTO Lop VALUES ('7','191101B',30,'2');
INSERT INTO Lop VALUES ('8','191101C',30,'2');
INSERT INTO Lop VALUES ('9','191101D',30,'2');
INSERT INTO Lop VALUES ('10','191101E',30,'2');
INSERT INTO Lop VALUES ('11','181101A',30,'3');
INSERT INTO Lop VALUES ('12','181101B',30,'3');
INSERT INTO Lop VALUES ('13','181101C',30,'3');
INSERT INTO Lop VALUES ('14','181101D',30,'3');
INSERT INTO Lop VALUES ('15','181101E',30,'3');
INSERT INTO Lop VALUES ('16','171101A',30,'4');
INSERT INTO Lop VALUES ('17','171101B',30,'4');
INSERT INTO Lop VALUES ('18','171101C',30,'4');
INSERT INTO Lop VALUES ('19','171101D',30,'4');
INSERT INTO Lop VALUES ('20','171101E',30,'4');
--INSERT INTO Lop VALUES ('21','201101CLA',30,'1');
--INSERT INTO Lop VALUES ('22','191101CLA',30,'2');
--INSERT INTO Lop VALUES ('23','191101CLB',30,'3');
--INSERT INTO Lop VALUES ('24','181101CLA',30,'3');
--INSERT INTO Lop VALUES ('25','171101CLA',30,'4');

INSERT INTO ThoiGian VALUES (1,N'Sáng',N'Hai',1,3);
INSERT INTO ThoiGian VALUES (2,N'Sáng',N'Hai',1,2);
INSERT INTO ThoiGian VALUES (3,N'Sáng',N'Hai',2,3);
INSERT INTO ThoiGian VALUES (4,N'Sáng',N'Hai',3,5);
INSERT INTO ThoiGian VALUES (5,N'Sáng',N'Hai',4,5);
--INSERT INTO ThoiGian VALUES (6,N'Sáng','Hai',1,5);
INSERT INTO ThoiGian VALUES (7,N'Sáng',N'Ba',1,3);
INSERT INTO ThoiGian VALUES (8,N'Sáng',N'Ba',1,2);
INSERT INTO ThoiGian VALUES (9,N'Sáng',N'Ba',2,3);
INSERT INTO ThoiGian VALUES (10,N'Sáng',N'Ba',3,5);
INSERT INTO ThoiGian VALUES (11,N'Sáng',N'Ba',4,5);
--INSERT INTO ThoiGian VALUES (12,N'Sáng','Ba',1,5);
INSERT INTO ThoiGian VALUES (13,N'Sáng',N'Tư',1,3);
INSERT INTO ThoiGian VALUES (14,N'Sáng',N'Tư',1,2);
INSERT INTO ThoiGian VALUES (15,N'Sáng',N'Tư',2,3);
INSERT INTO ThoiGian VALUES (16,N'Sáng',N'Tư',3,5);
INSERT INTO ThoiGian VALUES (17,N'Sáng',N'Tư',4,5);
--INSERT INTO ThoiGian VALUES (18,N'Sáng','Tư',1,5);
INSERT INTO ThoiGian VALUES (19,N'Sáng',N'Năm',1,3);
INSERT INTO ThoiGian VALUES (20,N'Sáng',N'Năm',1,2);
INSERT INTO ThoiGian VALUES (21,N'Sáng',N'Năm',2,3);
INSERT INTO ThoiGian VALUES (22,N'Sáng',N'Năm',3,5);
INSERT INTO ThoiGian VALUES (23,N'Sáng',N'Năm',4,5);
--INSERT INTO ThoiGian VALUES (24,N'Sáng','Năm',1,5);
INSERT INTO ThoiGian VALUES (25,N'Sáng',N'Sáu',1,3);
INSERT INTO ThoiGian VALUES (26,N'Sáng',N'Sáu',1,2);
INSERT INTO ThoiGian VALUES (27,N'Sáng',N'Sáu',2,3);
INSERT INTO ThoiGian VALUES (28,N'Sáng',N'Sáu',3,5);
INSERT INTO ThoiGian VALUES (29,N'Sáng',N'Sáu',4,5);
--INSERT INTO ThoiGian VALUES (30,N'Sáng','Sáu',1,5);
INSERT INTO ThoiGian VALUES (31,N'Sáng',N'Bảy',1,3);
INSERT INTO ThoiGian VALUES (32,N'Sáng',N'Bảy',1,2);
INSERT INTO ThoiGian VALUES (33,N'Sáng',N'Bảy',2,3);
INSERT INTO ThoiGian VALUES (34,N'Sáng',N'Bảy',3,5);
INSERT INTO ThoiGian VALUES (35,N'Sáng',N'Bảy',4,5);
--INSERT INTO ThoiGian VALUES (36,N'Sáng','Bảy',1,5);
INSERT INTO ThoiGian VALUES (37,N'Chiều',N'Hai',1,3);
INSERT INTO ThoiGian VALUES (38,N'Chiều',N'Hai',1,2);
INSERT INTO ThoiGian VALUES (39,N'Chiều',N'Hai',2,3);
INSERT INTO ThoiGian VALUES (40,N'Chiều',N'Hai',3,5);
INSERT INTO ThoiGian VALUES (41,N'Chiều',N'Hai',4,5);
--INSERT INTO ThoiGian VALUES (42,N'Chiều','Hai',1,5);
INSERT INTO ThoiGian VALUES (43,N'Chiều',N'Ba',1,3);
INSERT INTO ThoiGian VALUES (44,N'Chiều',N'Ba',1,2);
INSERT INTO ThoiGian VALUES (45,N'Chiều',N'Ba',2,3);
INSERT INTO ThoiGian VALUES (46,N'Chiều',N'Ba',3,5);
INSERT INTO ThoiGian VALUES (47,N'Chiều',N'Ba',4,5);
--INSERT INTO ThoiGian VALUES (48,N'Chiều','Ba',1,5);
INSERT INTO ThoiGian VALUES (49,N'Chiều',N'Tư',1,3);
INSERT INTO ThoiGian VALUES (50,N'Chiều',N'Tư',1,2);
INSERT INTO ThoiGian VALUES (51,N'Chiều',N'Tư',2,3);
INSERT INTO ThoiGian VALUES (52,N'Chiều',N'Tư',3,5);
INSERT INTO ThoiGian VALUES (53,N'Chiều',N'Tư',4,5);
--INSERT INTO ThoiGian VALUES (54,N'Chiều','Tư',1,5);
INSERT INTO ThoiGian VALUES (55,N'Chiều',N'Năm',1,3);
INSERT INTO ThoiGian VALUES (56,N'Chiều',N'Năm',1,2);
INSERT INTO ThoiGian VALUES (57,N'Chiều',N'Năm',2,3);
INSERT INTO ThoiGian VALUES (58,N'Chiều',N'Năm',3,5);
INSERT INTO ThoiGian VALUES (59,N'Chiều',N'Năm',4,5);
--INSERT INTO ThoiGian VALUES (60,N'Chiều','Năm',1,5);
INSERT INTO ThoiGian VALUES (61,N'Chiều',N'Sáu',1,3);
INSERT INTO ThoiGian VALUES (62,N'Chiều',N'Sáu',1,2);
INSERT INTO ThoiGian VALUES (63,N'Chiều',N'Sáu',2,3);
INSERT INTO ThoiGian VALUES (64,N'Chiều',N'Sáu',3,5);
INSERT INTO ThoiGian VALUES (65,N'Chiều',N'Sáu',4,5);
--INSERT INTO ThoiGian VALUES (66,N'Chiều','Sáu',1,5);
INSERT INTO ThoiGian VALUES (67,N'Chiều',N'Bảy',1,3);
INSERT INTO ThoiGian VALUES (68,N'Chiều',N'Bảy',1,2);
INSERT INTO ThoiGian VALUES (69,N'Chiều',N'Bảy',2,3);
INSERT INTO ThoiGian VALUES (70,N'Chiều',N'Bảy',3,5);
INSERT INTO ThoiGian VALUES (71,N'Chiều',N'Bảy',4,5);
--INSERT INTO ThoiGian VALUES (72,N'Chiều','Bảy',1,5);

drop database ThoiKhoaBieu
use BachHoaXanhDBMS
go








