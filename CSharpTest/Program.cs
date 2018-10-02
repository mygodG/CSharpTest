using System;

namespace CSharpTest
{
    class Human
    {
        public void SetName(string str)
        {
            name = str;
        }

        public string GetName()
        {
            return name;
        }

        public virtual void ShowName()
        {
            Console.WriteLine("The human's name is "+GetName());
        }

        public static Human operator+ (Human h1, Human h2)
        {
            Human h3 = new Human();
            h3.SetName(h1.GetName()+h2.GetName());
            return h3;
        }

        private string name;
    }

    class Man : Human
    {
        public Man(string str)
        {
            SetName(str);
        }

        public override void ShowName()
        {
            Console.WriteLine("The man's name is "+GetName());
        }
    }

    class Woman : Human
    {
        public Woman(string str)
        {
            SetName(str);
        }

        public override void ShowName()
        {
            Console.WriteLine("The women's name is "+GetName());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Man m1 = new Man("GayGay");
            m1.ShowName();
            Woman wm1 = new Woman("Monkey");
            wm1.ShowName();

            Human father = new Human();
            Human mother = new Human();
            father.SetName("Peter");
            mother.SetName("Ana");
            Human child = father + mother;
            child.ShowName();

            Console.WriteLine("Something change");
        }
    }
}
