
CREATE DATABASE QLTHUVIEN
USE QLTHUVIEN
-----------------------------------------------------------------------------

CREATE TABLE THEDOCGIA
(
	MaThe		CHAR(5) PRIMARY KEY,
	HoTen		NVARCHAR(100) NOT NULL,
	LoaiDocGia	NVARCHAR NOT NULL,
	NgaySinh	SMALLDATETIME NOT NULL,
	DiaChi		NVARCHAR(200) NOT NULL,
	Email		NVARCHAR(20) NOT NULL,
	NgayLapThe	SMALLDATETIME NOT NULL,
	TaiKhoanNo	INT NOT NULL,
)


CREATE TABLE SACH
(
	MaSach		CHAR(5) PRIMARY KEY,
	TenSach		NVARCHAR(200) NOT NULL,
	TheLoai		NVARCHAR(50) NOT NULL,
	TacGia		NVARCHAR(50) NOT NULL,
	NhaXB		NVARCHAR(200)NOT NULL,
	NXB			NVARCHAR(20) NOT NULL,
	TriGia		INT NOT NULL,
	NgayNhap	SMALLDATETIME NOT NULL,
	TinhTrang	NVARCHAR(20) NOT NULL
)

CREATE TABLE PHIEUMUON
(
	MaPM		CHAR(5) PRIMARY KEY,
	MaThe		CHAR(5) NOT NULL,
	MaSach		CHAR(5) NOT NULL,
	NgayMuon	SMALLDATETIME NOT NULL,
	HanTra		SMALLDATETIME NOT NULL,
)

CREATE TABLE PHIEUTRA
(
	MaPT		CHAR(5) PRIMARY KEY,
	MaPM		CHAR(5) NOT NULL,	
	NgayTra		SMALLDATETIME NOT NULL,
	SoNgayMuon	INT NOT NULL,
	SoNgayTre	INT NOT NULL,
	TienPhat	INT NOT NULL,
)



CREATE TABLE PHIEUTHUTIENPHAT
(
	MaPTT		CHAR(5) PRIMARY KEY,
	MaThe		CHAR(5) NOT NULL,
	SoTienThu	MONEY NOT NULL,
	ConLai		MONEY NOT NULL,
	NgayThu		SMALLDATETIME
)


CREATE TABLE CaiDat
(
	STT	int primary key,
	DoTuoiToiThieu	int,
	DoTuoiToiDa	int,
	ThoiHanThe	int,
	KhoangCachNamXB	int,
	SachMuonToiDa	int,
	SoNgayMuonToiDa	int,
	SoTienNoToiDa	int,
	NgaySuaDoi	smalldatetime
)

CREATE TABLE DANGNHAP
(
	TenDN CHAR(200) PRIMARY KEY,
	MatKhau CHAR(200)
)


ALTER TABLE PHIEUMUON ADD CONSTRAINT FK_PHIEUMUON_THEDOCGIA FOREIGN KEY (MaThe) REFERENCES THEDOCGIA(MaThe)
ALTER TABLE PHIEUMUON ADD CONSTRAINT FK_PHIEUMUON_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
ALTER TABLE PHIEUTRA ADD CONSTRAINT FK_PHIEUTRA_PHIEUMUON FOREIGN KEY (MaPM) REFERENCES PHIEUMUON(MaPM)
ALTER TABLE PHIEUTHUTIENPHAT ADD CONSTRAINT FK_PHIEUTHUTIENPHAT_PHIEUTRA FOREIGN KEY (MaThe) REFERENCES THEDOCGIA(MaThe)

-----------------------------------------------------------------------------------------------------------------------------------------

---- 0.0 Procedure DANGNHAP

CREATE PROC DANGNHAP_Select
(
	@TenDN char(200),
	@MatKhau char(200)
)
AS
BEGIN
	select count(*) from DANGNHAP where TenDN = @TenDN and MatKhau = @MatKhau
END

-- 1.  Procedure liên quan đến THEDOCGIA

