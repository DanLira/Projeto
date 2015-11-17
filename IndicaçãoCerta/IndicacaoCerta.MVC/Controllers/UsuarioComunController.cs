using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using IndicacaoCerta.Infra.Data.Repositorio;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.MVC.ViewModels;

namespace IndicacaoCerta.MVC.Controllers
{
    public class UsuarioComunController : Controller
    {
        private readonly UsuarioComunRepositorioBase _usuarioComunRepositorio = new UsuarioComunRepositorioBase();

        // GET: UsuarioComun
        public ActionResult Index()
        {
            var usuarioComunViewModel = Mapper.Map<IEnumerable<UsuarioComun>, IEnumerable<UsuarioComunViewModel>>(_usuarioComunRepositorio.GetAll());
            return View(usuarioComunViewModel);
        }

        // GET: UsuarioComun/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: UsuarioComun/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioComun/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioComunViewModel usuarioComun)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioComunViewModel, UsuarioComun>(usuarioComun);
                _usuarioComunRepositorio.Add(usuarioDomain);

                return RedirectToAction("Index");
            }
            return View(usuarioComun);
        }

        // GET: UsuarioComun/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioComun/Edit/5
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

        // GET: UsuarioComun/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioComun/Delete/5
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
