using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class Projeto
    {
        public int id_projeto { get; set; }
        public string ds_municipio { get; set; }
        public string ds_estado { get; set; }

        public string ds_status { get; set; }
        public string dt_data { get; set; }

        public int nr_versao { get; set; }
        public string nr_projeto { get; set; }
        public string ds_titulo { get; set; }
        public string ds_resumo { get; set; }
        public string ds_link_arquivo { get; set; }
        public string dt_criacao { get; set; }
        public string dt_vigor { get; set; }
        public double vl_orcamento { get; set; }
        public string ds_link_video { get; set; }
        public string nm_partido { get; set; }
        public string nm_autor { get; set; }
    }
}