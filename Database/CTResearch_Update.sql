USE [dbQLGiaoVien]
GO
/****** Object:  StoredProcedure [dbo].[CTResearch_Update]    Script Date: 5/26/2019 10:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CTResearch_Update]
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
	UPDATE dbo.DeTaiNghienCuuKHCN
	SET
		NhomNCKH_id =@NhomNCKH_id,
		TenDeTai =@TenDeTai,
		SoTacGia =@SoTacGia,
		LoaiDeTai_id = @LoaiDeTai_id ,
		VaiTro_id =@VaiTro_id,
		SoTrang = @SoTrang
	WHERE id = @id
END