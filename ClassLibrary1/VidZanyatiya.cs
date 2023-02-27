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
