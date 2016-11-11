using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Books
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? PublisherId { get; set; }
        public DateTime? PublishDate { get; set; }
        public string ISBN { get; set; }
        public double? UnitPrice { get; set; }
        public string ContentDescription { get; set; }
        public string TOC { get; set; }
        public int? CategrayId { get; set; }
        public int? Clicks{get; set; }
    }
}
