using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod6
{
    public class Blog: WebSite
    {
        
        public override void createWebsite()
        {
            pages.Add(new PostPage());
            pages.Add(new AboutPage());
            pages.Add(new CommentPage());
            pages.Add(new ContactPage());
        }
    }
}
