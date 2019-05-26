USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTResearch_GetByID]    Script Date: 5/26/2019 10:57:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTResearch_GetByID]
@ID INT
AS
BEGIN
	SELECT id,NhomNCKH_id,TenDeTai,LoaiDeTai_id,VaiTro_id,SoTacGia,SoTrang
	FROM dbo.DeTaiNghienCuuKHCN
	WHERE id = @id
END
