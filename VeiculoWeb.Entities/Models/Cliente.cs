using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeiculoWeb.Entities.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }
        public bool Bloqueado { get; set; }
        public List<string> Imagens { get; set; }
        public HttpPostedFileBase[] uploadedFile { get; set; }
    }
}