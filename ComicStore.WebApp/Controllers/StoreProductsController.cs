﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ET.ComicStore.Library;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComicStore.WebApp.Controllers
{
    public class StoreProductsController : Controller
    {


        public FrameworkRepo ComicDB { get; set; }


        public StoreProductsController(FrameworkRepo comicDB)
        {
            ComicDB = comicDB;
        }


        // GET: StoreProducts
        public ActionResult Index()
        {
            var stores = ComicDB.GetStores();

            return View();
        }

        // GET: StoreProducts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreProducts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreProducts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreProducts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreProducts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreProducts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}