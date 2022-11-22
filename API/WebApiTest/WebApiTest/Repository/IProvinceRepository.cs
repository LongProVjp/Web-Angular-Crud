using WebApiTest.Model;

namespace WebApiTest.Repository
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<ProvinceClass>> GetProvince();
        Task<ProvinceClass> GetProvinceByID(int ID);
        Task<ProvinceClass> InsertProvince(ProvinceClass objProvince);
        Task<ProvinceClass> UpdateProvince(ProvinceClass objProvince);
        bool DeleteProvince(int ID);
    }
}
