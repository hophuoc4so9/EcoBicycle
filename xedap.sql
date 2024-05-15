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
insert into LoaiThe values(1,N'Thẻ trả trước')
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
SDT varchar(11),
--ngaydangky date ,
)

go
select thexe.*,TenThe from thexe, loaithe where thexe.maloaithe=loaithe.maloaithe
go

insert into TheXE values(0,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(1,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(2,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(3,111111,null,null,100000000,1,N'Phước',1,'0349146401')
insert into TheXE values(4,111111,null,null,null,0,null,null,null)
insert into TheXE values(6,111111,null,null,null,0,null,null,null)
insert into TheXE values(7,111111,null,null,null,0,null,null,null)
insert into TheXE values(8,111111,null,null,null,0,null,null,null)
insert into TheXE values(9,111111,null,null,null,0,null,null,null)
insert into TheXE values(5,111111,null,null,null,0,null,null,null)

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
select * from thexe
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
MaXe int   IDENTITY(1,1) primary key ,
Maloai int foreign key (MaLoai) references LoaiXe(MaLoai),
Matt int foreign key (Matt) references TrangThaiXe(Matt),
)
go

--SET IDENTITY_INSERT Xe on
go
--insert into Xe values(null,1,1)
go
--SET IDENTITY_INSERT Xe off
insert into Xe(maloai,matt) values(1,1)
insert into Xe(maloai,matt) values(0,2)
insert into Xe(maloai,matt) values(0,0)

go
create table ChiTietMuonxe
(
MaThe int foreign key (MaThe) references TheXE(MaThe),
MaXe int   foreign key (maxe) references xe(maxe),

ThoiGianBatDau date,
ThoiGianKetThuc date,
DonGia money,
primary key(MaThe,maxe,ThoiGianBatDau),
)
go
insert into ChiTietMuonxe values(0,1,'2024-3-1','2024-5-1',3000)
insert into ChiTietMuonxe values(0,1,'2024-3-2','2024-4-1',3000)

insert into ChiTietMuonxe values(0,1,'2024-2-1','2024-3-1',3000)
insert into ChiTietMuonxe values(0,1,'2023-1-1','2023-2-1',3000)

insert into ChiTietMuonxe values(0,1,'2024-1-1','2024-2-1',3000)

insert into ChiTietMuonxe values(0,1,'2024-2-2','2024-4-1',3000)
insert into ChiTietMuonxe values(0,1,'2024-2-3','2024-2-1',3000)

go
select maxe,mathe,ThoiGianBatDau, DATEDIFF(HOUR,ThoiGianBatDau ,  ThoiGianKetThuc)*DonGia as tongtien from ChiTietMuonxe
		where  DATEPART(year,ThoiGianKetThuc) = 2024 
		
go
create table ChiNhanh
(
MaCN varchar(10) primary key,
TenChiNhanh nvarchar(100),
DiaChi nvarchar(1000)
)
go
insert into ChiNhanh values(N'bd',N'Bình Dương',N'Thủ Dầu Một')
insert into ChiNhanh values(N'bd2',N'Bình Dương',N'Thủ Dầu Một')
go
create table MayBanThe
(
MaMay int primary key,
SoDu money,
SoTheConlai int default 0,
MaCN varchar(10) foreign key (macn) references ChiNhanh(macn)
)
go

go
insert into MayBanThe values(1,1000000000,0,'bd')
insert into MayBanThe values(2,1000000000,0,'bd')
insert into MayBanThe values(3,1000000000,0,'bd')
insert into MayBanThe values(4,1000000000,0,'bd2')
insert into MayBanThe values(5,1000000000,0,'bd2')
insert into MayBanThe values(6,1000000000,0,'bd2')
go
create table ChiTietTheXeMayBan
(
MaThe int foreign key (MaThe) references TheXE(MaThe),
MaMay int foreign key (MaMay) references MayBanThe(MaMay),
primary key(mathe,mamay),
)
go
insert into ChiTietTheXeMayBan values(4,1)
insert into ChiTietTheXeMayBan values(5,1)
insert into ChiTietTheXeMayBan values(6,1)
insert into ChiTietTheXeMayBan values(7,2)
insert into ChiTietTheXeMayBan values(8,2)
insert into ChiTietTheXeMayBan values(9,2)
go
select * from ChiTietTheXeMayBan
go
select top (1) * from ChiTietTheXeMayBan where mamay=1;

go
create table LoaiNhanVien
(
LoaiNV int identity(1,1) primary key,
tenLoaiNV nvarchar(20)
)
go

insert into LoaiNhanVien values(N'Quản lý')
insert into LoaiNhanVien values(N'Sửa chữa')
insert into LoaiNhanVien values(N'Nhân viên')
go
select * from LoaiNhanVien
go
create table NhanVien
(
MaNV int identity(1,1) primary key,
HoTen nvarchar(100),
GioiTinh bit,
NgaySinh date,
SDT varchar(10),
DiaChi nvarchar(100),
LoaiNV int foreign key (LoaiNV) references LoaiNhanVien(LoaiNV),
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
select * from ChiNhanh
go
insert into ThietBiMuonXe values(1,'bd',1,0)
insert into ThietBiMuonXe values(2,'bd',0,0)
insert into ThietBiMuonXe values(3,'bd',0,0)
insert into ThietBiMuonXe values(4,'bd',0,0)
insert into ThietBiMuonXe values(5,'bd',0,0)
insert into ThietBiMuonXe values(6,'bd',0,0)
insert into ThietBiMuonXe values(7,'bd2',1,0)
insert into ThietBiMuonXe values(8,'bd2',0,0)
go
insert into ChiNhanh values(N'bd213',N'Bình dương',N'Tân uyên')
go
insert into ThietBiMuonXe values(9,'bd213',0,0)
insert into ThietBiMuonXe values(10,'bd213',0,0)
insert into ThietBiMuonXe values(11,'bd213',0,0)
insert into ThietBiMuonXe values(12,'bd213',0,0)
select * from ThietBiMuonXe
go

	

go
create view view_1 as
select cn.MaCN, cn.TenChiNhanh,cn.DiaChi, COUNT(t.trangthai) as soxe from  ChiNhanh cn left join ThietBiMuonXe t on  cn.MaCN=t.MaCN and t.TrangThai=1
group by cn.MaCN, cn.TenChiNhanh,cn.DiaChi
go
select  * from view_1
go
create view viewxe_1 as
select xe.*,a.MaCN
from xe left join (select t.MaCN,t.MaXE from chinhanh,thietbimuonxe t where t.MaCN=ChiNhanh.MaCN) as a
on xe.MaXe=a.MaXE
go
select * from LoaiXe
go
create view viewxe_2 as
select MaXe,LoaiXe.TenXe,TrangThaiXe.TenTrangThai,MaCN,TrangThaiXe.Matt,LoaiXe.MaLoai
from viewxe_1, LoaiXe,TrangThaiXe
where viewxe_1.Maloai=LoaiXe.MaLoai and viewxe_1.Matt=TrangThaiXe.Matt
go
select * from viewxe_2
go
create view view_2 as
select cn.MaCN, cn.TenChiNhanh,cn.DiaChi,cn.soxe, COUNT(m23.MaThe) as SoThe from view_1 cn left join (select m.MaCN,c.MaThe from ChiTietTheXeMayBan c join MayBanThe m on c.MaMay=m.MaMay) as  m23
on m23.MaCN=cn.MaCN 
group by cn.MaCN, cn.TenChiNhanh,cn.DiaChi,cn.soxe
go
select * from view_2
go
CREATE PROCEDURE upc_DoanhThuThangNam @thang int, @nam int
AS
begin
if(@thang =0)
begin
		select maxe,mathe,ThoiGianBatDau, DATEDIFF(HOUR, ThoiGianBatDau, ThoiGianKetThuc)*DonGia as tongtien from ChiTietMuonxe
		where DATEPART(month,ThoiGianKetThuc) = @thang and DATEPART(year,ThoiGianKetThuc) = @nam 
		
end
else
begin
		select maxe,mathe,ThoiGianBatDau, DATEDIFF(HOUR,ThoiGianBatDau, ThoiGianKetThuc )*DonGia as tongtien from ChiTietMuonxe
		where  DATEPART(year,ThoiGianKetThuc) = @nam 
		
end
end
GO
go
create proc usp_suaThongTinXe( @maxe int, @maloai int , @matt int ,@MaCN varchar(10) )
as
begin
	update xe
	set xe.Maloai = @maloai,Matt=@matt
	where MaXe=@maxe
	update ThietBiMuonXe
	set TrangThai=0,MaXE=0
	where MaXe=@maxe

	if(exists (select * from ThietBiMuonXe where MaCN = @MaCN and TrangThai=0))
	begin
	declare @matb int  = (select top(1) MaTB from ThietBiMuonXe where MaCN = @MaCN and TrangThai=0)
	
	update ThietBiMuonXe
	set MaCN=@MaCN,MaXE= @maxe,TrangThai=1
	where MaTB=@matb
	end
	else
	print(N'Không đủ thiết bị mượn xe ở chi nhánh này')
	

end

go
select * from ChiNhanh
go


exec usp_suaThongTinXe 1,0,0, N'bd';
go
select * from ChiTietMuonxe
go
create view View_DoanhThu as 
select month(ThoiGianKetThuc) as thang, year(ThoiGianKetThuc) as nam  , sum( datediff(hour,thoigianbatdau,ThoiGianKetThuc)* dongia) as Doanhthu
from chitietmuonxe
group by month(ThoiGianKetThuc), year(ThoiGianKetThuc)
go
select * from View_DoanhThu

go
go
create view View_DoanhThu_2 as 
select month(ThoiGianKetThuc) as thang, year(ThoiGianKetThuc) as nam, (CONVERT(VARCHAR(10), month(ThoiGianKetThuc))  +'/'+ CONVERT(VARCHAR(10), year(ThoiGianKetThuc))  ) as N'Tháng'  , sum( datediff(hour,thoigianbatdau,ThoiGianKetThuc)* dongia) as Doanhthu
from chitietmuonxe
group by month(ThoiGianKetThuc), year(ThoiGianKetThuc),(CONVERT(VARCHAR(10), month(ThoiGianKetThuc))  +'/'+ CONVERT(VARCHAR(10), year(ThoiGianKetThuc))  )
go
select * from View_DoanhThu_2



go
select * from xe
select * from view_1
go

select * from MayBanThe
where MayBanThe.MaCn='bd'
go
select * from MayBanThe where  MayBanThe.MaCn='bd2' 
/*
update ChiTietTheXeMayBan
set ChiTietTheXeMayBan.MaMay=
from MayBanThe,ChiTietTheXeMayBan
where ChiTietTheXeMayBan.MaMay =MayBanThe.MaMay and MayBanThe.MaCn='bd' and mathe=4*/