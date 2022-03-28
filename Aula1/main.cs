using System;

class Program {
  public static void Main (string[] args) {
    /*Console.WriteLine("Hello World");
    Console.Write("Algum coisa!");

    string resposta;
    Console.WriteLine("Digite seu nome!");
    resposta = Console.ReadLine();
    Console.WriteLine("Seu nome é: " + resposta);

    int idade;
    Console.WriteLine("Digite sua idade!");
    idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Sua idade é: " + idade);

    int idade2;
    string coletaIdade;
    coletaIdade = Console.ReadLine();
    idade2 = Convert.ToInt32(coletaIdade);*/

    int numero1;
    int numero2;
    int numero3;
    int maiorNumero;

    Console.WriteLine("Digite um número:");
    numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    numero2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite outro número:");
    numero3 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numero2){
      maiorNumero = numero1;
    }
    else {
      maiorNumero = numero2;
    }

    if (maiorNumero < numero3){
      maiorNumero = numero3;
    }
    
    Console.WriteLine("O maior número digitado é: "+ Convert.ToString(maiorNumero));

    //Outra forma
    /*int maiorFuncao;

    maiorFuncao = Math.Max(numero1, numero2);
    maiorFuncao = Math.Max(maiorFuncao, numero3);

    Console.WriteLine("O maior número digitado é: "+ Convert.ToString(maiorFuncao));*/

    //Usando switch
    string op;
    int resultado;

    Console.WriteLine("Digite uma operação");
    op = Console.ReadLine();

    switch(op){
      case "+":
      case "mais":
      case "soma":
              resultado = numero1+numero2;
              Console.WriteLine("Você escolheu Soma:" + Convert.ToString(resultado));
              break;
      case "*":
      case "vezes":
      case "multiplicação":
      case "multiplicacao":
              resultado = numero1*numero2;
              Console.WriteLine("Você escolheu Multiplicação:" + Convert.ToString(resultado));
              break;
      case "/":
      case "divisão":
      case "divisao":
              resultado = numero1/numero2;
              Console.WriteLine("Você escolheu Divisão:" + Convert.ToString(resultado));
              break;
      case "-":
      case "menos":
      case "subtração":
      case "subtracao":
              resultado = numero1-numero2;
              Console.WriteLine("Você escolheu Subtração:" + Convert.ToString(resultado));
              break;
      default:
              Console.WriteLine("Não entendi sua opção!");
              break;
    }
  }
}