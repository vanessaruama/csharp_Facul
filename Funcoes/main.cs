using System;

class Program {
  public static double Soma(double num1, double num2) {
    double resultado;
    resultado=num1+num2;

    return resultado;
  }
  public static double Sub(double num1, double num2) {
    double resultado;
    resultado=num1-num2;

    return resultado;
  }
  public static double Div(double num1, double num2) {
    double resultado;
    resultado=num1/num2;

    return resultado;
  }
  
  public static double Multi(double num1, double num2) {
    double resultado;
    resultado=num1*num2;

    return resultado;
  }
  
  public static double Calculadora(double num1, double num2, string operacao) {
    double resultado = 0;
    
    /*if (operacao == "soma"){
    resultado = Soma(num1,num2);
  } else if (operacao == "multiplicação"){
    resultado = Multi(num1,num2);   
  } else if (operacao == "subtração"){
    resultado = Sub(num1,num2);   
  } else if (operacao == "divisão"){
    resultado = Div(num1,num2);
    }*/
    switch (operacao){
      case "soma":
      case "+":
        resultado = Soma(num1,num2);
        break;
      case "multiplicação":
      case "*":
        resultado = Multi(num1,num2);
        break;
      case "subtração":
      case "-":
        resultado = Sub(num1,num2);
        break;
      case "divisão":
      case "/":
        resultado = Div(num1,num2);
        break;
      default:
        resultado = 0;
        break;
    }
    return resultado;
  }
  
  public static void Main (string[] args) {
    double n1, n2;
    string operacao;
    double resultado;
    Console.WriteLine ("Digite um número: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Digite outro número: ");
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Digite a operação desejada: \n[soma (+), multiplicação (*), divisão (/), subtração (-)]");
    operacao = Console.ReadLine();
    //Console.WriteLine ("Soma: " +Soma(n1,n2));
    //Console.WriteLine ("Subtração:" +Sub(n1,n2));
    //Console.WriteLine ("Divisão:" +Div(n1,n2));
    //Console.WriteLine ("Multiplicaao:" +Multi(n1,n2));
    resultado = Calculadora(n1,n2,operacao);
    Console.WriteLine("Resultado: "+ resultado);
  }
}