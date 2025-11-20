using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int TipoDocumento_Id { get; set; }
        public string NumeroDocumento { get; set; }
        public int Genero_Id { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }

        public bool Cotizante { get; set; }
        public int SubRed_Id { get; set; }
        public bool Activo { get; set; }

    }
}