---- 1.1  Thêm đọc giả
CREATE PROC THEDOCGIA_Insert
(
	@MaThe		CHAR(5),
	@HoTen		NVARCHAR(100),
	@LoaiDocGia	NVARCHAR ,
	@NgaySinh	SMALLDATETIME,
	@DiaChi		NVARCHAR(200),
	@Email		NVARCHAR(20),
	@NgayLapThe	SMALLDATETIME,
	@TaiKhoanNo	MONEY
)
AS
BEGIN
	INSERT INTO THEDOCGIA(Mathe,HoTen,LoaiDocGia,NgaySinh,DiaChi,Email,NgayLapThe, TaiKhoanNo) VALUES(@MaThe,@HoTen,@LoaiDocGia,@NgaySinh,@DiaChi,@Email,@NgayLapThe, @TaiKhoanNo)
END


---- 1.2  Lấy tất cả thông tin từ bảng THEDOCGIA để phục vụ cho việc tạo mã thẻ
CREATE PROC THEDOCGIA_Select
AS
BEGIN
	SELECT *
	FROM THEDOCGIA
END

----1.3  Kiểm tra xem USER nhập mã thẻ có đúng không
CREATE PROC KIEMTRADOCGIA
(
	@MaThe	char(5)
)
AS
BEGIN
	SELECT HoTen
	FROM THEDOCGIA
	WHERE MaThe = @MaThe
END

---- 1.4  Lấy TAIKHOANNO của ĐỌC GIẢ
CREATE PROC LAYTIENNO
(
	@MaThe	CHAR(5)
)
AS
BEGIN
	SELECT TaiKhoanNo
	FROM THEDOCGIA
	WHERE MaThe = @MaThe
END

---- 1.5  Cập nhật lại TAIKHOANNO của ĐỌC GIẢ nếu ĐG trả sách quá hạn
CREATE PROC TAIKHOANNO_UPDATE
(
	@MaThe	char(5),
	@TaiKhoanNo	money
)
AS
BEGIN
	UPDATE THEDOCGIA SET TaiKhoanNo = @TaiKhoanNo WHERE MaThe=@MaThe
END

---- 1.6  Tìm kiếm ĐG với từ khóa @key

CREATE PROC THEDOCGIA_Timkiem
(
	@Key	nvarchar(100)
)
AS
BEGIN
	SELECT MaThe as N'Mã thẻ', HoTen as N'Họ tên', NgayLapThe as N'Ngày lập thẻ', LoaiDocGia as N'Loại đọc giả'
	FROM THEDOCGIA
	WHERE HoTen like '%' +@Key+'%' OR MaThe = @Key
END

---- 1.7  Lấy Thông tin ĐG (khi được nhập từ TextBox trong FORM) gồm: TÊN ĐG, SỐ NỢ hiện tại
------Giống như phần "1.6  Tra cứu thành viên", nhưng chỉ lấy 2 trường dữ liệu đó là: HoTen và TaiKhoanNo, không cần viết lại procedure
CREATE PROC TIMTENDOCGIA_TIENNO
(
	@MaThe	char(5)
)
AS
BEGIN
	SELECT HoTen, TaiKhoanNo
	FROM THEDOCGIA
	WHERE MaThe = @MaThe
END

---- 1.8  Tra cứu thành viên, Lấy tất cả thông tin của ĐG để hiện thị
CREATE PROC THEDOCGIA_Tracuu
(
	@MaThe	char(5)
)
AS
BEGIN
	SELECT *
	FROM THEDOCGIA
	WHERE MaThe = @MaThe
END

---- 1.9  Xóa thẻ
CREATE PROC THEDOCGIA_Delete
(
	@MaThe		CHAR(5)
)
AS
BEGIN
	Delete FROM THEDOCGIA WHERE MaThe=@MaThe
END

---- 1.10  Cập nhật thông tin

CREATE PROC THEDOCGIA_Update
(
	@MaThe		CHAR(5),
	@HoTen		NVARCHAR(100),
	@LoaiDocGia	NVARCHAR ,
	@NgaySinh	SMALLDATETIME,
	@DiaChi		NVARCHAR(200),
	@Email		NVARCHAR(20),
	@NgayLapThe	SMALLDATETIME,
	@TaikhoanNo	MONEY
)
AS
BEGIN
	UPDATE THEDOCGIA SET HoTen=@HoTen,LoaiDocGia=@LoaiDocGia,NgaySinh=@NgaySinh,DiaChi=@DiaChi,Email=@Email,NgayLapThe=@NgayLapThe, TaiKhoanNo = @TaiKhoanNo WHERE MaThe=@MaThe
