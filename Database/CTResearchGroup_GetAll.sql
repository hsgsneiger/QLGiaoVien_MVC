USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTResearchGroup_GetAll]    Script Date: 5/26/2019 10:58:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTResearchGroup_GetAll]
AS
SELECT id,TenNhomNCKH
FROM dbo.NhomNCKH
