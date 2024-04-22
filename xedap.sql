go
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
MaThe int primary key,
MatKhau int not null,
MaNganHang nvarchar(100),
TenNganHang nvarchar(100),
SoDu Money,
MaloaiThe int foreign key (MaloaiThe) references LoaiThe(MaloaiThe),
HoTen nvarchar(50),
GioiTinh bit,
SDT varchar(10)
)
go
insert into TheXE values(0,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(1,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(2,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(3,111111,null,null,100000000,1,N'Phước',1,'0349146401')
go
/*create table NguoiDung
(
--MaKh int primary key,

MaThe int foreign key (MaThe) references TheXe(MaThe),
primary key(MaThe)
)

go
insert into NguoiDung values(N'Phước',1,'0349146401',0)
insert into NguoiDung values(N'Phước',1,'0349146401',1)
insert into NguoiDung values(N'Phước',1,'0349146401',2)
insert into NguoiDung values(N'Phước',1,'0349146401',3)*/
go
go
create table LoaiXe
(
MaLoai int primary key,
TenXe nvarchar(100),
SoLuong int default 0,
GiaTien Money,
DonGiaMuon money,
HangXe nvarchar(50),
XuatSu nvarchar(50),
hinhanh varbinary(max),
)
go
insert into LoaiXe values(0,N'Xe đạp',0,600000,3000,N'Martin',N'Việt Nam',null)
insert into LoaiXe values(1,N'Xe đạp điện',0,800000,3000,N'Martin',N'Việt Nam',null)

go
go
create table TrangThaiXe
(
Matt int primary key,
TenTrangThai nvarchar(50)
)
go
insert into TrangThaiXe values(0,N'Bình thường')
insert into TrangThaiXe values(1,N'Đang mượn')
insert into TrangThaiXe values(2,N'Xe bị hư')

go
create table Xe
(
MaXe int primary key,
Maloai int foreign key (MaLoai) references LoaiXe(MaLoai),
Matt int foreign key (Matt) references TrangThaiXe(Matt),
)
go
insert into Xe values(1,1,1)
insert into Xe values(2,0,2)
insert into Xe values(3,0,0)

go
create table ChiTietMuonxe
(
MaThe int foreign key (MaThe) references TheXE(MaThe),
MaXe int   foreign key (maxe) references xe(maxe),
primary key(MaThe,maxe),
ThoiGianBatDau date,
ThoiGianKetThuc date,
DonGia money,
)

create table ChiNhanh
(
MaCN varchar(10) primary key,
TenChiNhanh nvarchar(100),
DiaChi nvarchar(1000)
)
go
insert into ChiNhanh values('bd',N'Bình Dương',N'Thủ Dầu Một')


go
create table MayBanThe
(
MaMay int primary key,
SoDu money,
SoTheConlai int default 0,
MaCN varchar(10) foreign key (macn) references ChiNhanh(macn)
)
go
insert into MayBanThe values(1,1000000000,0,'bd')
go
create table NhanVien
(
MaNV int identity(1,1) primary key,
HoTen nvarchar(100),
GioiTinh bit,
NgaySinh date,
SDT varchar(10),
DiaChi nvarchar(100),
LoaiNV nvarchar(20),
Luong money,
username varchar(100)not null unique,
pass varchar(100) not null,
--MaCN  varchar(10) foreign key (macn) references ChiNhanh(macn)
)
go
insert into NhanVien(HoTen,GioiTinh,NgaySinh,SDT,DiaChi,LoaiNV,Luong,username,pass) values(N'Hồ Tuán Phước',0,null,null,null,1,10000,'admin','123')
go
create table ThietBiMuonXe
(
MaTB int primary key,
MaCN  varchar(10) foreign key (macn) references chinhanh(macn),
MaXE int,
-- int foreign key (maxe) references xe(maxe),
TrangThai bit
)
go
insert into ThietBiMuonXe values(1,'bd',1,1)
go


