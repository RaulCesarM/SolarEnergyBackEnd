using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarEnergyBackEnd.Models {
    
    public class Producao {

        public int IdProducao { get; set; }
        public string  unidade { get; set; }
        public DateTime? data { get; set; }
        public double? totalGerado { get; set; }


    }
}
