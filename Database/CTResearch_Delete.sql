USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTResearch_Delete]    Script Date: 5/26/2019 10:57:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTResearch_Delete]
@ID int
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM dbo.GiaoVien_DeTaiNghienCuuKHCN WHERE DeTai_id =@ID
			DELETE FROM dbo.DeTaiNghienCuuKHCN WHERE id = @ID
		COMMIT
    END TRY
	BEGIN CATCH
		DECLARE @error NVARCHAR(100)
		SET @error = ERROR_MESSAGE()
		RAISERROR(@error,16,1)
		ROLLBACK
	END CATCH
END
