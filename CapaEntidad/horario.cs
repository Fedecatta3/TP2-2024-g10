using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Horario
    {
    public int id_horario { get; set; }
    public Usuario id_usuario { get; set; }
    public string diaSemana { get; set; }
    public string horaInicio { get; set; }
    public string horaFin { get; set; }
    public Boolean estado { get; set; }
    }
}
