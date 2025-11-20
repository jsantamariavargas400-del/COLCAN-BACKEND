using Data.DataInterface;
using Dto.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class MaestrosContext : IMaestro
    {
        private readonly ColcanContex _context;

        public MaestrosContext(ColcanContex context) {
          
            _context = context;        
        }
  
        public List<MaestroModel> GetGeneros()
        {
            return _context.MaestroModel.FromSqlRaw("SP_GET_TIPOS_GENERO").AsEnumerable().ToList();
        }

        public List<MaestroModel> GetTiposDocumentos()
        {
            return _context.MaestroModel.FromSqlRaw("SP_GET_TIPOS_DOCUMENTOS").AsEnumerable().ToList();
        }
        public List<MaestroModel> GetTiposSubRed()
        {
            return _context.MaestroModel.FromSqlRaw("SP_GET_TIPOS_SUBRED").AsEnumerable().ToList();
        }

    
    }
}
