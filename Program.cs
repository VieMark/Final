using System;
using System.Security.Cryptography;
namespace Final;

class Program
{
    static void Main(string[] args)
    {
        int [] Massiv = {1, 2, 4, 6, 12, 65, 2, -4, -10, 33, -9, 0};

        Console.WriteLine($"Задание 1: {Sum(Massiv)}");
        Console.WriteLine($"Задание 2: {Max_el(Massiv)}");
        Console.WriteLine($"Задание 3: {Reverse(Massiv)}");
        Console.WriteLine($"Задание 4: {Even_numbers(Massiv)}");
        Console.WriteLine($"Задание 5: {Negative_numbers(Massiv)}");
        int num = 2;
        Console.WriteLine($"Задание 6: Число {num} есть в массиве: {LinearSearch(Massiv, num)}");
        Console.WriteLine($"Задание 7: {Unfair_position(Massiv)}");
        Console.WriteLine($"Задание 8: Максимальное: {Max_el(Massiv)} , Минимальное: {Min_el(Massiv)}");
        Console.WriteLine($"Задание 9: {Sorted(Massiv)}");
        Console.WriteLine($"Задание 10: {Replacement(Massiv)}");
        
        
    }

    static int Sum(int [] massiv)
    {
        int res = 0;
        res= massiv.Sum();
        return res;
    }

    static int Max_el(int [] massiv)
    {
        int value = massiv.Max();
        return value;

    }
    static string Reverse(int [] massiv)
    {
        Array.Reverse(massiv);
        string res = "";
        foreach(int i in massiv)
        {
            string r = i.ToString();
            res = res + i + ", ";
            
        }
        return res;

    }
    
    static int Min_el(int [] massiv)
    {
        int value = massiv.Min();
        return value;

    }
    static string Even_numbers(int [] massiv)
    {
        string res = "";
        foreach(int i in massiv)
        {
            if(i%2 == 0)
            {
                string r = i.ToString();
                res = res + i + ", ";
            }
        }
        return res;
    }
    
    static bool LinearSearch(int [] massiv, int target) 
    {
        for (int i = 0; i < massiv.Length; i++) 
        {
            if (massiv[i] == target) 
            {
                return true;
            }
        }
        return false;
    }

    static string Unfair_position(int [] massiv)
    {
        int caunt = 0;
        string l = "";
        foreach(int i in massiv)
        {
            if (caunt % 2 != 0 )
            {
                l = l + i.ToString() + ", ";
                
            }
            caunt++;

        }
        return l;
    }

    static int Negative_numbers(int [] massiv)
    {
        int res = 0;
        foreach(int i in massiv)
        {
            if(i < 0)
            {
                res = res + i;
            }
        }
        return res;
    }

    static string Sorted(int [] massiv)
    {
        string Str = "";
        Array.Sort(massiv);
        foreach (int i in massiv)
        {
            string st_i = i.ToString();
            Str = Str + st_i + ", " ;
        }
        return Str;
    }
    static string Replacement(int [] massiv)
    {
        int count = 0;
        string res = "";
        foreach (int i in massiv)
        {
            if (i < 0) {
                massiv[count] = 0;
            }
            count++;
        }
        for (int i = 0; i<massiv.Length; i++)
        {
            string St = massiv[i].ToString();
            res = res + St + ", ";
        }
        return res;
    }
}
