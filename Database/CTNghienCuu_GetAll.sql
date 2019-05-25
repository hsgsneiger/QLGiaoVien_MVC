USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTNghienCuu_GetAll]    Script Date: 5/25/2019 10:14:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTNghienCuu_GetAll] @MaGV INT, @NamHoc INT=NULL 
AS
BEGIN
	SELECT TenDeTai,
		   LoaiDeTai_id,
		   NhomNCKH_id,
		   SoTacGia,
		   dbo.DeTaiNghienCuuKHCN.VaiTro_id INTO #GVTmp
	FROM dbo.GiaoVien_DeTaiNghienCuuKHCN
	INNER JOIN dbo.DeTaiNghienCuuKHCN ON GiaoVien_DeTaiNghienCuuKHCN.DeTai_id = DeTaiNghienCuuKHCN.id
	WHERE GiaoVien_id = @MaGV
	  SELECT TenNhomNCKH,
			 dbo.LoaiNCKH.TyLeNhan AS TyLeLoai,
			 TenVaiTro,
			 VaiTro.TyLeNhan AS TyLeVaiTro,
			 TenLoai,
			 dbo.NhomNCKH.SoGioChuan,
			 dbo.NhomNCKH.id,
			 dbo.LoaiNCKH.id AS LoaiId,
			 dbo.VaiTro.id AS VaiTroId INTO #NghienCuuTmp
	FROM dbo.VaiTro
	INNER JOIN dbo.NhomNCKH ON NhomNCKH.id = VaiTro.NhomNCKH_id
	INNER JOIN dbo.LoaiNCKH ON LoaiNCKH.NhomNCKH_id = NhomNCKH.id
	SELECT #NghienCuuTmp.id,
		   TenNhomNCKH,
		   TyLeLoai,
		   TenVaiTro,
		   TyLeVaiTro,
		   TenLoai,
		   SoGioChuan,
		   TenDeTai,
		   SoTacGia,
		   #NghienCuuTmp.id AS NhomNCKH_id
	FROM #GVTmp
	JOIN #NghienCuuTmp ON #GVTmp.NhomNCKH_id = #NghienCuuTmp.id
	WHERE #GVTmp.LoaiDeTai_id = #NghienCuuTmp.LoaiId
	  AND #GVTmp.VaiTro_id = #NghienCuuTmp.VaiTroId
	  DROP TABLE #GVTmp
	  DROP TABLE #NghienCuuTmp 
END