USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTGuideSystem_GetAllByGuideType]    Script Date: 5/26/2019 10:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTGuideSystem_GetAllByGuideType]
@LoaiHuongDan_id int
AS
BEGIN
	SELECT id,TenHeHuongDan
	FROM dbo.HeHuongDan
	WHERE LoaiHuongDan_id = @LoaiHuongDan_id
END