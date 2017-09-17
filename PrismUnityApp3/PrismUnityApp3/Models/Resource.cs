using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityApp3.Models
{
    public class Resource
    {
        public Resource(string name,string link)
        {
            this.Names = name;
            this.Link = link;
        }

        public string Names { get; set; }
        public string Link { get; set; }
       
    }
}
