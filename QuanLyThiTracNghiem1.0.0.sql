﻿create database QLThiTracNghiem
go
use QLThiTracNghiem
go

create table TaiKhoan(
	TenDangNhap varchar(20) primary key,
	MatKhau varchar(20),
	--1: admin, 2: Giáo viên, 3: học sinh
	LoaiTK int
)
go
create table HocSinh(
	TenTK varchar(20) references TaiKhoan(TenDangNhap) primary key,
	Khoi varchar(10),
	Lop varchar(10),
	HoTen nvarchar(50)
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
	LoaiKyThi int
)
go
create table DeThi(
	IdDe varchar(10) primary key,
	GVRaDe varchar(20) references GiaoVien(TenTK),
	--chi tiết đề?
)
go

create table CauHoi(
	IdCauHoi varchar(10) primary key,
	NoiDung nvarchar(max),
	CauA nvarchar(max),
	CauB nvarchar(max),
	CauC nvarchar(max),
	CauD nvarchar(max),
	CauTLDung char(1),
	--1: Gíao viên tạo, 2: học sinh đề suất
	LoaiCauHoi int
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
	IdCauHoi varchar(10) references CauHoi(IdCauHoi), 
	primary key (IdDe, IdCauHoi)
)
go