using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAulaDavid.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatDate { get; set; }
        public string Author { get; set; }

        public BlogPost(int id, string title, string content, DateTime createDate, string author)
        {
            ID = id;
            Title = title;
            Content = content;
            CreatDate = createDate;
            Author = author;


        }

    }
}
