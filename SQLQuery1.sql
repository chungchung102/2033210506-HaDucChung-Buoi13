create database QL_GiaoVien
use Ql_GiaoVien

create table DV
(
  maDonVi char(10) not null,
  tenDonVi nvarchar(20) not null,
  maCoSo char(10) not null
  primary key(maDonVi)
)
select *from DV
create table GV
(
  maGiaoVien char(10) not null,
  hoTen nvarchar(20) not null,
  sdt char(12) not null,
  ghiChu char(5) not null,
  maDonVi char(10) not null
  Foreign Key (maDonVi) references DV(maDonVi)
)
select*from GV