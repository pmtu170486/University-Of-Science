USE [demo_ssis]
GO

/****** Object:  StoredProcedure [dbo].[USP_TaoHoaDon]    Script Date: 18/3/2017 10:36:31 AM ******/
DROP PROCEDURE [dbo].[USP_TaoHoaDon]
GO

/****** Object:  StoredProcedure [dbo].[USP_TaoHoaDon]    Script Date: 18/3/2017 10:36:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/*******
Date			Version				Author			Note
17/03/2017		1.1					TuPham			Alter SPP for cthd.XuLy IS NULL
17/03/2017		1.0					TuPham			Create new

*******/
CREATE PROC [dbo].[USP_TaoHoaDon]
AS 
BEGIN
	-- Prevent duplicate data
	DECLARE @NgayMua DATE,@MaKH VARCHAR(20)
	SELECT TOP 1 @NgayMua=NgayMuaHang, @Makh = Makh FROM ChiTietHoaDon_TMP
	DELETE FROM ChiTietHoaDon WHERE MaKH = @MaKH AND NgayMuaHang = @NgayMua

	INSERT INTO ChiTietHoaDon (NgayMuaHang,MaKH,Gia,SoLuong,MaSanPham) 
	SELECT NgayMuaHang,MaKH,Gia,SoLuong,MaSanPham
	FROM ChiTietHoaDon_TMP	

	DELETE FROM HoaDon WHERE MaKH = @MaKH AND NgayMuaHang = @NgayMua
	-- Processing HoaDon from CTHD
	INSERT INTO HoaDon (MaKH,NgayLapHD,NgayMuaHang,TongTien)
	SELECT cthd.MaKH,
			GETDATE(),
			cthd.NgayMuaHang,
			SUM (cthd.SoLuong * cthd.Gia)
	FROM ChiTietHoaDon cthd
	WHERE cthd.XuLy=0 OR cthd.XuLy IS NULL -- v.1.1
	GROUP BY cthd.MaKH,cthd.NgayMuaHang

	UPDATE ChiTietHoaDon 
	SET XuLy = 1
	WHERE NgayMuaHang=@NgayMua AND MaKH = @MaKH
END

GO


