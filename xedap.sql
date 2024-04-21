use master
go
iF EXISTS(SELECT 1 FROM sys.databases WHERE name ='Xedap')
	DROP DATABASE [Xedap]
GO
go

create database Xedap
go
use Xedap
go
create table LoaiThe
(
MaloaiThe int primary key,
TenThe nvarchar(50)
)
go
insert into LoaiThe values(0,N'Chưa kích hoạt')
insert into LoaiThe values(1,N'Thẻ trả trườc')
insert into LoaiThe values(2,N'Thẻ trả sau')
go
create table TheXE
(
MaThe VARCHAR(10) primary key,
MatKhau nvarchar(50) unique,
TenNganHang nvarchar(100),
SoDu Money,
MaloaiThe int foreign key (MaloaiThe) references LoaiThe(MaloaiThe),

)
create table NguoiDung
(
MaKh varchar(10) primary key,
HoTen nvarchar(50),
GioiTinh bit,
SDT varchar(10),
MaThe varchar(10) foreign key (MaThe) references TheXe(MaThe)
)
create table LoaiXe
(
MaLoai varchar(10) primary key,
TenXe nvarchar(100),
SoLuong int default 0,
GiaTien Money,
DonGiaMuon money,
HangXe nvarchar(50),
XuatSu nvarchar(50)
)
create table TrangThaiXe
(
Matt int primary key,
TenTrangThai nvarchar(50)
)
create table Xe
(
MaXe varchar(10) primary key,
Maloai varchar(10) foreign key (MaLoai) references LoaiXe(MaLoai),
Matt int foreign key (Matt) references TrangThaiXe(Matt),
)
create table ChiTietMuonxe
(
MaKh varchar(10) foreign key (makh) references NguoiDung(makh),
MaXe varchar(10)   foreign key (maxe) references xe(maxe),
primary key(makh,maxe),
ThoiGianBatDau date,
ThoiGianKetThuc date,
DonGia money,
)

create table ChiNhanh
(
MaCN varchar(10) primary key,
TenChiNhanh nvarchar(100),
DiaChi nvarchar(100)

)
create table MayBanThe
(
MaMay varchar(10) primary key,
SoDu money,
SoTheConlai int,
MaCN varchar(10) foreign key (macn) references ChiNhanh(macn)
)
create table NhanVien
(
MaNV varchar(10) primary key,
HoTen nvarchar(100),
GioiTinh bit,
NgaySinh date,
SDT varchar(10),
DiaChi nvarchar(100),
LoaiNV nvarchar(20),
Luong money,
MaCN  varchar(10) foreign key (macn) references ChiNhanh(macn)
)
create table ThietBiMuonXe
(
MaTB varchar(10) primary key,
MaCN  varchar(10) foreign key (macn) references chinhanh(macn),
MaXE varchar(10) foreign key (maxe) references xe(maxe),
TrangThai bit
)



