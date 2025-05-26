using System;

public class Diff_bw_Const_ReadOnly
{
    public readonly int x_readonly = 10; // run-time constant
    public const int y_const = 20;// compile-time constant 

    public Diff_bw_Const_ReadOnly()
	{
        Console.WriteLine("The difference between Const and Readonly \n");

        Console.WriteLine("=========================================== \n\n");
        Console.WriteLine("Const is a compile-time constant, Readonly is a run-time constant \n");
        Console.WriteLine("Const value cannot be changed. Readonly value can be changed in the constructor \n");

        x_readonly = 30;
    }
}