END

----1.11 Thông tin đọc giả
CREATE PROC THONGTINDOCGIA
(
	@MaThe char(5)
)
AS
BEGIN
	SELECT HoTen, NgaySinh, NgayLapThe, LoaiDocGia
	FROM THEDOCGIA
	WHERE MaThe = @MaThe
END

-----------------------------------------------------------------------------XONG PHẦN THẺ ĐG-----------------------------------------------------------------------------

-- 2.0. procedure NHẬN SÁCH
---------Thêm sách vào thư viện
---------Lấy thông tin từ bảng SACH để tạo MÃ SÁCH

----2.1  Thêm sách vào thư viện

CREATE PROC SACH_Insert
(
	@MaSach		char(5),
	@TenSach	nvarchar(200),
	@TheLoai	nvarchar(50),
	@TacGia		nvarchar(50),
	@NhaXB		NVARCHAR(200),
	@NXB		NVARCHAR(20),
	@TriGia		NVARCHAR(200),
	@NgayNhap	SMALLDATETIME,
	@TinhTrang	NVARCHAR(20)
)
AS
BEGIN
	INSERT INTO SACH(MaSach,TenSach,TheLoai,TacGia,NhaXB,NXB,TriGia,NgayNhap,TinhTrang) VALUES (@MaSach,@TenSach,@TheLoai,@TacGia,@NhaXB,@NXB,@TriGia,@NgayNhap,@TinhTrang)
END

---- 2.2  Lấy tất cả thông tin từ bảng SÁCH để phục vụ cho việc tạo mã sách
CREATE PROC SACH_Select
AS
BEGIN
	SELECT *
	FROM SACH
END
-----------------------------------------------------------------------------XONG PHẦN SÁCH-----------------------------------------------------------------------------


-- 3.0. procedure liên quan Mượn sach
---------Thêm Phiếu Mượn
---------Tìm kiếm sách để mượn
---------Lấy thông tin để tạo MÃ phiếu trả
---------Trừ đi số lượng hiện có của sách được mượn
---------Kiểm tra xem USER nhập mã thẻ có đúng không
---------Số sách mà ĐG hiện đang mượn
---------kiểm tra xem sách đó ĐG đã trả hay chưa

---- 3.1  Thêm Phiếu Mượn
CREATE PROC PHIEUMUON_INSERT
(
	@MaPM	char(5),
	@MaThe	char(5),
	@MaSach	char(5),
	@NgayMuon	smalldatetime,
	@HanTra	smalldatetime
)
AS
BEGIN
	INSERT INTO PHIEUMUON(MaPM, MaThe, MaSach, NgayMuon, HanTra) VALUES (@MaPM, @MaThe, @MaSach, @NgayMuon, @HanTra)
END

---- 3.2  Tìm kiếm sách để mượn
CREATE PROC TimKiemSach
(
	@Key	nvarchar(100)
)
AS
BEGIN
	SELECT MaSach, TenSach, TacGia, TheLoai, TinhTrang
	FROM SACH
	WHERE TenSach like '%' +@Key+'%' OR TacGia LIKE '%' +@Key+'%' OR TheLoai LIKE '%' +@Key+'%'
END

---- 3.3  Lấy thông tin để tạo MÃ phiếu trả
CREATE PROC PHIEUMUON_SELECT
AS
BEGIN
	SELECT *
	FROM PHIEUMUON
END

----3.4  Trừ đi số lượng hiện có của sách được mượn
CREATE PROC GIAMSOLUONGSACH
(
	@MaSach char(5)
)
AS
BEGIN
	UPDATE SACH SET TinhTrang = (TinhTrang - 1)
	WHERE MaSach=@MaSach	
END

---- 3.7  Số sách mà ĐG hiện đang mượn GỒM 2 PROC: DANHSACHPHIEUMUON   +    KIEMTRAPHIEUMUON
--------DANHSACHPHIEUMUON  trả về danh sách tất cả các SÁCH mà ĐG đã từng mượn
CREATE PROC DANHSACHPHIEUMUON
(
	@MaThe	char(5)
)
AS
BEGIN
	SELECT MaPM
	FROM PHIEUMUON
	WHERE MaThe = @MaThe
