using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAPI.Models
{
    public class RepositorioComentario
    {
        private static List<Comentario> comentarios;

        public static List<Comentario> Comentarios
        {
            get
            {
                if (comentarios == null)
                    GerarComentario();
                return comentarios;
            }
            set
            {
                comentarios = value;
            }
        }

        private static void GerarComentario()
        {
            comentarios = new List<Comentario>();

            comentarios.Add(new Comentario
            {
                id_comentario = 1,
                id_usuario = 1,
                id_projeto = 1,
                ds_comentario = "Ótimo projeto",
                dt_data = "2021-04-01",
            });

            comentarios.Add(new Comentario
            {
                id_comentario = 2,
                id_usuario = 2,
                id_projeto = 2,
                ds_comentario = "Péssimo projeto",
                dt_data = "2021-04-05",
            });

            comentarios.Add(new Comentario
            {
                id_comentario = 3,
                id_usuario = 3,
                id_projeto = 3,
                ds_comentario = "Projeto OK",
                dt_data = "2021-04-07",
            });
        }
    }
}