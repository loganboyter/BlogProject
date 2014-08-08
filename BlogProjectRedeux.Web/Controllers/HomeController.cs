using BlogProjectRedeux.Data;
using BlogProjectRedeux.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProjectRedeux.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<BlogPost> BlogPosts = Db.BlogPosts.ToList();
            return View(BlogPosts);
        }
        [HttpPost]
        public ActionResult CreateBlogPost(string title, string content)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.BlogPosts.Add(new BlogPost(title, content));
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditBlogPost(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            BlogPost BlogPost = Db.BlogPosts.Where(b => b.Id == id).FirstOrDefault();
            return View(BlogPost);
        }
        [HttpPost]
        public ActionResult EditBlogPost(string title, string content, int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.BlogPosts.Where(b => b.Id == id).FirstOrDefault().Title = title;
            Db.BlogPosts.Where(b => b.Id == id).FirstOrDefault().Content = content;
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlogPost(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.BlogPosts.Remove(Db.BlogPosts.Where(b => b.Id == id).FirstOrDefault());
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}