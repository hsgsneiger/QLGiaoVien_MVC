USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTLecturer_GetAll]    Script Date: 5/26/2019 10:57:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTLecturer_GetAll]
AS
BEGIN
	SELECT id,HoTen
	FROM dbo.GiaoVien
END