﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SiegeNut.Models;
using Microsoft.AspNet.Identity;
using PagedList;

namespace SiegeNut.Controllers
{
    public class ReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reviews
        public ActionResult Index(string sortOrder, string currentField, string currentSearch, string searchString, string searchField, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.ProductSortParm = String.IsNullOrEmpty(sortOrder) ? "product_desc" : "Product";
            ViewBag.ProductSortParm = sortOrder == "Product" ? "product_desc" : "Product";
            ViewBag.RatingSortParm = sortOrder == "Rating" ? "rating_desc" : "Rating";
            ViewBag.AuthorSortParm = sortOrder == "Author" ? "author_desc" : "Author";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.CurrentField = searchField;
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchField = currentField;
                searchString = currentSearch;
            }
            ViewBag.CurrentField = searchField;
            ViewBag.CurrentSearch = searchString;

            var reviews = db.Reviews.Include(r => r.Author).Include(r => r.Product);
            if (!String.IsNullOrEmpty(searchString))
            {
                
                switch (searchField)
                {
                    case "Product":
                        reviews = reviews.Where(r => r.Product.Name.Contains(searchString)
                                       || r.Product.Name.Contains(searchString));
                        break;
                    case "Rating":
                        int searchNumber;
                        int.TryParse(searchString, out searchNumber);
                        reviews = reviews.Where(r => searchNumber == r.Rating);
                        break;
                    case "Author":
                        reviews = reviews.Where(r => r.Author.UserName.Contains(searchString)
                                       || r.Author.UserName.Contains(searchString));
                        break;
                }
            }
            switch (sortOrder)
            {
                case "Product":
                    reviews = reviews.OrderBy(r => r.Product.Name);
                    break;
                case "product_desc":
                    reviews = reviews.OrderByDescending(r => r.Product.Name);
                    break;
                case "Rating":
                    reviews = reviews.OrderBy(s => s.Rating);
                    break;
                case "rating_desc":
                    reviews = reviews.OrderByDescending(s => s.Rating);
                    break;
                case "Author":
                    reviews = reviews.OrderBy(s => s.Author.UserName);
                    break;
                case "author_desc":
                    reviews = reviews.OrderByDescending(s => s.Author.UserName);
                    break;
                case "Date":
                    reviews = reviews.OrderBy(s => s.DateWritten);
                    break;
                case "date_desc":
                    reviews = reviews.OrderByDescending(s => s.DateWritten);
                    break;
                default:
                    reviews = reviews.OrderBy(s => s.Product.Name);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(reviews.ToPagedList(pageNumber, pageSize));
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            review.Product = db.Products.Find(review.ProductID);
            review.Author = db.Users.Find(review.AuthorID);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(db.Products, "ID", "Name");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProductID,Rating,Title,DateWritten,MainText,AuthorID")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.DateWritten = DateTime.Now;
                review.AuthorID = User.Identity.GetUserId();
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            ViewBag.ProductID = new SelectList(db.Products, "ID", "Name", review.ProductID);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            if (User.Identity.GetUserId() == review.AuthorID)
            {
                ViewBag.ProductID = new SelectList(db.Products, "ID", "Name", review.ProductID);
                return View(review);
            }
            return RedirectToAction("Index");
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProductID,Rating,Title,DateWritten,MainText,AuthorID")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.AuthorID = User.Identity.GetUserId();
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(db.Products, "ID", "Name", review.ProductID);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            review.Product = db.Products.Find(review.ProductID);
            review.Author = db.Users.Find(review.AuthorID);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
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
