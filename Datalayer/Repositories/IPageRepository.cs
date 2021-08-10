using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
   public interface IPageRepository : IDisposable
    {
        Page GetPageById(int pageId);
        bool InsertPage(Page page);
        bool UpdatePage(Page page);
        bool DeletePage(Page page);
        bool DeletePage(int pageId);
        void Save();

        IEnumerable<Page> GetAllPage();
        IEnumerable<Page> GetGroups(int take = 4);

        IEnumerable<Page> GetPage(int take = 5);

        IEnumerable<Page> TopNews(int take = 3);
        IEnumerable<Page> LastNews(int take = 3);
        IEnumerable<Page> HotNews(int take = 5);

        IEnumerable<Page> PagesInSlider();
        IEnumerable<Page> Newsofslider(int take = 4);


        IEnumerable<Page> ShowPageByGroupId(int groupId);
        IEnumerable<Page> ShowNewByPageIdFav(int groupId, int take = 3);


        IEnumerable<Page> FooterGallery(int take = 9);

        IEnumerable<Page> SearchPage(string search);

        IEnumerable<Page>NextPage(int id, int group);
        IEnumerable<Page> LastPage(int id, int group);
        IEnumerable<Page> PagesInVideo();

        IEnumerable<Page> RelatedPosts(string Tag);

        



    }
}
