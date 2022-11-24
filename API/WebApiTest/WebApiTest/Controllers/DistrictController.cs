using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Model;
using WebApiTest.Repository;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictRepository _district;
        private readonly IProvinceRepository _province;
        public DistrictController(IDistrictRepository district, IProvinceRepository province)
        {
            _district = district ??
                 throw new ArgumentNullException(nameof(district));
            _province = province ??
                throw new ArgumentNullException(nameof(province));
        }
        [HttpGet]
        [Route("GetDistrict")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _district.GetDistrict());
        }
        [HttpGet]
        [Route("GetDistrictByID/{Id}")]
        public async Task<IActionResult> GetDisByID(int Id)
        {
            return Ok(await _district.GetDistrictByID(Id));
        }
        [HttpPost]
        [Route("AddDistrict")]
        public async Task<IActionResult> Post(ModelDistrict dis)
        {
            var result = await _district.InsertDistrict(dis);
            if (result.DistrictID == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        [Route("UpdateDistrict")]
        public async Task<IActionResult> Put(ModelDistrict dis)
        {
            await _district.UpdateDistrict(dis);
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete]
        [Route("DeleteDistrict/{Id}")]
        public JsonResult Delete(int id)
        {
            _district.DeleteDistrict(id);
            return new JsonResult("Deleted Successfully");
        }
        [HttpGet]
        [Route("GetAllProvince")]
        public async Task<IActionResult> GetAllProvince()
        {
            return Ok(await _province.GetProvince());
        }
    }
}
