using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDiazGestionTareas
{
    public class Tareas
    {
        public int id {  get; set; }
        public string titulo { get; set; }
        public string descripcion {  get; set; }
        public string categoria { get; set; }
        public string prioridad { get; set; }
        
        public DateTime fechaVencimiento { get; set; }
        public string estado { get; set; }
        public string usuario { get; set; }
    }
}
