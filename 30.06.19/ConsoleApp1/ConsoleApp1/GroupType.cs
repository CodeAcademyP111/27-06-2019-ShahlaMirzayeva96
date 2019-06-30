using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class GroupType
    {
        private static int ID;
        public string Type { get; set; }

        public GroupType(string type)
        {
            ID++;
            Type = type;
         

        }
    }
}
