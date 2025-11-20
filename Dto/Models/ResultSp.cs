using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dto.Models
{
    public class ResultSp
    {
        public int Id { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Cotizante { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }

        public string Genero { get; set; }
        public string SubRed { get; set; }
        public string Localidad { get; set; }

        public int Genero_id { get; set; }
        public int TipoDocumento_Id { get; set; }
        public int SubRed_Id { get; set; }
        public bool Activo { get; set; }

    }
}
