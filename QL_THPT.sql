create database QL_THPT

use QL_THPT 
go

create table NIEN_KHOA-- tao table NIEN_KHOA chua thong tin nam hoc
(
	nien_khoa varchar(20) not null,
	ghi_chu nvarchar(100),

	primary key(nien_khoa)
)
go

create table KHOI-- tao table KHOI chua thong tin khoi
(
	id_khoi char(5) not null unique,
	ten_khoi nvarchar(20) not null,
	so_lop int not null,

	primary key(id_khoi)
)
go

create table GV-- tao table GV chua thong tin giao vien
(
	id_gv char(5) not null,-- vua la id vua la ten dang nhap he thong
	ho_ten nvarchar(50) not null,
	nam_sinh datetime not null,
	gioi_tinh bit not null,
	sdt varchar(10),
	dia_chi nvarchar(50) not null,
	chuyen_mon nvarchar(50) not null,-- mon hoc giang day
	chuc_vu nvarchar(50) not null,-- chuc vu cua giao vien
	mat_khau varchar(50) not null,

	primary key(id_gv),

)
go

create table LOP-- tao table LOP chua thong tin lop
(
	id_lop char(5) not null unique,
	ten_lop nvarchar(20) not null,
	si_so int not null,
	id_khoi char(5) not null,
	id_gv char(5) not null,
	nien_khoa varchar(20),

	primary key(id_lop),
	foreign key(id_khoi) references KHOI(id_khoi),
	foreign key(id_gv) references GV(id_gv),
	foreign key(nien_khoa) references NIEN_KHOA(nien_khoa)

)
go



create table HOCSINH-- tao table HOCSINH chua thong tin hoc sinh
(
	id_hs varchar(10) not null,
	ho_ten nvarchar(50) not null,
	nam_sinh datetime not null,
	gioi_tinh bit not null,
	dia_chi nvarchar(100),
	id_lop char(5) not null, 

	primary key(id_hs),
	foreign key(id_lop) references LOP(id_lop)

)
go

create table MON_HOC-- tao table MON_HOC chua thong tin cac mon hoc
(
	id_monhoc varchar(10) not null,
	ten_monhoc nvarchar(50) not null,
	thoi_luong int not null, --so tiet hoc
	id_gv char(5) not null,-- id cua giao vien giang day mon hoc

	primary key(id_monhoc),
	foreign key(id_gv) references GV(id_gv),

)
go

create table KQHT--tao table KQHT chua ket qua hoc tap
(
	id_kqht varchar(10) not null,
	id_hs varchar(10) not null,
	monhoc nvarchar(50),
	diem_15p1 float,
	diem_15p2 float,
	diem_1t float,
	diem_hk float,
	diem_tb float,
	hanh_kiem nvarchar(10),

	foreign key(id_hs) references HOCSINH(id_hs)


)
