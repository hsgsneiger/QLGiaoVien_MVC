USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTVaiTro_GetAll]    Script Date: 5/26/2019 10:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTVaiTro_GetAll]
@ID INT
AS
SELECT id,TenVaiTro
FROM dbo.VaiTro
WHERE NhomNCKH_id = @ID