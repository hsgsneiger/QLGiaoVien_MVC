using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class ConfigurationBL
    {
        public List<LecturerDAO> GetAllLecturers()
        {
            return new SqlHelper<LecturerDAO>().ExecuteProcAndGetData("CTLecturer_GetAll");
        }

        public List<YearDAO> GetAllYears()
        {
            return new SqlHelper<YearDAO>().ExecuteProcAndGetData("CTYear_GetAll");
        }
        public List<GuideTypeDAO> GetAllGuideType()
        {
            return new SqlHelper<GuideTypeDAO>().ExecuteProcAndGetData("CTGuideType_GetAll");
        }
        public List<GuideSystemDAO> GetAllGuideSystemBy(int LoaiHuongDan_id)
        {
            return new SqlHelper<GuideSystemDAO>().ExecuteProcAndGetData("CTGuideSystem_GetAllByGuideType", "LoaiHuongDan_id", LoaiHuongDan_id);
        }

        public List<ResearchGroupDAO> ResearchGroupGetAll()
        {
            return new SqlHelper<ResearchGroupDAO>().ExecuteProcAndGetData("CTResearchGroup_GetAll");
        }
        public List<VaiTro> VaitroGetAll(int ID)
        {
            return new SqlHelper<VaiTro>().ExecuteProcAndGetData("CTVaiTro_GetAll","ID",ID);
        }
        public List<ResearchTypeDAO> ResearchTypeGetAll(int ID)
        {
            return new SqlHelper<ResearchTypeDAO>().ExecuteProcAndGetData("CTResearchType_GetAll","ID",ID);
        }
        public List<KhaoThi_LoaiKT> LoaiKhaoThi_GetAll()
        {
            return new SqlHelper<KhaoThi_LoaiKT>().ExecuteProcAndGetData("LoaiKhaoThi_GetAll");
        }
        public List<HoiDong_LHD> LoaiHoiDong_GetAll()
        {
            return new SqlHelper<HoiDong_LHD>().ExecuteProcAndGetData("LoaiHoiDong_GetAll");
        }
        public List<HoiDong_MTG> MucThamGia_GetBy(int LoaiHoiDong_id)
        {
            return new SqlHelper<HoiDong_MTG>().ExecuteProcAndGetData("MucThamGia_GetAllBy","LoaiHoiDong_id",LoaiHoiDong_id);
        }
    }
}
