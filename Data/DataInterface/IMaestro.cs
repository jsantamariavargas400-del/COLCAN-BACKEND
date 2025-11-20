using Dto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataInterface
{
    public interface IMaestro
    {
        public List<MaestroModel> GetTiposSubRed();
        public List<MaestroModel> GetTiposDocumentos();
        public List<MaestroModel> GetGeneros();
    }
}
