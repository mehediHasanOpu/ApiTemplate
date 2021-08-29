using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public int Parent_id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Order_level { get; set; }
        public double Commision_rate { get; set; }
        public string Banner { get; set; }
        public string Icon { get; set; }
        public int Featured { get; set; }
        public int Top { get; set; }
        public int Digital { get; set; }
        public string Slug { get; set; }
        public string Meta_title { get; set; }
        public string Meta_description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}
