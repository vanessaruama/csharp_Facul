using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    var random = new Random();
    var times = new List<string>();
    Console.WriteLine("Digite um time: ");
    times.Add(Console.ReadLine()); 
    Console.WriteLine("Digite outro time: ");
    times.Add(Console.ReadLine()); 
    Console.WriteLine("O time vencedor é: " + times[random.Next(times.Count)]);
  }
}