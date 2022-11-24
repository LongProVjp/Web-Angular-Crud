using WebApiTest.Model;

namespace WebApiTest.Repository
{
    public interface IDistrictRepository
    {
        Task<IEnumerable<ModelDistrict>> GetDistrict();
        Task<ModelDistrict> GetDistrictByID(int ID);
        Task<ModelDistrict> InsertDistrict(ModelDistrict objDistrict);
        Task<ModelDistrict> UpdateDistrict(ModelDistrict objDistrict);
        bool DeleteDistrict(int ID);
    }
}
