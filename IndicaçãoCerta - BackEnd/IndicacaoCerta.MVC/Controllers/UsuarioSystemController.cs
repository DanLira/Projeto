using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndicacaoCerta.Infra.Data.Repositorio;
using AutoMapper;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.MVC.ViewModels;

namespace IndicacaoCerta.MVC.Controllers
{
    public class UsuarioSystemController : Controller
    {
        private readonly UsuarioSystemRepositorioBase _usuarioSystemRepositorio = new UsuarioSystemRepositorioBase();

        // GET: UsuarioSystem
        public ActionResult Index()
        {
            var usuarioSystemViewModel = Mapper.Map<IEnumerable<UsuarioSystem>, IEnumerable<UsuarioSystemViewModel>>(_usuarioSystemRepositorio.GetAll());
            return View(usuarioSystemViewModel);
        }

        // GET: UsuarioSystem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioSystem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioSystem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioSystemViewModel usuarioSystem )
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioSystemViewModel, UsuarioSystem>(usuarioSystem);
                _usuarioSystemRepositorio.Add(usuarioDomain);

                return RedirectToAction("Index");
            }
            return View(usuarioSystem);
        }

        // GET: UsuarioSystem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioSystem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioSystem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioSystem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
