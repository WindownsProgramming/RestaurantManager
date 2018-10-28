CREATE DATABASE QLNhaHang
GO
USE QLNhaHang
GO

-----------------------------
--QUẢN LÝ NHÂN VIÊN---------- 
-----------------------------
--Table Loại Nhân Viên
CREATE TABLE LoaiNV
(
	IDLoaiNV INT IDENTITY PRIMARY KEY,
	TenLoaiNV NVARCHAR(30)
)
go
ALTER TABLE dbo.LoaiNV
ADD HeSo INT 
GO
-- Table Ca làm
CREATE TABLE CaLam
(
	IDCa INT IDENTITY PRIMARY KEY,
	TenCa NVARCHAR(20),
	GioBDCa TIME,
	GioHetCa TIME
)
GO
ALTER TABLE dbo.CaLam
ADD TienCong INT
GO
--Table Bảng Lương
CREATE TABLE BangLuong
(
	IDLuong INT IDENTITY PRIMARY KEY,
	IDLoaiNV INT,
	IDCa INT,
	Tien FLOAT,
	FOREIGN KEY(IDCa) REFERENCES dbo.CaLam(IDCa),
	FOREIGN KEY(IDLoaiNV) REFERENCES dbo.LoaiNV(IDLoaiNV)
)
GO

GO
--Bảng Nhân viên
CREATE TABLE NhanVien
(
	IDNhanVien INT IDENTITY PRIMARY KEY,
	IDLoaiNV INT,
	TenNV NVARCHAR(30),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(12),
	MK NVARCHAR(50),
	FOREIGN KEY(IDLoaiNV) REFERENCES dbo.LoaiNV(IDLoaiNV)
)
go
ALTER TABLE dbo.NhanVien
ADD GhiChu NVARCHAR(50)
GO

GO
CREATE TABLE Account
(
	TenTaiKhoan VARCHAR(30),
	MatKhau VARCHAR(30),
	IDNhanVien INT,
	PRIMARY KEY(TenTaiKhoan,MatKhau),
	FOREIGN KEY(IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien)
)
GO

