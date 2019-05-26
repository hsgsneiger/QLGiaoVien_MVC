USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTGuide_Update]    Script Date: 5/26/2019 10:56:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTGuide_Update]
@id int,
@TenDeTai_ChuyenDe nvarchar(255),
@SoCBHD INT,
@HoTenHocVien NVARCHAR(255),
@Lop nvarchar(50),
@LoaiHuongDan_id int,
@HeHuongDan_id INT,
@MaGV INT,
@MaNamHoc INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE dbo.HuongDan
			SET LoaiHuongDan_id = @LoaiHuongDan_id,
				TenDeTai_ChuyenDe = @TenDeTai_ChuyenDe,
				HoTenHocVien=@HoTenHocVien,
				Lop=@Lop,
				HeHuongDan_id=@HeHuongDan_id,
				SoCBHD=@SoCBHD
            WHERE id = @id

		COMMIT
    END TRY
	BEGIN CATCH
		DECLARE @error NVARCHAR(100)
		SET @error = ERROR_MESSAGE()
		RAISERROR(@error,16,1)
		ROLLBACK
	END CATCH
END
