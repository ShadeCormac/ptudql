use master
go
create database QLThiTracNghiem
go
use QLThiTracNghiem
go

create table TaiKhoan(
	TenDangNhap varchar(20) primary key,
	MatKhau nvarchar(255),
	--1: admin, 2: Giáo viên, 3: học sinh
	LoaiTK int
)
go
create table HocSinh(
	TenTK varchar(20) references TaiKhoan(TenDangNhap) primary key,
	Khoi varchar(10),
	Lop varchar(10),
	HoTen nvarchar(50),
	GioiTinh nvarchar(10),
	Email varchar(50)
)
go
create table GiaoVien(
	TenTK varchar(20) references TaiKhoan(TenDangNhap) primary key,
	Ten nvarchar(50)
	--cần thêm gì nữa?
)
go

--create table QuanTriVien(
--	TenTK varchar(20) references TaiKhoan(TenDangNhap) primary key,

--)

--go
create table KyThi(
	IDKyThi varchar(10) primary key,
	TenKyThi nvarchar(50),
	SLThamGia int, 
	--cho biết là kỳ thi thử/ôn tập hay là thi thật
	LoaiKyThi int,
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime,
	DoKho int
)
go
create table DeThi(
	IdDe varchar(10) primary key,
	GVRaDe varchar(20) references GiaoVien(TenTK),
	DoKho int,
	ThoiGian int
	-- 1: De (20 câu / 40 phút)
	-- 2: Trung Binh (30 câu / 40 phút)
	-- 3: Kho (40 câu / 40 phút)
	-- 4: Cuc kho (50 câu / 40 phút)
)
go

create table CauHoi(
	IdCauHoi int IDENTITY(1,1) primary key,
	NoiDung nvarchar(max),
	CauA nvarchar(max),
	CauB nvarchar(max),
	CauC nvarchar(max),
	CauD nvarchar(max),
	CauTLDung char(1),
	--1: Gíao viên tạo, 2: học sinh đề suất
	LoaiCauHoi int,
	DaDuyet int default 1
)
go

create table KyThi_DeThi(
	IdDe varchar(10) references DeThi(IdDe),
	IdKyThi varchar(10) references KyThi(IdKyThi),
	primary key(IdDe, IdKyThi)
)

go
create table DanhSachThi(
	TKHocSinh varchar(20) references HocSinh(TenTK),
	IdDe varchar(10) references DeThi(IdDe),
	IdKyThi varchar(10) references KyThi(IdKyThi),
	primary key(TKHocSinh, IdDe, IdKyThi), 
	Diem float
)
go

create table BoDeThi(
	IdDe varchar(10) references DeThi(IdDe),
	IdCauHoi int references CauHoi(IdCauHoi), 
	primary key (IdDe, IdCauHoi)
)
go
