using WebApiTest.Model;

namespace WebApiTest.Repository
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<ModelProvince>> GetProvince();
        Task<ModelProvince> GetProvinceByID(int ID);
        Task<ModelProvince> InsertProvince(ModelProvince objProvince);
        Task<ModelProvince> UpdateProvince(ModelProvince objProvince);
        bool DeleteProvince(int ID);
    }
}
