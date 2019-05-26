USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTGuide_Insert]    Script Date: 5/26/2019 10:56:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTGuide_Insert]
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
			INSERT dbo.HuongDan
			( LoaiHuongDan_id ,
			  TenDeTai_ChuyenDe ,
			  HoTenHocVien ,
			  Lop ,
			  HeHuongDan_id ,
			  DaBaoVeThanhCong ,
			  CoQuanCongTacHocVien ,
			  DiaChiLienHeXacMinh ,
			  SoCBHD
			)
	VALUES  ( @LoaiHuongDan_id , -- LoaiHuongDan_id - int
			  @TenDeTai_ChuyenDe , -- TenDeTai_ChuyenDe - nvarchar(255)
			  @HoTenHocVien , -- HoTenHocVien - nvarchar(255)
			  @Lop , -- Lop - nvarchar(50)
			  @HeHuongDan_id , -- HeHuongDan_id - int
			  0 , -- DaBaoVeThanhCong - int
			  N'' , -- CoQuanCongTacHocVien - nvarchar(255)
			  N'' , -- DiaChiLienHeXacMinh - nvarchar(255)
			  @SoCBHD  -- SoCBHD - tinyint
			)

	SET @id = @@IDENTITY
		INSERT dbo.GiaoVien_HuongDan
				( GiaoVien_id ,
				  HuongDan_id ,
				  NamHoc_id
				)
		VALUES  ( @MaGV , -- GiaoVien_id - int
				  @id , -- HuongDan_id - int
				  @MaNamHoc  -- NamHoc_id - int
				)
		COMMIT
    END TRY
	BEGIN CATCH
		DECLARE @error NVARCHAR(100)
		SET @error = ERROR_MESSAGE()
		RAISERROR(@error,16,1)
		ROLLBACK
	END CATCH
END