END
---- 3.8 KIEMTRAPHIEUMUON  dựa vào DANH SÁCH từ DANHSACHPHIEUMUON  để kiểm tra xem SÁCH trong   DANH SÁCH   đó đã trả hay chưa, nếu chưa trả thì sô lượng SÁCH đang mượn được tăng lên 1
CREATE PROC KIEMTRAPHIEUMUON
(
	@MaPM	char(5)
)
AS
BEGIN
	SELECT *
	FROM PHIEUTRA
	WHERE MaPM = @MaPM
END

----3.9 KIỆT KÊ MaThe từ bảng PHIEUMUON
CREATE PROC PHIEUMUON_SELECTMATHE
AS
BEGIN
	SELECT MaThe
	FROM PHIEUMUON
	GROUP BY MaThe
END


--------KIEMTRAPHIEUMUON dựa vào DANH SÁCH từ DANHSACHPHIEUMUON  để kiểm tra xem SÁCH trong   DANH SÁCH   đó đã trả hay chưa, nếu chưa trả thì trả về giá trị ChuaTra = true
CREATE PROC SACHDAMUON
(
	@MaThe	char(5),
	@MaSach	char(5)
)
AS
BEGIN
	SELECT MaPM
	FROM PHIEUMUON
	WHERE MaThe = @MaThe and MaSach = @MaSach
END


---------------------------------------------------------------------------------------------------------------------------------------------------

-- 4.0. procedure liên quan Trả Sach
---------Thêm Phiếu Trả
---------Kiểm tra thông tin những SÁCH mà Đọc giả đã mượn
---------Lấy thông tin để tạo MÃ phiếu trả
---------Lấy TAIKHOANNO của ĐỌC GIẢ:  để hiện thị trong tin ra FORM, và dùng để tính toán số tiền nợ nếu đọc giả trả sách quá hạn
---------Cập nhật lại TAIKHOANNO của ĐỌC GIẢ nếu ĐG trả sách quá hạn
---------Cập nhật tình trạng sách: Tình trạng sách được trả tăng lên 1

---- 4.1 Thêm Phiếu Trả
CREATE PROC TraSach_insert
(
	@MaPT char(5),
	@MaPM char(5),
	@SoNgayMuon int,
	@SoNgayTre	int,
	@TienPhat money,
	@NgayTra smalldatetime
)
AS
BEGIN
	INSERT INTO PHIEUTRA(MaPT, MaPM, SoNgayMuon, SoNgayTre, TienPhat, NgayTra) VALUES (@MaPT, @MaPM, @SoNgayMuon, @SoNgayTre, @TienPhat, @NgayTra)
END

---- 4.2  Kiểm tra thông tin những SÁCH mà Đọc giả đã mượn
CREATE PROC ThongTinSachDaMuon
(
	@MaThe		CHAR(5)
)
AS
BEGIN
	SELECT PHIEUMUON.MaPM, SACH.MaSach , SACH.TenSach, PHIEUMUON.NgayMuon,PHIEUMUON.HanTra 
	FROM PHIEUMUON, SACH
	WHERE SACH.MaSach = PHIEUMUON.MaSach AND PHIEUMUON.MaThe = @MaThe AND PHIEUMUON.MaPM NOT IN (
					SELECT PHIEUMUON.MaPM
					FROM PHIEUTRA
					WHERE PHIEUTRA.MaPM = PHIEUMUON.MaPM
					)
END

---- 4.3  Lấy thông tin để tạo MÃ phiếu trả

CREATE PROC PHIEUTRA_SELECT
AS
BEGIN
	SELECT PHIEUTRA.MaPT FROM PHIEUTRA
END

---- 4.5  Cập nhật tình trạng sách: Tình trạng sách được trả tăng lên 1
CREATE PROC TANGSOLUONGSACH
(
	@MaSach char(5)
)
AS
BEGIN
	UPDATE SACH SET TinhTrang = (TinhTrang + 1)
	WHERE MaSach=@MaSach	
END

