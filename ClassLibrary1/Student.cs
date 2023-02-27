using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string familia;
        public string Familia { get => familia; }
        private readonly string otchestvo;
        public string Otchestvo { get => otchestvo; }

        private readonly Gryppa gryppa;
        public Gryppa Gryppa { get => gryppa; }

        public int Data { get => data; }
        private readonly int data;

        public Student(string name, string familia, string otchestvo, Gryppa gryppa, int data)
        {
            this.name = name;
            this.familia = familia;
            this.otchestvo = otchestvo;
            this.gryppa = gryppa;
            this.data = data;
        }
    }
}
