USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTGuideType_GetAll]    Script Date: 5/26/2019 10:57:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTGuideType_GetAll]
AS
BEGIN
	SELECT id,TenLoaiHuongDan
	FROM dbo.LoaiHuongDan
END