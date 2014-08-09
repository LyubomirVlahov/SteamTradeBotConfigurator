using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    public class DBItem
    {
        private string name;
        private int def;

        public string Name { get { return name; } set { name = value; } }
        public int Def { get { return def; } set { def = value; } }

        public DBItem(string name, int def)
        {
            this.name = name;
            this.def = def;
        }
    }
}
