using System;

class Program
{
    public static void Main(string[] args)
    {
        int primeiraNota;
        int segundaNota;
        int media;
        Console.WriteLine("Qual a primeira nota?");
        primeiraNota = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual a média?");
        media = Convert.ToInt32(Console.ReadLine());

        if (primeiraNota >= 0 && primeiraNota <= 100)
        {
          segundaNota = (media*2) - primeiraNota;
            Console.WriteLine(Convert.ToString(segundaNota));
        }
        else
        {
            Console.WriteLine("Valor da nota errado");
        }

    }
}