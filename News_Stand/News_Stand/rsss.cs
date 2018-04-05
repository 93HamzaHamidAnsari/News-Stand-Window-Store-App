using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Stand
{
    class rsss
    {
        private List<feeditem> _item = new List<feeditem>();
        public List<feeditem> item
        {
            get { return this._item; }
        }


        public class feeditem
        {
            public string title { set; get; }
            public string content { set; get; }
            public string author { set; get; }
            public DateTime pubdate { set; get; }
            public Uri link { set; get; }
        }
    }
}
