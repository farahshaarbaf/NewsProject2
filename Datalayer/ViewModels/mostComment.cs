using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public class mostComment
    {
        public int PageID { get; set; }
        public int GroupID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public int Visit { get; set; }
         public string ImageName { get; set; }
         public bool ShowInSlider { get; set; }
        public DateTime CreateDate { get; set; }
        public string Tags { get; set; }
         public string Video { get; set; }
        public bool ShowInVideo { get; set; }
        public int CommendCount { get; set; }
    }
}
