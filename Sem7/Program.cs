using System.Reflection;
using System.Text;

namespace Sem7
{
    internal class Program
    {
        static string ObjectToString(object obj) 
        {
            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();

            sb.Append(type.AssemblyQualifiedName);
            sb.Append(type.Name + "\n");
            var fields = type.GetFields();

            foreach ( var field in fields)
            {
                sb.Append($"{field.Name}|{field.FieldType}|{field.GetValue(obj)}\n");
           
            }


            return sb.ToString();
        }

        public static object StringToObject(string str) 
        {
            string[] strings = str.Split(new char[] { '\n' });
            PropertyInfo[] properties = new PropertyInfo[strings.Length];
            
            for ( int i = 2; i < strings.Length; i++ )
            {
                string[] s = strings[i].Split(new char[] { '|' });
                
                var obj = Activator.CreateInstance(null, s[1]).Unwrap();

               Console.Write(obj.GetType);
            }

            return null;
        }
        static void Main(string[] args)
        {
            TestClass test = new TestClass(1, "hello", 2.0m,'%');

            string str = ObjectToString(test);
            Console.WriteLine(str);

            object obj = StringToObject(str);
            
           
            
            
            
            
            
            /*  Type type = typeof(Program);

              if (Type.GetTypeCode(type) == TypeCode.String)
                  Console.WriteLine("Строковый тип");

              if (type.IsArray)
                  Console.WriteLine("Тип массива");

              if(type.IsClass || type.IsInterface)
                  Console.WriteLine("Ссылочный");

              if (type.IsPrimitive || type.IsEnum)
                  Console.WriteLine("Примитивный");

              if (type.IsValueType)
                  Console.WriteLine("Cтруктура");

              */

            /*Animal animal = new Animal("Bubenchik", 6);
            Cat cat = new Cat("Vasya", 3);
            Dog dog = new Dog("Jhon", 1);

            cat.Meow();
            dog.Woof();

            Animal tt = new Dog("Kitty", 1); //неявное преобразование
            
            Type type = tt.GetType();

            ((Dog)cat).Woof(); 

            Cat cat2 = new Dog("hjhfd", 1); //явное преобразование

            Console.WriteLine(type);



            Console.WriteLine(type);*/
            
            /*Type t = typeof(TestClass); //тип класса
            
            var t1 = Activator.CreateInstance(t); //запустили конструктор внутри него и записали все в обьект

            Console.WriteLine(((TestClass)t1).I);*/




        }

        class TestClass
        {
            public int I;
            public string S;
            public decimal D;
            public char C;

            public TestClass() { }

            public TestClass(int i) { this.I = i; }

            public TestClass(int i, string s, decimal d, char c)
            {
                this.I = i;
                this.S = s;
                this.D = d;
                this.C = c;
            }
        }

    }

}
