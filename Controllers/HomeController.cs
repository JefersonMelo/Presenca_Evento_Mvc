using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presenca_Evento_MVC.Models;

/* 
          Olá Jeferson, 
          Parabéns pelo esforço e pela entrega, está  no caminho certo. 
          O problema que me relata creio que tenha muito a ver com uma questão da
          lógica e do que deve estar dentro ou fora do laço "foreach". Baixe aqui um 
          vídeo que gravei para tentar explicar esse caso (usei 7zip para compactar).
          Na verdade, eu penso até que pode usar a estrutura mais simples e elegante 
          que adotou no projeto MVC: uma classe para o convidado, outra para a lista 
          de convidado (até com um método que compara a repetição); no caso o Program.cs 
          no projeto console é que usaria essas classes, mais ou menos como o homecontroller
          usa no projeto mvc. O projeto MVC está bacana, estruturalmente correto. 
          No entanto, novamente é a lógica que está levando a equívocos: o convidado não é cadastrado 
          e isso por conta de laços "foreach" que não são necessários. Explico mais neste vídeo aqui, 
          também compactado usando 7zip (clique aqui para baixar).
          Veja com cuidado, faça as alterações e, se necessário, revise alguns dos últimos momentos online 
          para alguns conteúdos. Qualquer dúvida ou problema me chama ali em Fale com o Tutor.
          Abraço!
          tutor Daltron

       */


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
            else
            {
                return View("Falha");
            }
        }

        public IActionResult Concluido()
        {
            return View("Cadastro");
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
