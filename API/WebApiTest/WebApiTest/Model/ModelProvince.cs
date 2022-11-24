using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTest.Model
{
    [Table("Province")]
    public class ModelProvince
    {
        [Key]
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; } = string.Empty;
    }
}
