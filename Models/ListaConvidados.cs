using System;
using System.Collections.Generic;

namespace Presenca_Evento_MVC.Models
{
    public static class ListaConvidados
    {
        //lista para simular o BD
        private static List<Convidado> listaConvidados = new List<Convidado>();


        public static void Incluir(Convidado convidado)
        {
            foreach (Convidado c in listaConvidados)
            {
                if (c.ConfirmaPresenca == true)
                {
                    listaConvidados.Add(convidado);
                }
                else
                {
                    listaConvidados.Remove(c);
                }

            }

        }

        /*
            Referencia:
            http://www.macoratti.net/13/04/mvc4_app.htm 
        */
        /* 
        validação do usuário na lista de confirmados
         */
        public static void verificaUsuario(Convidado convidado)
        {
            foreach (Convidado c in listaConvidados)
            {
                if (c.Nome == c.Nome)
                {
                    Console.WriteLine("Nome já cadastrado, inclua outro");
                    listaConvidados.Remove(c);
                    listaConvidados.Add(convidado);
                    break;
                }
            }
        }
        public static List<Convidado> Listar()
        {
            return listaConvidados;
        }
    }
}