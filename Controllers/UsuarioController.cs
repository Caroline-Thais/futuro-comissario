using Microsoft.AspNetCore.Mvc;
using etapa_3___Projeto_integrador_MVC.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Projeto_integrador_MVC.Models;

namespace etapa_3___Projeto_integrador_MVC.Controllers
{
    public class UsuarioController : Controller
    {
         public  IActionResult Cadastrar(){
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario){
            UsuarioBanco user = new UsuarioBanco();
            user.Insert(novoUsuario);
            return View("concluido");
        }
        public  IActionResult Cadastro(){
            return View();
        }

        public IActionResult Lista()
        {
            
            UsuarioBanco user = new UsuarioBanco();
            List<Usuario> lista = user.Query();
            return View(lista);
        }
      
        [HttpPost]

        public IActionResult Cadastro(Usuario usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            Usuario usuarioSessao = usuarioBanco.QueryCadastro(usuario);

            if(usuarioSessao != null){
                ViewBag.Mensagem = "Faça o download das questões ANAC https://drive.google.com/file/d/1cP9YZ_HCzEb3Ez_R1NgSRjo5UBa3pZ9L/view";;
                return View();
            } else {
                ViewBag.Mensagem = "Falha no login";
                return View();
            }    
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Cadastro");
        }
    }
}
