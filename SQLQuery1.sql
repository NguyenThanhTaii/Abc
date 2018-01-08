use BT_Day2CoBan
create table LOAISP(
	MaLoaiSP varchar(10) primary key,
	TenLoaiSP nvarchar(50)
)
create table NHANVIEN(
	MaNV varchar(10) primary key,
	HoTenNV nvarchar(50),
	GioiTinh char(3),
	QueQuan nvarchar(50),
	Tuoi int
)
create table SANPHAM(
	MaSP varchar(10) primary key,
	TenSP nvarchar(50),
	MaLoaiSP varchar(10) foreign key references LOAISP(MaLoaiSP),
	GiaBan money
)
create table BANHANG(
	MaNV varchar(10) foreign key references NHANVIEN(MaNV),
	MaSP varchar(10) foreign key references SANPHAM(MaSP),
	SoLuongDaBan int
)
--Thêm 1 nhân viên có MãNV là 'NV01', Tên là Nguyễn Chí Phèo, Nam, Quê ở Quảng Trị, 18 tuổi
insert into NHANVIEN values ('NV01',N'Nguyễn Chí Phèo','Nam',N'Quảng Trị',18)

--Xóa những nhân viên nữ quê ở Kon Tum
DELETE FROM NHANVIEN WHERE GioiTinh like 'Nu' and QueQuan like N'KonTum';

--Tăng giá bán lên gấp đôi cho những sản phẩm có mã loại sản phẩm là 'Type001'
UPDATE SANPHAM SET GiaBan = GiaBan*2 WHERE MaLoaiSP='Type001';

--Hãy liệt kê thông tin toàn bộ nhân viên trong công ty
select * from NHANVIEN

--Hãy liệt kê toàn bộ thông tin của nhân viên từ 23 tuổi trở lên và có quê quán ở Bình Định
select * from NHANVIEN where Tuoi >23 and QueQuan like N'Bình Định'

--Hãy liệt kê Mã sản phẩm của những sản phẩm đã từng được bán
select distinct MaSP from BANHANG 

--Hãy liệt kê những nhân viên có họ là Nguyễn
select HoTenNV from NHANVIEN where lEFT(HoTenNV, 6) like N'Nguyễn'

--Hãy liệt kê những nhân viên có tên là Hoa
select HoTenNV from NHANVIEN where right(HoTenNV, 3) like N'Hoa'

--Hãy liệt kê những sản phẩm có tên bao gồm 12 ký tự
select TenSP from SANPHAM where len(TenSP)=12

--Hãy liệt kê những sản phẩm thuộc loại 'Mỹ phẩm'
select TenSP from SANPHAM inner join LOAISP on SANPHAM.MaLoaiSP=LOAISP.MaLoaiSP where LOAISP.TenLoaiSP like N'Mỹ Phẩm'

--Hãy liệt kê những sản phẩm có giá bán dưới 20.000 hoặc chưa từng được bán lần nào

select TenSP from SANPHAM where GiaBan<20000 or MaSP not in (Select MaSP from BANHANG)





--Hãy liệt kê những những nhân viên chưa từng bán được sản phẩm nào và những nhân viên chỉ mới bán được sản phẩm Bột giặt OMO
select distinct * from NHANVIEN,BANHANG inner join SANPHAM on BANHANG.MaSP=SANPHAM.MaSP 
where NHANVIEN.MaNV not in (select MaNV from BANHANG) 
or SANPHAM.TenSP=N'Bột giặt OMO'




--Hãy liệt kê mã nhân viên của những nhân viên có quê ở Gia Lai và chưa từng bán được sản phẩm nào
select * from NHANVIEN
left  join BANHANG on NHANVIEN.MaNV=BANHANG.MaNV where BANHANG.MaNV IS null and NHANVIEN.QueQuan like N'Gia Lai'

--Hãy liệt kê MaSP, TênSP, Mã Loại SP, Giá Bán, Tên Loại SP của tất cả những sản phẩm đã có niêm yết giá bán
select MaSP,TenSP,LoaiSP.MaLoaiSP,GiaBan,TenLoaiSP from SANPHAM left join LoaiSP on SANPHAM.MaLoaiSP=LOAISP.MaLoaiSP where GiaBan is not null




--Hãy liệt kê MãNV, Họ tên NV, Giới Tính, Quê Quán của nhân viên và mã sản phẩm, tên sản phẩm, loại sản phẩm, tên loại sản phẩm, 
select * from NHANVIEN left join BANHANG on NHANVIEN.MaNV=BANHANG.MaNV , BANHANG left join SANPHAM on BANHANG.MaSP=SANPHAM.MaSP




--số lượng đã bán của tất cả các những nhân viên đã từng bán được hàng.
select  MaNV,sum(SoLuongDaBan) from BANHANG group by MaNV

--Hãy liệt kê Mã Loại SP, Tên loại SP của những loại sản phẩm đã từng được bán
select distinct LoaiSP.MaLoaiSP,TenLoaiSP from LOAISP inner join SANPHAM on LOAISP.MaLoaiSP=SANPHAM.MaLoaiSP inner join BANHANG on BANHANG.MaSP=SANPHAM.MaSP

--Hãy liệt kê tên (họ + tên) của những nhân viên trong công ty (nếu có tên trùng nhau thì chỉ hiển thị tên đó 1 lần)
select distinct HoTenNV from NHANVIEN 

--Hãy liệt kê MaNV,  TênNV, Quê Quán của tất cả nhân viên, nếu bạn nào chưa có quê quán thì mục quê quán sẽ hiển thị là 'Cõi trên xuống'
select MaNV,HoTenNV, 
(CASE QueQuan WHEN '' THEN N'Cõi Trên Xuống' 
  else QueQuan
END)as QueQuan 
from NHANVIEN

--Hãy liệt kê 5 nhân viên có tuổi đời cao nhất trong công ty
select top 5 * from NHANVIEN order by Tuoi desc

--Hãy liệt kê những nhân viên có tuổi đời từ 25 đến 35 tuổi
select * from NhanVien where Tuoi between 25 and 35