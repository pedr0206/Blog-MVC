using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAulaDavid.Models;

namespace MVCAulaDavid.Controllers
{
    public class ShowBlogPostsController : Controller
    {
        // GET: ShowBlogPosts
        [HttpGet]
        public ActionResult Index()
        {
            List<BlogPost> blogPostsList = BlogPostRepo.Instance.GetBlogPosts();
            

            return View(blogPostsList);
        }

        [HttpPost]
        public ActionResult Index(string AuthorName)
        {
            List<BlogPost> authorPostList = new List<BlogPost>();
            List<BlogPost> blogPostsList = BlogPostRepo.Instance.GetBlogPosts();


            foreach (BlogPost blogPost in blogPostsList)
            {
                if(blogPost.Author == AuthorName)
                {
                    authorPostList.Add(blogPost);
                }
            }

            return View(authorPostList);
        }
    }
}