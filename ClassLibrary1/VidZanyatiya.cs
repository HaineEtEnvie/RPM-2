// https://docs.google.com/document/d/1mwSWGxZfPEK4Ysyh9TJ4A_Ym1bew2ttNGWbMpK9y_zc/edit
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VidZanyatiya
    {
        private readonly string name;
        public string Name { get => name; }
        public VidZanyatiya(string name)
        {
            this.name = name;
        }
    }
}
