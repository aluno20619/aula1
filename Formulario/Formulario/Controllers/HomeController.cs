using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // view bag para guardar resposta
            ViewBag.resposta = "";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string nome,int? idade){
            ///precisamos de validar osdados introduzidos pelo utilizador
            ///Q1:o nome é um nome?
            ///Q2:a idade está dentro dos parametros pretendidos[0,120]?
            string mensagem = "";
            //validar a idade
            if (idade >= 0 && idade <= 120)
            {
                //criar mensagem de resposta
                mensagem = "Voce chama-se " + nome + " e tem " + idade + " anos";
            }
            else {
                //mensagem alternativa
                mensagem = "Deve especificar uma idade válida!\n A idade deve ser maior que zero e menor que 120 anos...";
            }
            //criar o conteudo que leverá a mensagem paraa view
            ViewBag.resposta = mensagem;
            //invoca a view
            return View();
        }
    }
}