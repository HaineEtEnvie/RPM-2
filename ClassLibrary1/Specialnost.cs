using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class Specialnost
    {
        private readonly string name;
        public string Name6{ get => name; }
        private readonly string reduction;
        public string Reduction { get => reduction; }
        public Specialnost(string name, string reduction)
        {
            this.name = name;
            this.Reduction = reduction;
        }
    }
}
