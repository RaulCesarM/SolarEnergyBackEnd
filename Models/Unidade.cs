using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SolarEnergyBackEnd.Models {
    
    public class Unidade {


        public int Id { get; set; }
        public string Apelido { get; set; }
        
        public string Local { get; set; }
        
        public string Marca { get; set; }
        
        public string Modelo { get; set; }
      
        public bool Ativo { get;  set; }

       



    }
}
