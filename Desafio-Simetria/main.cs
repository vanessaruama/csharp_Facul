//http://maratona.sbc.org.br/hist/2019/resultados19/warmup/pdf-warmup/warmup_onesided.pdf
using System;

class Program {
  public static void Main (string[] args) {
    double angulo;
    double resto;
    double resultado = 360;
    double soma = 360;
    double inicial = 1;

    Console.WriteLine("Qual ângulo rotacional da pizza?");
    angulo = Convert.ToDouble(Console.ReadLine());

    if (angulo > 0 && angulo <= 360) {     
      resto = 360%angulo;
      if (resto > 0) {;
        for (inicial = 1; resto > 0; inicial++)
      {
        resto = resultado%angulo;
        resultado = resultado+360;
        Console.WriteLine("Teste Result: " + resultado);      
        Console.WriteLine("Teste Resto: " + resto);
      }  
        Console.WriteLine("Fatias: " + inicial);
      } else {
        resultado = 360/angulo;
        Console.WriteLine("Fatias: " + resultado);
      }
    } else {
      Console.WriteLine("Ângulo errado");
    }
  }
}