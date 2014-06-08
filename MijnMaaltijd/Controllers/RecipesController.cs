using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MijnMaaltijd.Models;

namespace MijnMaaltijd.Controllers
{
    public class RecipesController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /Recipes/

        public ActionResult Index()
        {
            var recipes = db.Recipes.Include(r => r.Season).Include(r => r.Type);
            return View(recipes.ToList());
        }

        //
        // GET: /Recipes/Details/5

        public ActionResult Details(int id = 0)
        {
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        //
        // GET: /Recipes/Create

        public ActionResult Create()
        {
            ViewBag.SeasonID = new SelectList(db.Seasons, "ID", "Name");
            ViewBag.TypeID = new SelectList(db.Types, "ID", "Name");
            return View();
        }

        //
        // POST: /Recipes/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SeasonID = new SelectList(db.Seasons, "ID", "Name", recipe.SeasonID);
            ViewBag.TypeID = new SelectList(db.Types, "ID", "Name", recipe.TypeID);
            return View(recipe);
        }

        //
        // GET: /Recipes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            ViewBag.SeasonID = new SelectList(db.Seasons, "ID", "Name", recipe.SeasonID);
            ViewBag.TypeID = new SelectList(db.Types, "ID", "Name", recipe.TypeID);
            return View(recipe);
        }

        //
        // POST: /Recipes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SeasonID = new SelectList(db.Seasons, "ID", "Name", recipe.SeasonID);
            ViewBag.TypeID = new SelectList(db.Types, "ID", "Name", recipe.TypeID);
            return View(recipe);
        }

        //
        // GET: /Recipes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        //
        // POST: /Recipes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = db.Recipes.Find(id);
            db.Recipes.Remove(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}