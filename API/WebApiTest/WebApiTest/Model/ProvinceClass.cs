using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTest.Model
{
    public class ProvinceClass
    {
        public int Id { get; set; }
        public string Province { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
    }
}
