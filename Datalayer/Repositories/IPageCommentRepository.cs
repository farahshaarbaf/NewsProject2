using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public interface IPageCommentRepository
    {
        IEnumerable<PageComment> GetCommentByNewsId(int pageId);
        bool AddComment(PageComment comment);
    }
}
