using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        string name;
        int age;
        Char gender;
        public Person(string _name, int _age, char _gender)
        {
           name = _name;
            age = _age;
            gender = _gender;
        }
        public override string ToString()
        {
            return $"Name:{name}, Age:{age}, Gender:{gender}";
        }

    }
}
