namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Readonly are not static by default = " + new Diff_bw_Const_ReadOnly().x_readonly);
            Console.WriteLine("Const are static by default = "+ Diff_bw_Const_ReadOnly.y_const); 

            Console.WriteLine("================================================================================================= \n\n");

            Static_Constructor staticConstructor = new Static_Constructor();
            Static_Constructor staticConstructor1 = new Static_Constructor();




        }
    }
}
