using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public interface IPageGroupRepository : IDisposable
    {
        IEnumerable<PageGroup> GetAllGroups();
        IEnumerable<PageGroup> GetFavorite(int take = 4);


        PageGroup GetGroupById(int groupId);
        bool InsertGroup(PageGroup pageGroup);
        bool UpdateGroup(PageGroup pageGroup);
        bool DeleteGroup(PageGroup pageGroup);
        bool DeleteGroup(int groupId);
        void save();
       IEnumerable<ShowGroupViewModel> GetGroupsForView();


    }
}
