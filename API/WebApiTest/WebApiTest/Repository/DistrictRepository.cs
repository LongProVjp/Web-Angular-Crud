using WebApiTest.Model;

namespace WebApiTest.Repository
{
    public class DistrictRepository : IDistrictRepository
    {
        private readonly DataContext _context;
        public DistrictRepository(DataContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<ModelDistrict>> GetDistrict()
        {
            return await _context.Districts.ToListAsync();
        }
        public async Task<ModelDistrict> GetDistrictByID(int ID)
        {
            return await _context.Districts.FindAsync(ID);
        }
        public async Task<ModelDistrict> InsertDistrict(ModelDistrict objDistrict)
        {
            _context.Districts.Add(objDistrict);
            await _context.SaveChangesAsync();
            return objDistrict;

        }
        public async Task<ModelDistrict> UpdateDistrict(ModelDistrict objDistrict)
        {
            _context.Entry(objDistrict).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return objDistrict;

        }
        public bool DeleteDistrict(int ID)
        {
            bool result = false;
            var district = _context.Districts.Find(ID);
            if (district != null)
            {
                _context.Entry(district).State = EntityState.Deleted;
                _context.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
