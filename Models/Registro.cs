﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarEnergyBackEnd.Models {
    
    public class Registro {

  
        public int IdRegistro { get; set; }
        public double Janeiro { get; set; }
        public double Fevereiro { get; set; }
        public double Marco { get; set; }
        public double Abril { get; set; }
        public double Maio { get; set; }
        public double Junho { get; set; }
        public double Julho { get; set; }
        public double Agosto { get; set; }
        public double Setembro { get; set; }
        public double Outubro { get; set; }
        public double Novembro { get; set; }
        public double Dezembro { get; set; }

    }
}
