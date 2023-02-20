using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class Specialnost
    {
        private readonly string name61;
        public string Name61 { get => name61; }
        private readonly string name62;
        public string Name62 { get => name62; }
        public Specialnost(string name61, string name62)
        {
            this.name61 = name61;
            this.name62 = name62;
        }
    }
}