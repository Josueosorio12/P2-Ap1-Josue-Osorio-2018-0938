﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Ap1_Josue_Osorio_2018_0938.Entidades
{
  public  class TipoTarea
    {
        [Key]


        public int Tipoid { get; set; }
        public string TipodeTarea { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
    }
}