--Table Bảng Chấm công
CREATE TABLE ChamCong
(
	IDChamCong INT IDENTITY PRIMARY KEY,
	IDNhanVien INT,
	IDCa INT,
	GhiChu NVARCHAR(50),
	NgayLam DATE,
	FOREIGN KEY(IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	FOREIGN KEY(IDCa) REFERENCES dbo.CaLam(IDCa)	
)

GO
----------------------------------
------Nhập Nguyên Liệu----------------------------
------------------------------------
--Bảng Loại Nguyên Liệu

GO
CREATE TABLE LoaiNguyenLieu
(
	IDLoaiNL INT IDENTITY PRIMARY KEY,
	TenLoaiNL NVARCHAR(30),
)
GO
-- BẢNG Nguyên liệu

GO
CREATE TABLE NguyenLieu
(
	IDNguyenLieu INT IDENTITY PRIMARY KEY,
	IDLoaiNL INT,
	TenNguyenLieu NVARCHAR(30),
	DVT NVARCHAR(20),
	SoLuongTon INT
	FOREIGN KEY(IDLoaiNL) REFERENCES dbo.LoaiNguyenLieu(IDLoaiNL)

)
GO
ALTER TABLE dbo.NguyenLieu
ADD DEFAULT 0 FOR SoLuongTon
--Bảng Nhập Kho
GO

CREATE TABLE NhapKho
(
	IDNhap INT IDENTITY PRIMARY KEY,
	IDNhanVien INT,
	NgayNhap DATE,
	TongTien FLOAT
	FOREIGN KEY(IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien)
)
GO
ALTER TABLE dbo.NhapKho
ADD DEFAULT 0 FOR TongTien
GO

--Bảng chi tiết nhập kho
GO

CREATE TABLE CTNhapKho
(
	IDCTNhap INT IDENTITY PRIMARY KEY,
	IDNhap INT,
	IDNguyenLieu INT,
	SoLuongNhap INT,
	GiaNhap FLOAT,
	FOREIGN KEY(IDNhap) REFERENCES dbo.NhapKho(IDNhap),
	FOREIGN KEY(IDNguyenLieu) REFERENCES dbo.NguyenLieu(IDNguyenLieu)
)

-----------------------------------------------------------------------------------------------------
---Quản lý món ăn-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
--Bảng Loại Món ăn
GO

CREATE TABLE LoaiMonAn
(
	IDLoaiMon INT IDENTITY PRIMARY KEY,
	TenLoaiMon NVARCHAR(30)
)
--Bảng Món ăn
GO

CREATE TABLE MonAn
(
	IDMonAn INT IDENTITY PRIMARY KEY,
	TenMonAn NVARCHAR(50),
	IDLoaiMon INT,
	GiaMonAn FLOAT,
	TrangThai INT DEFAULT 1,--1 CÒN , 0 hết
	FOREIGN KEY(IDLoaiMon) REFERENCES dbo.LoaiMonAn(IDLoaiMon)
)

--Bảng Thành phần món ăn
GO

CREATE TABLE ThanhPhanMonAn
(
	IDMonAn INT,
	IDNguyenLieu INT,
	SoLuongNL FLOAT,
	PRIMARY KEY(IDMonAn,IDNguyenLieu),
	FOREIGN KEY(IDMonAn) REFERENCES dbo.MonAn(IDMonAn),
	FOREIGN KEY(IDNguyenLieu) REFERENCES dbo.NguyenLieu(IDNguyenLieu)
)
-----------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------
--Nghiệp vụ thanh toán khi KHÔNG ĐẶT BÀN TRƯỚC---------
-----------------------------------------------------------------------------------------------------
--Bảng Bàn ăn
GO

CREATE TABLE BanAn
(
	IDBanAn INT IDENTITY PRIMARY KEY,
	TenBanAn NVARCHAR(30),
	TinhTrangBan INT DEFAULT 0 -- 0 : chưa có chỗ, 1 có chỗ rồi, 2 -- đã được đặt trc
)
--Bảng Bill
GO

CREATE TABLE Bill
(
	IDBill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE,
	DateCheckOut DATE,
	IDBanAn INT,
	TrangThai INT DEFAULT 0, ----0 : chưa thanh toán, 1- đã thanh toán
	IDNhanVien INT,
	TongTien INT DEFAULT 0,
	FOREIGN KEY(IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	FOREIGN KEY(IDBanAn) REFERENCES dbo.BanAn(IDBanAn)
)
--Bảng BillInfo
GO

CREATE TABLE BillInfo
(
	IDBillInfo INT IDENTITY PRIMARY KEY,
	IDBill INT,
	IDMonAn INT,
	SoLuong INT,
	FOREIGN KEY(IDBill) REFERENCES dbo.Bill(IDBill),
	FOREIGN KEY(IDMonAn) REFERENCES dbo.MonAn(IDMonAn)
)
-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
-- Quản lý đặt bàn
-----------------------------------------------------------------------------------------------------
--Bảng Loai Khách hàng
GO

CREATE TABLE KhachHang
(
	IDKhachHang INT IDENTITY PRIMARY KEY,
	CMND INT,
	TenKhachHang NVARCHAR(30),
	SDTKhachHang NCHAR(12),
	SoTienTichLuy FLOAT DEFAULT 0
)

--Bảng đặt bàn
GO

CREATE TABLE DatBan
(
	IDDatBan INT IDENTITY PRIMARY KEY,
	NgayDat DATE,
	IDNhanVien INT,
	IDKhachHang INT,
	IDBanAn INT,
	TrangThai INT DEFAULT 0,-- 0: Chưa đến, 1--đã đến, 2-- bị hủy
	FOREIGN KEY(IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	FOREIGN KEY(IDKhachHang) REFERENCES dbo.KhachHang(IDKhachHang),
	FOREIGN KEY(IDBanAn) REFERENCES dbo.BanAn(IDBanAn)
)


--Bang Hóa đơn cho đặt bàn trước
GO

CREATE TABLE HoaDon
(
	IDHoaDon INT IDENTITY PRIMARY KEY,
	IDDatBan INT,
	IDKhachHang INT,
	TrangThai INT DEFAULT 0, -- 1 Đã thành toán, 0 Chưa thanh Toán
	GhiChu NVARCHAR(100),
	GiamGia FLOAT DEFAULT 0,
	TongTien FLOAT DEFAULT 0,
	FOREIGN KEY(IDDatBan) REFERENCES dbo.DatBan(IDDatBan),
	FOREIGN KEY(IDKhachHang) REFERENCES dbo.KhachHang(IDKhachHang)
)
--Bảng chi tiết hóa đơn đặt bàn
GO

CREATE TABLE CTHoaDon
(
	IDCTHoaDon INT IDENTITY PRIMARY KEY,
	IDHoaDon INT,
	IDMonAn INT,
	SoLuong INT DEFAULT 0,
	FOREIGN KEY(IDHoaDon) REFERENCES dbo.HoaDon(IDHoaDon),
	FOREIGN KEY(IDMonAn) REFERENCES dbo.MonAn(IDMonAn)
)
GO
ALTER TABLE dbo.MonAn
ALTER COLUMN GiaMonAn INT
GO
ALTER TABLE dbo.Bill
ALTER COLUMN TongTien INT
GO
ALTER TABLE dbo.Bill
ADD GiamGia INT
GO
ALTER TABLE dbo.Bill
ADD CONSTRAINT df_GiamGia
DEFAULT 0 FOR GiamGia
GO
ALTER TABLE dbo.ChamCong
ADD CONSTRAINT df_NgayCCong
DEFAULT GETDATE() FOR NgayLam
GO
ALTER TABLE dbo.NhanVien
ADD CONSTRAINT df_mk
DEFAULT 0 FOR MK
GO
ALTER TABLE dbo.NhapKho
ALTER COLUMN TongTien INT
GO

-----------------------------------------------------------------------------------------------------
-------Store Proc-----------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
--THÊM BILL
--
CREATE PROC insertBill @idTable INT, @idNhanVien INT
AS
BEGIN
	INSERT INTO dbo.Bill
	        ( DateCheckIn ,
	          DateCheckOut ,
	          IDBanAn ,
	          TrangThai ,
	          IDNhanVien ,
	          TongTien,
			  GiamGia
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          GETDATE() , -- DateCheckOut - date
	          @idTable , -- IDBanAn - int
	          0 , -- TrangThai - int
	          @idNhanVien , -- IDNhanVien - int
	          0,  -- TongTien - int
			  0
			)
	UPDATE dbo.BanAn SET TinhTrangBan=1 WHERE IDBanAn=@idTable
END
GO
--EXEC insertBill 2,1
----------------------------------------
--------THÊM BILL INFO -----------------
CREATE PROC insertInfoBill @idBill INT, @idFood INT, @countAdd INT
AS
	DECLARE @isFood INT
	DECLARE @countPresent INT =1
	--kiểm tra thức ăn có tồn tại trong cái bill chưa
	SELECT @isFood = IDBillInfo, @countPresent = dbo.BillInfo.SoLuong FROM dbo.BillInfo WHERE idBill = @idBill AND IDMonAn = @idFood
	IF(@isFood >0)--tồn tại cái thức ăn trong cái @idBill --> Update số lượng lại
		BEGIN
			DECLARE @temp INT = @countPresent + @countAdd 
			IF ( @temp >0)--nếu số lượng sau khi update > 0
			BEGIN
				UPDATE dbo.BillInfo SET dbo.BillInfo.SoLuong = @countPresent + @countAdd WHERE IDBill = @idBill AND IDMonAn = @idFood
				
				
				--duyệt tất cả nguyên liệu trong idFood
					DECLARE NguyenLieuCursor CURSOR
					FOR SELECT IDNguyenLieu,SoLuongNL FROM dbo.ThanhPhanMonAn WHERE IDMonAn = @idFood -- CÓ ĐƯỢC danh sách Id Nguyên liệu và số lượngNL--id = 1,2
					OPEN NguyenLieuCursor--MỞ cursor
		
					DECLARE @idNguyenLieu INT -- Id Nguyên liệu của từng dòng
					DECLARE @soLuongNL INT -- số lượng nguyên liệu từng dòng

					FETCH NEXT FROM NguyenLieuCursor INTO @idNguyenLieu,@soLuongNL
					WHILE @@FETCH_STATUS =0
						BEGIN
							UPDATE dbo.NguyenLieu SET SoLuongTon = SoLuongTon-@countAdd*@soLuongNL WHERE IDNguyenLieu=@idNguyenLieu                       
							FETCH NEXT FROM NguyenLieuCursor INTO @idNguyenLieu,@soLuongNL
						END
									
					CLOSE NguyenLieuCursor -- đóng cursor
					DEALLOCATE NguyenLieuCursor


			END
			ELSE --số lượng sau khi update < 0 --> xóa cái Food trong Bill ra
				BEGIN
					DELETE dbo.BillInfo WHERE idBill = @idBill AND IDMonAn = @idFood		
				END
		
		END
	ELSE--không tồn tại thì thêm vào @idBill
		BEGIN
			IF(@countAdd > 0)
			BEGIN
				INSERT INTO dbo.BillInfo
				( IDBill, IDMonAn, SoLuong )
				VALUES  ( @idBill, -- idBill - int
				  @idFood, -- idFood - int
				  @countAdd  -- count - int
				  )
					--duyệt tất cả nguyên liệu trong idFood
					DECLARE NguyenLieuCursor CURSOR
					FOR SELECT IDNguyenLieu,SoLuongNL FROM dbo.ThanhPhanMonAn WHERE IDMonAn = @idFood -- CÓ ĐƯỢC danh sách Id Nguyên liệu và số lượngNL--id = 1,2
					OPEN NguyenLieuCursor--MỞ cursor
		
					DECLARE @MaNguyenLieu INT -- Id Nguyên liệu của từng dòng
					DECLARE @sLuongNL INT -- số lượng nguyên liệu từng dòng

					FETCH NEXT FROM NguyenLieuCursor INTO @MaNguyenLieu,@sLuongNL
					WHILE @@FETCH_STATUS =0
						BEGIN
							UPDATE dbo.NguyenLieu SET SoLuongTon = SoLuongTon-@countAdd*@sLuongNL WHERE IDNguyenLieu=@MaNguyenLieu                       
							FETCH NEXT FROM NguyenLieuCursor INTO @MaNguyenLieu,@sLuongNL
						END
									
					CLOSE NguyenLieuCursor -- đóng cursor
					DEALLOCATE NguyenLieuCursor

			END
			ELSE
				PRINT 'Không thêm được'
		END
GO
------------------------------------------------------------------
------------------------------------------------------------------
--CHUYỂN BÀN Ăn

CREATE PROC gopBanAn
@idTable1 INT, @idTable2 INT, @IDNhanVien INT
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	--lấy ra cái bill chưa đc Thanh toán:0 trong cả 2 bàn 
	SELECT @idFirstBill = IDBill FROM dbo.Bill WHERE IDBanAn = @idTable1 AND TrangThai = 0
	SELECT @idSeconrdBill = IDBill FROM dbo.Bill WHERE IDBanAn = @idTable2 AND TrangThai = 0 
	
	       
	--nếu Không có bill nào trong bàn 1 ==> thêm 1 cái bill vào ==> lấy ra cái idBill vừa thêm
	IF (@idFirstBill IS NULL)
	BEGIN

		INSERT dbo.Bill
		        ( DateCheckIn ,
				  DateCheckOut ,
				  IDBanAn ,
				  TrangThai ,
				  IDNhanVien ,
				  TongTien
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
	          GETDATE() , -- DateCheckOut - date
	          @idTable1 , -- IDBanAn - int
	          0 , -- TrangThai - int
	          @IDNhanVien , -- IDNhanVien - int
	          0  -- TongTien - int
		        )
		        
		SELECT @idFirstBill = MAX(IDBill) FROM dbo.Bill WHERE IDBanAn = @idTable1 AND TrangThai = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE IDBill = @idFirstBill
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		
		INSERT dbo.Bill
		        ( DateCheckIn ,
				  DateCheckOut ,
				  IDBanAn ,
				  TrangThai ,
				  IDNhanVien ,
				  TongTien
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
	          GETDATE() , -- DateCheckOut - date
	          @idTable2 , -- IDBanAn - int
	          0 , -- TrangThai - int
	          @IDNhanVien , -- IDNhanVien - int
	          0  -- TongTien - int
		        )
		SELECT @idSeconrdBill = MAX(IDBill) FROM dbo.Bill WHERE IDBanAn = @idTable2 AND TrangThai = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill

	SELECT IDBillInfo INTO IDBillInfoTable FROM dbo.BillInfo WHERE IDBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET IDBill = @idSeconrdBill WHERE IDBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET IDBill = @idFirstBill WHERE IDBillInfo IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.BanAn SET TinhTrangBan = 0 WHERE IDBanAn = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.BanAn SET TinhTrangBan = 0 WHERE IDBanAn = @idTable1
END
GO
-----------------------------------------
-----------------------------------------
------------Thêm bàn ăn-------------------
CREATE PROC ThemBanAn @sl INT
AS
BEGIN
	DECLARE @soluongBan INT = @sl;
	WHILE(@soluongBan>0)
	BEGIN
		INSERT INTO dbo.BanAn
		        ( TenBanAn, TinhTrangBan )
		VALUES  ( N'Bàn ăn', -- TenBanAn - nvarchar(30)
		          0  -- TinhTrangBan - int
		          );
		
		PRINT 'Them thành công';
		SET @soluongBan=@soluongBan-1;
	END

END
--EXEC ThemBanAn 1

--SELECT * FROM dbo.BanAn	
GO
--

CREATE PROC insertCTNhapKho @idPN INT, @idNguyenLieu INT, @countAdd INT, @gia INT
AS
	DECLARE @isNL INT
	DECLARE @countPresent INT =1
	
	SELECT @isNL = IDCTNhap, @countPresent = dbo.CTNhapKho.SoLuongNhap FROM dbo.CTNhapKho WHERE IDNhap = @idPN AND IDNguyenLieu=@idNguyenLieu
	IF(@isNL >0)
		BEGIN
			DECLARE @temp INT = @countPresent + @countAdd 
			IF ( @temp >0)
				UPDATE dbo.CTNhapKho SET dbo.CTNhapKho.SoLuongNhap = @countPresent + @countAdd WHERE IDNhap = @idPN AND IDNguyenLieu = @idNguyenLieu
			ELSE 
				DELETE dbo.CTNhapKho WHERE IDNhap = @idPN AND IDNguyenLieu = @idNguyenLieu
		
		END
	ELSE--không tồn tại thì thêm vào @idBill
		BEGIN
			IF(@countAdd > 0)
				INSERT INTO dbo.CTNhapKho
				        ( IDNhap ,
				          IDNguyenLieu ,
				          SoLuongNhap ,
				          GiaNhap
				        )
				VALUES  ( @idPN , -- IDNhap - int
				          @idNguyenLieu , -- IDNguyenLieu - int
				          @countAdd , -- SoLuongNhap - int
				          @Gia  -- GiaNhap - float
				        )
			ELSE
				PRINT 'Không thêm được'
		END
GO
-----------------------------------------
-----------------------------------------
CREATE PROC thongkeBill
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT DateCheckOut AS [Ngày], b.TongTien AS [Tổng tiền], b.GiamGia AS [Giảm giá], t.IDBanAn AS [ID Bàn]
	FROM dbo.Bill AS b,dbo.BanAn AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.TrangThai = 1 AND  t.IDBanAn = b.IDBanAn
	
END
--EXEC dbo.thongkeBill @checkIn = '2018-10-27 18:54:24', @checkOut = '2018-10-27 18:54:24' 
GO
---------------Thống kê nhập kho--------------
CREATE PROC thongkeNhap @batdau DATE, @ketthuc DATE
AS
BEGIN
	SELECT NgayNhap, TenNguyenLieu, SoLuongNhap,GiaNhap,NhapKho.IDNhap 
	FROM dbo.CTNhapKho, dbo.NhapKho, dbo.NguyenLieu
	WHERE dbo.NhapKho.IDNhap = dbo.CTNhapKho.IDNhap AND dbo.NguyenLieu.IDLoaiNL = dbo.CTNhapKho.IDNguyenLieu AND NgayNhap >= @batdau AND NgayNhap <= @ketthuc
	
END


GO
-----------------------------------------------------------------------------------------------------
--------------------------------------TRIGGER--------------------------------------------
-----------------------------------------------------------------------------------------------------

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	--lấy ra idbill vưa thêm
	SELECT @idBill = Inserted.IDBill FROM Inserted
	
	DECLARE @idTable INT
	-- lấy ra bàn ăn
	SELECT @idTable = IDBanAn FROM dbo.Bill WHERE IDBill = @idBill AND TrangThai = 0	
	-- số lượng billinfo trong bill vừa thêm
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE IDBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		UPDATE dbo.BanAn SET TinhTrangBan = 1 WHERE IDBanAn = @idTable		
		
	END		
	ELSE
	BEGIN
		UPDATE dbo.BanAn SET TinhTrangBan = 0 WHERE IDBanAn = @idTable	
	end



END
GO
-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = Inserted.IDBill FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = IDBanAn FROM dbo.Bill WHERE IDBill = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE IDBanAn = @idTable AND TrangThai = 0
	
	IF (@count = 0)
		UPDATE dbo.BanAn SET TinhTrangBan = 0 WHERE IDBanAn = @idTable
END
GO

-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
CREATE TRIGGER updateSoTon
ON dbo.CTNhapKho FOR INSERT
AS
BEGIN
	DECLARE @idNguyenLieu INT
	DECLARE @slthem INT
	SELECT @idNguyenLieu = Inserted.IDNguyenLieu, @slthem = Inserted.SoLuongNhap FROM Inserted
	IF(EXISTS ( SELECT* FROM dbo.NguyenLieu WHERE IDNguyenLieu=@idNguyenLieu))
	UPDATE dbo.NguyenLieu SET SoLuongTon = SoLuongTon + @slthem WHERE IDNguyenLieu=@idNguyenLieu	
	
END
GO
-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
--update Tổng tiền trong PN
GO
CREATE TRIGGER updateTongTien
ON dbo.CTNhapKho FOR INSERT
AS
BEGIN
	DECLARE @idphieuNhap INT
	DECLARE @slNhap INT
	DECLARE @giaNhap INT
	SELECT @idphieuNhap =Inserted.IDNhap, @slNhap=Inserted.SoLuongNhap, @giaNhap = Inserted.GiaNhap FROM Inserted
	UPDATE dbo.NhapKho SET TongTien = TongTien + @slNhap*@giaNhap WHERE IDNhap = @idphieuNhap

END


GO

-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------
CREATE TRIGGER checkNguyenLieu
ON BillInfo FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @abe INT = 0	
	DECLARE @soLuongMon INT -- số lượng món ăn trong BillInfo 	
	DECLARE @idMonAn INT -- Id món ăn trong billInfo thêm vô 
	
	SELECT @idMonAn = Inserted.IDMonAn FROM Inserted	 -- gán giá trị 6
	SELECT @soLuongMon = Inserted.SoLuong FROM Inserted-- 3

	BEGIN		
		DECLARE NguyenLieuCursor CURSOR
		FOR SELECT IDNguyenLieu,SoLuongNL FROM dbo.ThanhPhanMonAn WHERE IDMonAn = @idMonAn -- CÓ ĐƯỢC danh sách Id Nguyên liệu và số lượngNL--id = 1,2
		OPEN NguyenLieuCursor--MỞ cursor
		
		DECLARE @idNguyenLieu INT -- Id Nguyên liệu của từng dòng
		DECLARE @soLuongNL INT -- số lượng nguyên liệu từng dòng

		FETCH NEXT FROM NguyenLieuCursor INTO @idNguyenLieu,@soLuongNL
		WHILE @@FETCH_STATUS =0
			BEGIN
				DECLARE @temp INT
				SELECT @temp=dbo.NguyenLieu.SoLuongTon FROM dbo.NguyenLieu WHERE IDNguyenLieu = @idNguyenLieu 
				IF(@temp < @soLuongMon*@soLuongNL)
					BEGIN
						SET @abe = @abe+1
					END
				FETCH NEXT FROM NguyenLieuCursor INTO @idNguyenLieu,@soLuongNL
			END
									
		CLOSE NguyenLieuCursor -- đóng cursor
		DEALLOCATE NguyenLieuCursor
	END
	IF(@abe>0)
		ROLLBACK


END
GO


GO
-----------------------------------------------------------------------------------------------------
--------------------------------------FUNTION--------------------------------------------
-----------------------------------------------------------------------------------------------------
go
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput IF @strInput = '' 
	RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int DECLARE @COUNTER1 int 
SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
			BEGIN 
				IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
					BEGIN 
						IF @COUNTER=1 
							SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
						ELSE 
							SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
						BREAK 
					END 
					SET @COUNTER1 = @COUNTER1 +1 
			END 
		SET @COUNTER = @COUNTER +1 
	END SET @strInput = replace(@strInput,' ','-') 
RETURN @strInput 
END
GO



-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------


