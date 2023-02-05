using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int TreeHeight { get; set; }

        public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday }
    }
}
