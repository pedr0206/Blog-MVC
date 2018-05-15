using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAulaDavid.Models
{
    public class BlogPostRepo
    {
        List<BlogPost> blogPostsList = new List<BlogPost>();

        static BlogPostRepo blogPostRepoSingleton;
        public static BlogPostRepo Instance {
            get {
                if(blogPostRepoSingleton == null)
                {
                    blogPostRepoSingleton = new BlogPostRepo();
                }
                return blogPostRepoSingleton;
            }
        }

        private BlogPostRepo()
        {
            blogPostsList.Add(new BlogPost(1, "Titulo 1", "Content 10", new DateTime(2018, 05, 09), "Author1"));
            blogPostsList.Add(new BlogPost(2, "Titulo 2", "Content 2", new DateTime(2018, 05, 09), "Author2"));
            blogPostsList.Add(new BlogPost(3, "Titulo 3", "Content 3", new DateTime(2018, 05, 09), "Author1"));
            blogPostsList.Add(new BlogPost(4, "Titulo 4", "Content 4", new DateTime(2018, 05, 09), "Tripeiro Campeão"));
            blogPostsList.Add(new BlogPost(5, "Titulo 5", "Content 5", new DateTime(2018, 05, 09), "TTetra Campeão"));
        }

        public void Add(int id, string title, string content, DateTime createDate, string author)
        {
            blogPostsList.Add(new BlogPost(id, title, content, createDate, author));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return blogPostsList;
        }
    }
}
