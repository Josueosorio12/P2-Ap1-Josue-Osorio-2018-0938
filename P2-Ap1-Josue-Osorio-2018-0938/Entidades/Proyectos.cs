using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Ap1_Josue_Osorio_2018_0938.Entidades
{
   public class Proyectos
    {
        [Key]

        public int Proyectoid { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public string Descripcion { get; set; }
        public int Total { get; set; }


        [ForeignKey("Proyectoid")]

        public virtual List<TipoDetalle> TipoDetalle { get; set; }

       public Proyectos()
        {
            Proyectoid = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            TipoDetalle = new List<TipoDetalle>();
        }
    }
}
