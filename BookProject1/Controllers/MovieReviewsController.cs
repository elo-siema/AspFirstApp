using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookProject1.Models;

namespace BookProject1.Controllers
{
    public class MovieReviewsController : Controller
    {
        static List<MovieReviews> _movieReviews = new List<MovieReviews>
        {
            new MovieReviews
            {
                Id =               1,
                MovieName =        "Avatar",
                ReviewerName =     "Michal Flak",
                ReviewerComments = "Excellent",
                ReviewerRating =   5
            },
            new MovieReviews
            {
                Id =                2,
                MovieName =         "Dzango",
                ReviewerName =      "Michal Flak",
                ReviewerComments =  "Poor",
                ReviewerRating =    4
            },
            new MovieReviews
            {
                Id =               3,
                MovieName =        "Szkola",
                ReviewerName =     "Michal Flak",
                ReviewerComments = "Excellent",
                ReviewerRating =   3
            }
        };
        //
        // GET: /MovieReviews
        public ActionResult Index()
        {
            var model = from m in _movieReviews
                        orderby m.MovieName
                        select m;
            return View(model);
        }

        //
        //GET: /MovieReviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        //GET: /MovieReviews/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        //POST: /MovieReviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //TODO: Insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        //GET: /MovieReviews/Edit/5

        public ActionResult Edit(int id)
        {
            var movieReview = _movieReviews.Single(m => m.Id == id);
            return View(movieReview);
        }

        //
        //POST: /MovieReviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //TODO: Add logic
                var movieReview = _movieReviews.Single(m => m.Id == id);
                if (TryUpdateModel(movieReview))
                {
                    return RedirectToAction("Index");
                }
                return View(movieReview);
            }

            catch
            {
                return View();
            }
        }

        //
        //GET: /MovieReviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        //POST: /MovieReviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                //TODO: Add logic

                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }

        public ActionResult bestReviews()
        {
            var movieReview = from m in _movieReviews
                              orderby m.ReviewerRating descending
                              select m;
            return PartialView("_movieReviews", movieReview.First());
        }
    }
}