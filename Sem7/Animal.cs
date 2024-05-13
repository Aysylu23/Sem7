using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sem7
{
    public class Animal
    {
        public string Name { get => name; }
        public int Age { get => age; }
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }

    public class Cat : Animal
    {
        //явное преобразование, явное приведение типов
        public static explicit operator Dog(Cat cat)
        {
            return new Dog(cat.Name, cat.Age);
        }
        //неявное преобазование, неявное приведение типов
        public static implicit operator Cat(Dog dog)
        {
            return new Cat(dog.Name, dog.Age);
        }
        public string Meow()
        {
            return " Meow ";
        }

        public Cat(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

    }
    public class Dog : Animal
    { 
       
        public string Woof()
        {
            return " Meow ";
        }
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

    }
}







