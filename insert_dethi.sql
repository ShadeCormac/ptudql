use QLThiTracNghiem
go

insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien1', 'dvYG0jhm8Ah79b8tv0xSBIFSqzQS8/FTnKe3nFt6xDHVr0aV', 2) -- MK: 123123
insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien2', 'dvYG0jhm8Ah79b8tv0xSBIFSqzQS8/FTnKe3nFt6xDHVr0aV', 2)
insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien3', 'dvYG0jhm8Ah79b8tv0xSBIFSqzQS8/FTnKe3nFt6xDHVr0aV', 2)
insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien4', 'dvYG0jhm8Ah79b8tv0xSBIFSqzQS8/FTnKe3nFt6xDHVr0aV', 2)

insert into GiaoVien(TenTK, HoTen) values('giaovien1', N'Giáo viên 1')
insert into GiaoVien(TenTK, HoTen) values('giaovien2', N'Giáo viên 2')
insert into GiaoVien(TenTK, HoTen) values('giaovien3', N'Giáo viên 3')
insert into GiaoVien(TenTK, HoTen) values('giaovien4', N'Giáo viên 4')

declare cur cursor for
select IdCauHoi
from CauHoi

declare @idCauHoi int

open cur
fetch next from cur into @idCauHoi

declare @MAX int = 4
declare @numDe int = 1
declare @soCauHoi int = 20
declare @i int = 1
declare @IdDe varchar(10) = 'QS1'
declare @numGV int = 1
declare @tenKyThi nvarchar(50) = N'Kỳ thi quân sự 1'

SET DATEFORMAT dmy;

while @@FETCH_STATUS=0
begin
	if @i > @soCauHoi
	begin
		set @i = 1
		set @numDe = @numDe + 1
		set @numGV = (1 + @numDe % @MAX) 
		set @soCauHoi =	(@numGV + 1) * 10
		set @IdDe = 'QS'+cast(@numDe as varchar(10))
		set @tenKyThi = N'Kỳ thi quân sự ' + cast(@numDe as varchar(10))
	end

	if not exists(select * from DeThi where IdDe=@IdDe)
	begin
		insert into DeThi(IdDe, GVRaDe, DoKho,ThoiGian) values(@IdDe, 'giaovien'+cast(@numGV as varchar(10)), @numGV,40)
		insert into KyThi(IDKyThi,TenKyThi,SLThamGia,LoaiKyThi,ThoiGianBatDau,ThoiGianKetThuc) 
							values('KT'+@IdDe, @tenKyThi,0,1+@numDe%2,GETDATE(),'31/12/2018')
		insert into KyThi_DeThi(IdDe, IdKyThi) values(@IdDe,'KT'+@IdDe)
	end

	insert into BoDeThi(IdDe, IdCauHoi) values(@IdDe, @idCauHoi)
	
	set @i = @i + 1
	fetch next from cur into @idCauHoi
end

close cur
deallocate cur

-- 1: De (20 câu / 40 phút)
-- 2: Trung Binh (30 câu / 40 phút)
-- 3: Kho (40 câu / 40 phút)
-- 4: Cuc kho (50 câu / 40 phút)

-- Đề thi này chỉ có 3 câu => xóa
delete KyThi_DeThi where IdKyThi=N'KTQS14'
delete KyThi where IDKyThi=N'KTQS14'
delete BoDeThi where IdDe=N'QS14'
delete DeThi where IdDe=N'QS14'