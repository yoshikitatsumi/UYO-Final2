using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace United_Youth_Orchestra_with_MVC.Models
{
    public class Schoolyear
    {
        // This is the key
        public int Id { get; set; }
        // School year shoowing exact school year deleting 1-5.
        public bool Year6orEarlier { get; set; }
        public bool Year7 { get; set; }
        public bool Year8 { get; set; }
        public bool Year9 { get; set; }
        public bool Year10 { get; set; }
        public bool Year11 { get; set; }
        public bool Year12 { get; set; }
        public bool Year13 { get; set; }
        public bool Other { get; set; }

    }
}