-- 7.0. procedure liên quan THU TIỀN PHẠT
---------Thêm vào PHIEUTHUTIENPHAT
---------Lấy thông tin từ bảng PHIEUTHUTIENPHAT để tạo MÃ PHIẾU THU TIỀN PHẠT
---------Lấy Thông tin ĐG (khi được nhập từ TextBox trong FORM) gồm: TÊN ĐG, SỐ NỢ hiện tại

---- 7.1  Thêm vào PHIEUTHUTIENPHAT
CREATE PROC PHIEUTHUTIENPHAT_insert
(
	@MaPTT char(5),
	@MaThe	char(5),
	@SoTienThu money,
	@ConLai money,
	@NgayThu	smalldatetime
)
AS
BEGIN
	INSERT INTO PHIEUTHUTIENPHAT(MaPTT, MaThe, SoTienThu, ConLai, NgayThu) VALUES (@MaPTT, @MaThe, @SoTienThu, @ConLai, @NgayThu)
END

---- 7.2  Lấy thông tin từ bảng PHIEUTHUTIENPHAT để tạo MÃ PHIẾU THU TIỀN PHẠT
CREATE PROC PHIEUTHUTIENPHAT_select
AS
BEGIN
	SELECT *
	FROM PHIEUTHUTIENPHAT
END

---------------------------------------------------------------------------------------------------------------------------------------------------

-- 8.0  procedure phần TÌM SÁCH
-------Tìm sách với từ khóa @Key
-------Cập nhật thông tin của sách được chọn
-------Lấy thông tin sách với MaSach  để hiển thị toàn bộ thôn tin về SÁch được chọn
-------Xóa sách dược chọn


---- 8.1  Tìm sách với 1 từ khóa key : Lấy thôn tin: Tên sách, Mã sách, Tên tác giả

CREATE PROC TIMSACH
(
	@Key	nvarchar(100)
)
AS
BEGIN
	SELECT MaSach as N'Mã sách', TenSach as N'Tên sách', TacGia as N'Tác giả', TheLoai as N'Thể loại'
	FROM SACH
	WHERE TenSach like '%' +@Key+'%' OR TacGia LIKE '%' +@Key+'%' OR TheLoai LIKE '%' +@Key+'%'
END

---- 8.2  Cập nhật thông tin sách
CREATE PROC CAPNHATSACH
(
	@MaSach			CHAR(5),
	@TenSach		NVARCHAR(200),
	@TheLoai		NVARCHAR(50),
	@TacGia			NVARCHAR(50),
	@NhaXB			NVARCHAR(200),
	@NXB			NVARCHAR(20),
	@TriGia			INT,
	@NgayNhap		SMALLDATETIME,
	@SoLuong		NVARCHAR(20)
)
AS
BEGIN
	UPDATE SACH SET TenSach = @TenSach, TheLoai = @TheLoai, TacGia = @TacGia, NhaXB = @NhaXB, NXB = @NXB, TriGia = @TriGia, NgayNhap = @NgayNhap, TinhTrang = @SoLuong
	WHERE MaSach = @MaSach
END


---- 8.3  Lấy thông tin sách với MaSach, Lấy tất cả thông tin để hiện thi
CREATE PROC TRACUUSACH
(
	@MaSach	char(5)
)
AS
BEGIN
	SELECT *
	FROM SACH
	WHERE MaSach = @MaSach
END

---- 8.4 xóa sách
CREATE PROC XOASACH
(
	@MaSach	CHAR(5)
)
AS
BEGIN
	Delete FROM SACH WHERE MaSach=@MaSach
END



---------------------------------------------------------------------------------------------------------------------------------------------------

-- 10.0  procedure phần CÀI ĐẶT
-------Thêm 1 cài đặt
-------Cập nhật thông tin của ĐG được chọn
-------Lấy thông tin từ bảng CAIDAT  để lấy giá trị mặc định ban đầu ( là hàng đầu tiên trong bảng)

