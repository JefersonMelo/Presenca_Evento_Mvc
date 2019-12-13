using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presenca_Evento_MVC.Models;

namespace Presenca_Evento_MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        //cadastro
        public IActionResult Cadastro()
        {
            return View();
        }
        //cadastrar convidado
        [HttpPost]
        public IActionResult Cadastro(Convidado convidado)
        {
            bool repetido = ListaConvidados.verificaUsuario(convidado);
            if (!repetido)
            {
                ListaConvidados.Incluir(convidado);
                return View("Concluido");
            }
            return View("Falha");
        }

        public IActionResult Concluido()
        {
            return View();
        }
        //listar convidado
        public IActionResult ListagemConvidados()
        {
            List<Convidado> listaConvidados = ListaConvidados.Listar();
            return View(listaConvidados);
        }

        //erro padrão do sistema
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
