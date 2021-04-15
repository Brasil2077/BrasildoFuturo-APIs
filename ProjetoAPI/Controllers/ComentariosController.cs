using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoAPI.Controllers
{
    public class ComentariosController : ApiController
    {
        // GET api/comentarios
        public IEnumerable<Comentario> Get()
        {
            return RepositorioComentario.Comentarios;
        }

        // GET api/comentarios/5
        public IHttpActionResult Get(int id)
        {
            Comentario comentario = RepositorioComentario.Comentarios.FirstOrDefault(l => l.id_comentario == id);

            if (comentario != null)
                return ResponseMessage(Request.CreateResponse<Comentario>(HttpStatusCode.OK, comentario));
            else
                return ResponseMessage(Request.CreateResponse<Comentario>(HttpStatusCode.NotFound, comentario));
        }

        // POST api/comentarios
        public IHttpActionResult Post([FromBody] Comentario objeto)
        {
            Comentario comentario = RepositorioComentario.Comentarios.FirstOrDefault(l => l.id_comentario == objeto.id_comentario);

            if (comentario != null)
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.Conflict, "Já existe um registro"));
            else
            {
                RepositorioComentario.Comentarios.Add(objeto);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
        }

        // PUT api/comentarios/5
        public IHttpActionResult Put([FromBody] Comentario objeto)
        {
            Comentario comentario = RepositorioComentario.Comentarios.FirstOrDefault(l => l.id_comentario == objeto.id_comentario);

            if (comentario != null)
            {
                comentario.ds_comentario = objeto.ds_comentario;
                comentario.dt_data = objeto.dt_data;
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Comentário não localizado"));
        }

        // DELETE api/comentarios/5
        public IHttpActionResult Delete(int id)
        {
            Comentario comentario = RepositorioComentario.Comentarios.FirstOrDefault(l => l.id_comentario == id);

            if (comentario != null)
            {
                RepositorioComentario.Comentarios.Remove(comentario);
                return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK));
            }
            else
                return ResponseMessage(Request.CreateResponse<string>(HttpStatusCode.NotFound, "Comentário não localizado"));


        }
    }
}