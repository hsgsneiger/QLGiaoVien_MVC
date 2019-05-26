USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTGuide_GetByID]    Script Date: 5/26/2019 10:56:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTGuide_GetByID]
@id INT
AS
BEGIN
	SELECT id,TenDeTai_ChuyenDe,SoCBHD,HoTenHocVien,LoaiHuongDan_id,Lop,HeHuongDan_id
	FROM dbo.HuongDan
	WHERE id = @id
END
