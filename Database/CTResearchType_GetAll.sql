USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTResearchType_GetAll]    Script Date: 5/26/2019 10:58:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTResearchType_GetAll]
@ID INT
AS
SELECT id,TenLoai
FROM dbo.LoaiNCKH
WHERE NhomNCKH_id = @ID