using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoAPI.Controllers
{
    public class ProjetosController : ApiController
    {
        // GET api/Projetos
        public IEnumerable<Projeto> Get()
        {
            return RepositorioProjeto.Projetos;
        }

        // GET api/Projetos/5
        public IHttpActionResult Get(int id)
        {
            Projeto projeto = RepositorioProjeto.Projetos.FirstOrDefault(l => l.id_projeto == id);

            if (projeto != null)
                return ResponseMessage(Request.CreateResponse<Projeto>(HttpStatusCode.OK, projeto));
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Projeto não encontrado"));
        }

        // POST api/Projetos
        public IHttpActionResult Post([FromBody] Projeto objeto)
        {
            Projeto projeto = RepositorioProjeto.Projetos.FirstOrDefault(l => l.id_projeto == objeto.id_projeto);

            if (projeto != null)
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.Conflict, "Já existe um registro"));
            else
            {
                RepositorioProjeto.Projetos.Add(objeto);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
        }

        // PUT api/Projetos/5
        public IHttpActionResult Put([FromBody] Projeto objeto)
        {
            Projeto projeto = RepositorioProjeto.Projetos.FirstOrDefault(l => l.id_projeto == objeto.id_projeto);

            if (projeto != null)
            {
                projeto.ds_titulo = objeto.ds_titulo;
                projeto.ds_resumo = objeto.ds_resumo;
                projeto.vl_orcamento = objeto.vl_orcamento;
                projeto.ds_link_arquivo = objeto.ds_link_arquivo;

                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Projeto não localizado"));
        }
    }
}