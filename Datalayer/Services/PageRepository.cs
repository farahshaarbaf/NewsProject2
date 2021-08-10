using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public class PageRepository : IPageRepository
    {
        private MyCmsContext db;

        public PageRepository(MyCmsContext context)
        {
            this.db = context;
        }
        public IEnumerable<Page> GetAllPage()
        {
            return db.Pages;
        }
        public IEnumerable<Page> GetPage(int take = 5)
        {
            return db.Pages.OrderByDescending(p => p.Visit).Take(take);
        }
        public Page GetPageById(int pageId)
        {
            return db.Pages.Find(pageId);
        }

        public bool InsertPage(Page page)
        {
            try
            {
                db.Pages.Add(page);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool UpdatePage(Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool DeletePage(Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool DeletePage(int pageId)
        {
            try
            {
                var page = GetPageById(pageId);
                DeletePage(page);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Page> TopNews(int take = 4)
        {
            return db.Pages.OrderByDescending(p => p.Visit).Take(take);
        }

        public IEnumerable<Page> PagesInSlider()
        {
            return db.Pages.Where(p => p.ShowInSlider == true);
        }

        public IEnumerable<Page> LastNews(int take = 4)
        {
            return db.Pages.OrderByDescending(p => p.CreateDate).Take(take);
        }

        public IEnumerable<Page> ShowPageByGroupId(int groupId)
        {

            return db.Pages.Where(p => p.GroupID == groupId);
        }


      

        public IEnumerable<Page> FooterGallery(int take = 6)
        {
            db.Pages.OrderByDescending(p => p.Visit);
            return db.Pages.OrderByDescending(p => p.PageID == 8).Take(take);
            ///return db.Pages.OrderByDescending(p => p.CreateDate).Take(take);

        }

        public IEnumerable<Page> HotNews(int take = 5)
        {
            db.Pages.OrderByDescending(p => p.Visit);
            return db.Pages.OrderByDescending(p => (DateTime.Now.Day-p.CreateDate.Day<=7)).Take(take);
        }

        public IEnumerable<Page> Newsofslider(int take = 4)
        {
            db.Pages.OrderByDescending(p => p.Visit);
            return db.Pages.OrderByDescending(p => p.CreateDate).Take(take);

        }
        public IEnumerable<Page> GetGroups(int take = 4)
        {
            db.Pages.OrderByDescending(p => p.CreateDate);
            return db.Pages.OrderByDescending(p => p.GroupID).Take(take);




        }
        public IEnumerable<Page> ShowNewByPageIdFav(int groupId, int take = 3)
        {
            return db.Pages.Where(p => p.GroupID == groupId).Take(take);

        }
        public IEnumerable<Page> SearchPage(string search)
        {
            return
                db.Pages.Where(
                    p =>
                        p.Title.Contains(search) || p.ShortDescription.Contains(search) ||
                        p.Tags.Contains(search) || p.Text.Contains(search)).Distinct();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Page> NextPage(int id, int group)
        {
            return db.Pages.Where(p => p.GroupID == group).OrderBy(p => p.PageID).Where(p => p.PageID> id).Take(1);
        }

        public IEnumerable<Page> LastPage(int id, int group)
        {
            return db.Pages.Where(p => p.GroupID == group).OrderByDescending(p => p.PageID).Where(p => p.PageID < id).Take(1);
        }

        public IEnumerable<Page> PagesInVideo()
        {
            return db.Pages.Where(p => p.ShowInVideo == true);
        }

        public IEnumerable<Page> RelatedPosts(string Tag)
        {
            return db.Pages.Where(p => p.Tags == Tag);
        }
    } 
}
