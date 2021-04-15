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
                return ResponseMessage(Request.CreateResponse<Projeto>(HttpStatusCode.NotFound, projeto));
        }
    }
}