using Avaleu.Dao;
using Avaleu.Model;
using Avaleu.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avaleu.Web.Areas.Admin.Controllers
{
    public class UsuarioController : Controller
    {
		DataContext contextBd;
		public UsuarioController()
		{
			contextBd = new DataContext();
		}

		public ActionResult Index()
		{
			var usuarioServicoBd = new UsuarioService(contextBd);			
			var listaUsuario= usuarioServicoBd.Listar();
			return View(listaUsuario);
		}

		[HttpGet]
		public ActionResult Inserir()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Inserir(Usuario usuario)
		{
			if (ModelState.IsValid)
			{
				var usuarioServicoBd = new UsuarioService(contextBd);
				usuarioServicoBd.Inserir(usuario);
				contextBd.SaveChanges();
				return RedirectToAction("Index", "Usuario", new { area = "Admin" });
			}
			return View();
		}

		[HttpGet]
		public ActionResult Alterar(int id)
		{
			var usuarioServicoBd = new UsuarioService(contextBd);
			var usuario = usuarioServicoBd.BuscarPorCodigo(id);
			if (usuario == null)
			{
				return RedirectToAction("Index");
			}
			return View(usuario);
		}

		[HttpPost]
		public ActionResult Alterar(Usuario usuario)
		{
			var usuarioServicoBd = new UsuarioService(contextBd);
			if (ModelState.IsValid)
			{
				usuarioServicoBd.Alterar(usuario);
				contextBd.SaveChanges();
				return RedirectToAction("Index", "Usuario", new { area = "Admin" });
			}
			return View();
		}

		[HttpGet]
		public ActionResult Excluir(int id)
		{
			if (id > 0)
			{
				var usuarioService = new UsuarioService(contextBd);
				var usuario = usuarioService.BuscarPorCodigo(id);
				if (usuario == null)
				{
					return RedirectToAction("Index");
				}
				return View(usuario);
			}
			return RedirectToAction("Index");
		}

		[HttpPost]
		public ActionResult Excluir(Usuario usuario)
		{
			if (usuario == null)
			{
				return RedirectToAction("Index");
			}
			var usuarioServicoBd = new UsuarioService(contextBd);
			usuarioServicoBd.Excluir(usuario.Id);
			contextBd.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}