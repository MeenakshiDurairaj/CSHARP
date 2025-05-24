namespace ConsoleApp1
{
    class Parent
    {
        public readonly int x_readonly = 10; // run-time constant
        public const int y_const = 20;// compile-time constant
        public Parent()
        {
            x_readonly = 30;
            //y_const = 40; // error: cannot assign to 'y_const' because it is a constant
            Console.WriteLine("Parent constructor called");
        }
        public virtual void display()
        {
            //y_const = 50; // error: cannot assign to 'y_const' because it is a constant
             //x_readonly = 30; // error: cannot assign to 'x_readonly' because it is readonly
            Console.WriteLine("Parent class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The difference between Const and Readonly \n");
            Console.WriteLine("Const is a compile-time constant, Readonly is a run-time constant \n");
            Console.WriteLine("Const value cannot be changed. Readonly value can be changed in the constructor \n");
            Console.WriteLine("Const are static by default = "+Parent.y_const); // const are static by default
            Console.WriteLine("Readonly are not static by default = " + new Parent().x_readonly); // readonly are not static by default
            /*Parent p = new Parent();
            p.display();*/
            Console.WriteLine("Hello, World!");
        }
    }
}
