using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.Intrinsics.Arm;
using WebApiTest.Model;
using WebApiTest.Repository;
namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceRepository _provincess;

        public ProvinceController(IProvinceRepository provincess)
        {
            _provincess = provincess ??
                throw new ArgumentNullException(nameof(provincess));
        }
        //Get all
        [HttpGet]
        [Route("GetProvince")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _provincess.GetProvince());
        }
        //Search
        [HttpGet]
        [Route("GetProvinceByID/{Id}")]
        public async Task<IActionResult> GetProById(int Id)
        {
            return Ok(await _provincess.GetProvinceByID(Id));
        }
        //Add
        [HttpPost]
        [Route("AddProvince")]
        public async Task<IActionResult> Post(ProvinceClass pro)
        {
            var result = await _provincess.InsertProvince(pro);
            if (result.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return new JsonResult("Added Successfully");

        }
        //Update
        [HttpPut]
        [Route("UpdateProvince")]
        public async Task<IActionResult> Put(ProvinceClass pro)
        {
            await _provincess.UpdateProvince(pro);
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeleteProvince/{id}")]
        public JsonResult DeleteProvince(int id)
        {
            _provincess.DeleteProvince(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}
