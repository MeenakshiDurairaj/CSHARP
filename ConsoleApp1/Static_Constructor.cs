﻿using System;

public class Static_Constructor
{
    // Static constructor is called once per type, not per instance.
    static Static_Constructor()
    {
        // Static constructor is called only once, even if we create multiple instances of the class.
        Console.WriteLine("Static constructor called only once");
        Console.WriteLine("------------------------------------");//static constructor cannot take parameters
    }

    public Static_Constructor()
    {
        Console.WriteLine("Instance constructor called");
    }
}

