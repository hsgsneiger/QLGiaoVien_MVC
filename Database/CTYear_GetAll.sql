USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTYear_GetAll]    Script Date: 5/25/2019 10:14:30 PM ******/
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