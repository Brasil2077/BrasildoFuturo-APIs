using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class RepositorioProjeto
    {
        private static List<Projeto> projetos;

        public static List<Projeto> Projetos
        {
            get
            {
                if (projetos == null)
                    GerarProjeto();
                return projetos;
            }
            set
            {
                projetos = value;
            }
        }

        private static void GerarProjeto()
        {
            projetos = new List<Projeto>();

            projetos.Add(new Projeto
            {
                id_projeto = 1,
                ds_municipio = "Osasco",
                ds_estado = "São Paulo",
                ds_status = "aberto",
                dt_data = "2021-04-01",
                nr_versao = 1,
                nr_projeto = "187545",
                ds_titulo = "Bolsa Família",
                ds_resumo = "Distribuição de renda...",
                ds_link_arquivo = "xpto.com.br",
                dt_criacao = "2021-04-01",
                dt_vigor = "",
                vl_orcamento = 100254.63,
                ds_link_video = "xpto.com.br",
                nm_partido = "Brasil do Futuro",
                nm_autor = "Eu mesmo"
            });

            projetos.Add(new Projeto
            {
                id_projeto = 2,
                ds_municipio = "Osasco",
                ds_estado = "São Paulo",
                ds_status = "aberto",
                dt_data = "2021-04-05",
                nr_versao = 3,
                nr_projeto = "256421",
                ds_titulo = "Asfalto geral",
                ds_resumo = "Melhoria das vias",
                ds_link_arquivo = "xpto.com.br",
                dt_criacao = "2021-04-05",
                dt_vigor = "",
                vl_orcamento = 100254.63,
                ds_link_video = "xpto.com.br",
                nm_partido = "Brasil do Futuro",
                nm_autor = "Eu mesmo"
            });

            projetos.Add(new Projeto
            {
                id_projeto = 3,
                ds_municipio = "Osasco",
                ds_estado = "São Paulo",
                ds_status = "aberto",
                dt_data = "2021-04-07",
                nr_versao = 10,
                nr_projeto = "165132",
                ds_titulo = "Segurança",
                ds_resumo = "Melhora na iluminação publica",
                ds_link_arquivo = "xpto.com.br",
                dt_criacao = "2021-04-07",
                dt_vigor = "",
                vl_orcamento = 100254.63,
                ds_link_video = "xpto.com.br",
                nm_partido = "Brasil do Futuro",
                nm_autor = "Eu mesmo"
            });
        }
    }
}