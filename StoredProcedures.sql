select	id_khoi as [KHỐI],
		ten_khoi as [Tên Khối],
		so_lop as [Số Lớp] 
	from	KHOI
go


select	LOP.ten_lop as [Lớp],
		LOP.si_so as [Sĩ Số],
		KHOI.ten_khoi as [Khối], 
		GV.ho_ten as [GVCN] 

from	KHOI,LOP,GV 

where	KHOI.id_khoi=LOP.id_khoi 
		and LOP.id_gv=GV.id_gv
		
go