using System;

public class MathHelper
{
    public static double ObliczSrednia(int[] tablica)
    {
        if (tablica == null || tablica.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niepoprawna.");
        }

        int suma = 0;
        foreach (int liczbaaa in tablica)
        {
            suma += liczbaaa;
        }

        double srednia = (double)suma / tablica.Length;
        return srednia;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] tablicaLiczb = { 1, 2, 3, 4, 5 };
        double srednia = MathHelper.ObliczSrednia(tablicaLiczb);
        Console.WriteLine("Średnia: " + srednia);
    }
}