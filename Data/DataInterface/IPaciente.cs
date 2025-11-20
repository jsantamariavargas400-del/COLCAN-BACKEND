using Dto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataInterface
{
    public interface IPaciente
    {
        public List<ResultSp> GetPacientes();
        public ResultSp GetPacienteXId(int Id);
        public bool InsertPaciente(PacienteModel model);

        public bool UpdatePaciente(PacienteModel model);

        public bool DeletePaciente(int Id);
    }
}
