USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTResearch_Insert]    Script Date: 5/26/2019 10:58:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTResearch_Insert]
@id int,
@TenDeTai nvarchar(255),
@SoTacGia INT,
@LoaiDeTai_id int,
@VaiTro_id INT,
@NhomNCKH_id INT,
@MaGV INT,
@MaNamHoc INT,
@SoTrang INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			INSERT dbo.DeTaiNghienCuuKHCN
			        ( NhomNCKH_id ,
			          TenDeTai ,
			          CapQuanLy ,
			          SoTacGia ,
			          ThoiGianBatDau ,
			          ThoiGianKetThuc ,
			          CoQuanQuanLy ,
			          DaNghiemThu ,
			          LoaiDeTai_id ,
			          VaiTro_id ,
			          SoTrang
			        )
			VALUES  ( @NhomNCKH_id , -- NhomNCKH_id - int
			          @TenDeTai , -- TenDeTai - nvarchar(255)
			          N'' , -- CapQuanLy - nvarchar(255)
			          @SoTacGia , -- SoTacGia - tinyint
			          GETDATE() , -- ThoiGianBatDau - date
			          GETDATE() , -- ThoiGianKetThuc - date
			          N'' , -- CoQuanQuanLy - nvarchar(255)
			          NULL , -- DaNghiemThu - bit
			          @LoaiDeTai_id , -- LoaiDeTai_id - int
			          @VaiTro_id , -- VaiTro_id - int
			          @SoTacGia  -- SoTrang - float
			        )
	SET @id = @@IDENTITY

		INSERT dbo.GiaoVien_DeTaiNghienCuuKHCN
		        ( GiaoVien_id ,
		          DeTai_id ,
		          LaChuNhiem ,
		          NamHoc_id
		        )
		VALUES  ( @MaGV , -- GiaoVien_id - int
		          @id , -- DeTai_id - int
		          NULL , -- LaChuNhiem - bit
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
