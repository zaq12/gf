using PrismUnityApp3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityApp3.Constants
{
    public class Resourcelist
    {
        public ObservableCollection<Resource> resourcelist = new ObservableCollection<Resource>();
        public Resourcelist()
        {
           // resourcelist
            resourcelist.Add(new Resource("aaa","sss"));
            resourcelist.Add(new Resource("bbb","ddd"));
            //resourcelist.Add(new Resource("ccc"));
        }
    }
}
