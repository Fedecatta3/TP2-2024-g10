﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PlanEntrenamiento
    {
        public int id_plan { get; set; }
        public string nombre { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int cantSeries { get; set; }
        public int total { get; set; }
        public Boolean estado {get;set;}
    }
}