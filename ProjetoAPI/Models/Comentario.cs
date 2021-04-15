using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class Comentario
    {
        public int id_comentario { get; set; }
        public int id_usuario { get; set; }
        public string id_projeto { get; set; }
        public string ds_comentario { get; set; }
        public string dt_data { get; set; }
    }
}