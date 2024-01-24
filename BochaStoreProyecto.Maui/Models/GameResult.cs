using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BochaStoreProyecto.Maui.Models
{
    // GameResult.cs
    public class GameResult
    {
        public int Id { get; set; }
        public string Winner { get; set; }
        public string cantidadVictorias { get; set; }
        public DateTime Date { get; set; }
    }

}