----- 10.1  Thêm 1 cài đặt
CREATE PROC CAIDAT_INSERT
(
	@STT	int,
	@DoTuoiToiThieu	int,
	@DoTuoiToiDa	int,
	@ThoiHanThe	int,
	@KhoangCachNamXB	int,
	@SachMuonToiDa	int,
	@SoNgayMuonToiDa	int,
	@SoTienNoToiDa	int,
	@NgaySuaDoi	smalldatetime
)
AS
BEGIN
	INSERT INTO CaiDat(STT, DoTuoiToiThieu, DoTuoiToiDa, ThoiHanThe, KhoangCachNamXB, SachMuonToiDa,SoNgayMuonToiDa, SoTienNoToiDa, NgaySuaDoi) VALUES (@STT, @DoTuoiToiThieu, @DoTuoiToiDa, @ThoiHanThe,@KhoangCachNamXB,@SachMuonToiDa,@SoNgayMuonToiDa, @SoTienNoToiDa,@NgaySuaDoi)
END


----- 10.2  Lấy thông tin từ bảng CAIDAT
CREATE PROC CAIDAT_SELECT
AS
BEGIN
	SELECT *
	FROM CaiDat
END


---------------------------------------------------------------------------------------------------------------------------------------------------

---- Wiew Báo Cáo
CREATE VIEW VW_BAOCAOMUONSACH
AS
	SELECT  s.TheLoai as 'TheLoai', MONTH(pm.NgayMuon) AS 'Thang', YEAR(pm.NgayMuon) AS 'Nam', COUNT(pm.MaPM) AS 'SoLuotMuon',(COUNT(pm.MaPM)*100)/(SELECT COUNT(*) FROM PHIEUMUON) AS 'TILE'
	FROM PHIEUMUON pm, SACH s
	WHERE pm.MaSach = s.MaSach
	GROUP BY s.TheLoai, MONTH(pm.NgayMuon), YEAR(pm.NgayMuon)

--- bao cao trả sách trễ  (xong)
CREATE VIEW VW_BAOCAOTRASACHTRE
AS
	SELECT S.TenSach, M.NgayMuon, T.SoNgayTre
	FROM PHIEUTRA T, SACH S, PHIEUMUON M
	WHERE M.MaSach = S.MaSach and M.MaPM = T.MaPM and T.SoNgayTre > 0

CREATE VIEW VW_PHIEUTHUTIENPHAT
AS
	SELECT PTT.MaPTT, T.MaThe, T.HoTen, T.TaiKhoanNo, PTT.NgayThu, PTT.SoTienThu, PTT.ConLai, T.NgaySinh, T.DiaChi
	FROM THEDOCGIA T, PHIEUTHUTIENPHAT PTT
	WHERE T.MaThe = PTT.MaThe

-- Insert dữ liệu tài khoản đăng nhập vào phần mềm
INSERT INTO DANGNHAP (TenDN, MatKhau) VALUES('admin', 'admin')

-- Insert dữ liệu bảng THEDOCGIA
INSERT INTO THEDOCGIA VALUES('A0001',N'Nguyễn Văn A','X','01/07/1997',N'30 Phú Sỹ','ABC@gmail.com','01/05/2016','0')
INSERT INTO THEDOCGIA VALUES('A0002',N'Nguyễn Văn B','Y','05/10/1995',N'30 Dĩ An','AnhBe@gmail.com','06/04/2016','0')
INSERT INTO THEDOCGIA VALUES('A0003',N'Trần Quốc Chính','X','01/07/1995',N'30 đường Vành Đai','QuocChinh@gmail.com','06/20/2016','0')

-- Insert dữ liệu bảng SACH
INSERT INTO SACH VALUES('S0001',N'Toán Cao Cấp','A',N'Nguyễn Nhựt ABC',N'Toán Học Trẻ','2010','39000','06/20/1996','10')
INSERT INTO SACH VALUES('S0002',N'Anh Văn Giao Tiếp','C',N'Nguyễn Đình Trí',N'Văn Hóa','2011','56000','06/15/1996','10')
INSERT INTO SACH VALUES('S0003',N'Hệ Điều Hành','C',N'Lê Khắc Nhiên Ân',N'ĐH Khoa học Tự nhiên','2011','96000','06/15/1996','10')

-- Insert dữ liệu bảng CaiDat
INSERT INTO CaiDat VALUES('1', '18', '55', '6', '8', '5', '4', '50000', DAY(GETDATE()))
