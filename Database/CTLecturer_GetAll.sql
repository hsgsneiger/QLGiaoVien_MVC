USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTLecturer_GetAll]    Script Date: 5/25/2019 10:13:57 PM ******/
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