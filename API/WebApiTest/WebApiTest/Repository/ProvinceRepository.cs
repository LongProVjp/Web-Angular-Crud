using WebApiTest.Model;

namespace WebApiTest.Repository
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly DataContext _context;
        public ProvinceRepository(DataContext context)
        {
            _context = context ??
                 throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<ModelProvince>> GetProvince()
        {
            return await _context.Provinces.ToListAsync();
        }
        public async Task<ModelProvince> GetProvinceByID(int ID)
        {
            return await _context.Provinces.FindAsync(ID);
        }
        public async Task<ModelProvince> InsertProvince(ModelProvince objProvince)
        {
            _context.Provinces.Add(objProvince);
            await _context.SaveChangesAsync();
            return objProvince;
        }
        public async Task<ModelProvince> UpdateProvince(ModelProvince objProvince)
        {
            _context.Entry(objProvince).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return objProvince;
        }
        public bool DeleteProvince(int ID)
        {
            bool result = false;
            var provincess = _context.Provinces.Find(ID);
            if (provincess != null)
            {
                _context.Entry(provincess).State = EntityState.Deleted;
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
