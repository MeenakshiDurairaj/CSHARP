namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Readonly are not static by default = " + new Diff_bw_Const_ReadOnly().x_readonly);
            Console.WriteLine("Const are static by default = "+ Diff_bw_Const_ReadOnly.y_const); 
            
            
        }
    }
}
