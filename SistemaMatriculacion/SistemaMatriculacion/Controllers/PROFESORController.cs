﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaMatriculacion.Models;

namespace SistemaMatriculacion.Controllers
{
    public class PROFESORController : Controller
    {
        private Sistema_matriculacionEntities db = new Sistema_matriculacionEntities();

        // GET: PROFESOR
        public ActionResult Index()
        {
            return View(db.PROFESOR.ToList());
        }

        // GET: PROFESOR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROFESOR pROFESOR = db.PROFESOR.Find(id);
            if (pROFESOR == null)
            {
                return HttpNotFound();
            }
            return View(pROFESOR);
        }

        // GET: PROFESOR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PROFESOR/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROFESOR,NOMBRE_PROFESOR,APELLIDO_PROFESOR,FECHA_NACIMIENTO_PROFESOR,SEXO_PROFESOR,DIRECCION_PROFESOR,TELEFONO_PROFESOR")] PROFESOR pROFESOR)
        {
            if (ModelState.IsValid)
            {
                db.PROFESOR.Add(pROFESOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pROFESOR);
        }

        // GET: PROFESOR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROFESOR pROFESOR = db.PROFESOR.Find(id);
            if (pROFESOR == null)
            {
                return HttpNotFound();
            }
            return View(pROFESOR);
        }

        // POST: PROFESOR/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROFESOR,NOMBRE_PROFESOR,APELLIDO_PROFESOR,FECHA_NACIMIENTO_PROFESOR,SEXO_PROFESOR,DIRECCION_PROFESOR,TELEFONO_PROFESOR")] PROFESOR pROFESOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pROFESOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pROFESOR);
        }

        // GET: PROFESOR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROFESOR pROFESOR = db.PROFESOR.Find(id);
            if (pROFESOR == null)
            {
                return HttpNotFound();
            }
            return View(pROFESOR);
        }

        // POST: PROFESOR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PROFESOR pROFESOR = db.PROFESOR.Find(id);
            db.PROFESOR.Remove(pROFESOR);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
