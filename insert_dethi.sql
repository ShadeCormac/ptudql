use QLThiTracNghiem
go

insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien1', 'giaovien1', 2)
insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien2', 'giaovien2', 2)
insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien3', 'giaovien3', 2)
insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTK) values('giaovien4', 'giaovien4', 2)

insert into GiaoVien(TenTK, Ten) values('giaovien1', N'Giáo viên 1')
insert into GiaoVien(TenTK, Ten) values('giaovien2', N'Giáo viên 2')
insert into GiaoVien(TenTK, Ten) values('giaovien3', N'Giáo viên 3')
insert into GiaoVien(TenTK, Ten) values('giaovien4', N'Giáo viên 4')

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
							values('KT'+@IdDe, @tenKyThi,0,@numDe%2,GETDATE(),'31/12/2018')
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