using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FAQApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQApp.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext Context { get; set; }
        public HomeController(FAQContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index(string catsShown="All", string topsShown="All")
        {
            IQueryable<FAQ> query = Context.FAQs.Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID); ;
            List <FAQ> FAQs= query.ToList(); 
            if (catsShown == "gen" && topsShown=="js")
            {
                query = Context.FAQs.Where(q => (q.CategoryID == "gen" && q.TopicID == "js")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "gen" && topsShown == "cpp")
            {
                query = Context.FAQs.Where(q => (q.CategoryID == "gen" && q.TopicID == "cpp")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "gen" && topsShown == "All")
            {
                query = Context.FAQs.Where(q => (q.CategoryID == "gen")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "his" && topsShown == "js")
            {
                query = Context.FAQs.Where(q => (q.CategoryID == "his" && q.TopicID == "js")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "his" && topsShown == "cpp")
            {
                query = Context.FAQs.Where(q => (q.CategoryID == "his" && q.TopicID == "cpp")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "his" && topsShown == "All")
            {
                query = Context.FAQs.Where(q => (q.CategoryID == "his")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "All" && topsShown == "js")
            {
                query = Context.FAQs.Where(q => (q.TopicID == "js")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else if (catsShown == "All" && topsShown == "cpp")
            {
                query = Context.FAQs.Where(q => (q.TopicID == "cpp")).Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            else
            {
                query = Context.FAQs.Include(t => t.Topic).Include(c => c.Category).OrderBy(f => f.FAQID);
                FAQs = query.ToList();
            }
            return View(FAQs);
        }
    }
}
