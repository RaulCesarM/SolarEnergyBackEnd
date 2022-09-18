
namespace SolarEnergy.Domain.DTO
{
    public class ProducaoDTO
    {
        public int id { get; set; }
        public string unidade { get; set; }
        public DateTime? data { get; set; }
        public double? totalGerado { get; set; }
    }
}