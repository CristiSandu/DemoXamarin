using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        //public string IconSource { get; set; }
        public int Size { get; set; }

        public Type TargetType { get; set; }
    }
}
