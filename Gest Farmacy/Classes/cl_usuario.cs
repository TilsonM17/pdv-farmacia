using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace M17.GestFarmacy.Usuario
{
    static class cl_usuario
    {
        public static int id_usuario { get; set; }
        public static string Nome { get; set; }
              

       

        public static void buscarUsuario(DataRow dados)
        {
            id_usuario = Convert.ToInt32(dados["id_usuario"]);
            Nome = dados["nome_completo"].ToString();
        }

    }
}
