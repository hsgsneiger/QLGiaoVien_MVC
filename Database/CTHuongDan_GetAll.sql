USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTHuongDan_GetAll]    Script Date: 5/25/2019 10:12:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTHuongDan_GetAll]
@MaGV INT,
@NamHoc INT=NULL
AS
BEGIN
	CREATE TABLE #tmp (
		HoTenHocVien NVARCHAR(MAX),
		Lop NVARCHAR(50),
		HeHuongDan_id INT,
		SoCBHD TINYINT,
		LoaiHuongDan_id INT,
		TenDeTai_ChuyenDe nvarchar(MAX)
	)
	INSERT INTO #tmp
	( HoTenHocVien,Lop,HeHuongDan_id, SoCBHD,LoaiHuongDan_id,TenDeTai_ChuyenDe)
	SELECT HoTenHocVien,Lop,HeHuongDan_id,SoCBHD,LoaiHuongDan_id,TenDeTai_ChuyenDe
	FROM dbo.HuongDan JOIN dbo.GiaoVien_HuongDan ON GiaoVien_HuongDan.HuongDan_id = HuongDan.id
	WHERE GiaoVien_id = @MaGV AND (NamHoc_id = @NamHoc OR @NamHoc IS NULL)

	SELECT  tmp.HoTenHocVien,
			tmp.Lop,TenHeHuongDan,
			TenLoaiHuongDan,
			SoGioDinhMuc,SoCBHD,
			TenDeTai_ChuyenDe,
			HeHuongDan.LoaiHuongDan_id
	FROM #tmp AS tmp JOIN dbo.HeHuongDan ON  tmp.HeHuongDan_id = dbo.HeHuongDan.id
	JOIN dbo.LoaiHuongDan ON LoaiHuongDan.id = HeHuongDan.LoaiHuongDan_id
	DROP TABLE #tmp
END