USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTYear_GetAll]    Script Date: 5/26/2019 10:58:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTYear_GetAll]
AS
BEGIN
	SELECT id,TenNamHoc
	FROM dbo.NamHoc
END