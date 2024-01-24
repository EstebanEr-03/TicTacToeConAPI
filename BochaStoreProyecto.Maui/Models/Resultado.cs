using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BochaStoreProyecto.Maui.Models
{
    public class Resultado
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public bool resultado { get; set; }
        public int CantidadVictorias { get; set; }
        public DateTime fechaResultado { get; set; }


    }
}
