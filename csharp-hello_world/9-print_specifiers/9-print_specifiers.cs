﻿using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        var culture = new CultureInfo("en-US");
        Console.WriteLine("Percent: {0:P2}", percent);
        Console.WriteLine("Currency: {0:C2}", currency.ToString("C2", culture));
    }
}
