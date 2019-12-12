using System;
using System.Collections.Generic;

namespace Presenca_Evento_MVC.Models
{
    public static class ListaConvidados
    {
        //lista para simular o BD
        private static List<Convidado> listaConvidados = new List<Convidado>();

        /*
            Referencia:
            http://www.macoratti.net/13/04/mvc4_app.htm 
        */

        //confirma presença, radio buttom
        public static bool Confirmacao(Convidado convidado, int confirmaPresenca_Radio)
        {
            if (confirmaPresenca_Radio == 1)
            {
                return convidado.ConfirmaPresenca = true;
            }
            else
            {
                return convidado.ConfirmaPresenca = false;
            }
        }

        //validação do usuário na lista de confirmados
        public static bool verificaUsuario(Convidado convidado)
        {
            bool repetido = false;
            foreach (Convidado c in listaConvidados)
            {
                if (c.Nome == convidado.Nome)
                {
                    repetido = true;
                }
            }
            return repetido;
        }

        //incluir convidado na lista
        public static void Incluir(Convidado convidado)
        {
            if (convidado.ConfirmaPresenca == true)
            {
                listaConvidados.Add(convidado);
            }

        }
        //retorna a lista
        public static List<Convidado> Listar()
        {
            return listaConvidados;
        }
    }
}