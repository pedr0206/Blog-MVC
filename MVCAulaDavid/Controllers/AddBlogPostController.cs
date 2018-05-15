using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAulaDavid.Models;

namespace MVCAulaDavid.Controllers
{
    public class AddBlogPostController : Controller
    {

        // POST: AddBlogPost/Create
        [HttpPost]
        public ActionResult Index(string AuthorName)
        {
            ViewData["AuthorName"] = AuthorName;
            return View();
        }

        [HttpPost]
        public ActionResult Add(string ID, string Title, string Content, string CreateDate, string AuthorName)
        {
            BlogPostRepo.Instance.Add(int.Parse(ID), Title, Content, DateTime.Parse(CreateDate), AuthorName);
            return View("../ShowBlogPosts/Index",BlogPostRepo.Instance.GetBlogPosts());
        }
    }
}