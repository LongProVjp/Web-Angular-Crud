using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTest.Model
{
    [Table("District")]
    public class ModelDistrict
    {
        [Key]
        public int DistrictID { get; set; }
        public string DistrictName { get; set;} = string.Empty;
        public string ProvinceName { get; set; } = string.Empty;
    }
}
