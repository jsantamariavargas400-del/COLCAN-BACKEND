using Data.DataInterface;
using Dto.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class PacienteContext : IPaciente
    {
        private readonly ColcanContex _context;

        public PacienteContext(ColcanContex context) {
          
            _context = context;        
        }

        public List<ResultSp> GetPacientes()
        {
            return _context.ResultSp.FromSqlRaw("SP_GET_LISTA_PACIENTES").AsEnumerable().ToList();
        }

        public ResultSp GetPacienteXId(int Id)
        {
            return _context.ResultSp.FromSqlRaw("SP_GET_PACIENTE_X_ID @Id",
                new SqlParameter("@Id", Id)
                ).AsEnumerable().FirstOrDefault() ?? new ResultSp();
        }

        public bool InsertPaciente(PacienteModel model)
        {
            var resp = _context.Response.FromSqlRaw("SP_INSERT_PACIENTE @Nombres ,@Apellidos , @TipoDocumentoId ,@NumeroDocumento ,@Genero_Id ,@FechaNacimiento  , @CorreoElectronico ,@Direccion ,@Telefono ,@Cotizante ,@SubRed_Id",
               new SqlParameter("@Nombres", model.Nombres),
               new SqlParameter("@Apellidos", model.Apellidos),
               new SqlParameter("@TipoDocumentoId", model.TipoDocumento_Id),
               new SqlParameter("@NumeroDocumento", model.NumeroDocumento),
               new SqlParameter("@NumeroDocumento", model.NumeroDocumento),
               new SqlParameter("@Genero_Id", model.Genero_Id),
               new SqlParameter("@FechaNacimiento", model.FechaNacimiento),
               new SqlParameter("@CorreoElectronico", model.CorreoElectronico),
               new SqlParameter("@Direccion", model.Direccion),
               new SqlParameter("@Telefono", model.Telefono),
               new SqlParameter("@Cotizante", model.Cotizante),
               new SqlParameter("@SubRed_Id", model.SubRed_Id)
                ).AsEnumerable().FirstOrDefault();

            return Convert.ToBoolean(resp.IsSuccess);
        }


        public bool UpdatePaciente(PacienteModel model)
        {
            var resp = _context.Response.FromSqlRaw("SP_UPDATE_PACIENTE @Id, @Nombres ,@Apellidos , @TipoDocumentoId ,@NumeroDocumento ,@Genero_Id ,@FechaNacimiento  , @CorreoElectronico ,@Direccion ,@Telefono ,@Cotizante ,@SubRed_Id, @Activo",
               new SqlParameter("@Id", model.Id),
               new SqlParameter("@Nombres", model.Nombres),
               new SqlParameter("@Apellidos", model.Apellidos),
               new SqlParameter("@TipoDocumentoId", model.TipoDocumento_Id),
               new SqlParameter("@NumeroDocumento", model.NumeroDocumento),
               new SqlParameter("@Genero_Id", model.Genero_Id),
               new SqlParameter("@FechaNacimiento", model.FechaNacimiento),
               new SqlParameter("@CorreoElectronico", model.CorreoElectronico),
               new SqlParameter("@Direccion", model.Direccion),
               new SqlParameter("@Telefono", model.Telefono),
               new SqlParameter("@Cotizante", model.Cotizante),
               new SqlParameter("@SubRed_Id", model.SubRed_Id),
               new SqlParameter("@Activo", model.Activo)
                ).AsEnumerable().FirstOrDefault();

            return Convert.ToBoolean(resp.IsSuccess);
        }


        public bool DeletePaciente(int Id)
        {
            var resp = _context.Response.FromSqlRaw("SP_DELETE_PACIENTE @Id",
               new SqlParameter("@Id", Id)
              ).AsEnumerable().FirstOrDefault();

            return resp != null ? resp.IsSuccess : false;          
        }
    }
}
