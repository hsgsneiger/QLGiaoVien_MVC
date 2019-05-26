USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTGuide_Delete]    Script Date: 5/26/2019 10:56:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTGuide_Delete]
@ID int
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM dbo.GiaoVien_HuongDan WHERE HuongDan_id =@ID
			DELETE FROM dbo.HuongDan WHERE id = @ID
		COMMIT
    END TRY
	BEGIN CATCH
		DECLARE @error NVARCHAR(100)
		SET @error = ERROR_MESSAGE()
		RAISERROR(@error,16,1)
		ROLLBACK
	END CATCH
END
