using System;

class Program {
  public static void Main (string[] args) {
    
    string cpf;
    int contador = 10;
    int somaNum = 0;
    int posicao = 0;
    int restoDiv;
    int primeiroDig;
    int segundoDig;

    Console.WriteLine("Digite os 9 primeiros números do seu CPF e eu descobrirei os 2 últimos dígitos:");
    cpf = Console.ReadLine();
    cpf = cpf.Replace(".","").Replace("-", "");

    Console.WriteLine(cpf);

    if (cpf.Length != 9){
      Console.WriteLine("Você não digitou corretamente");
    } else {
      //Primeiro Dígito
      for (int i=0; i<9; i++)
      {
        somaNum += Convert.ToInt32(cpf.Substring(posicao, 1)) * contador;
        contador--;
        posicao++;
      }

      restoDiv = somaNum%11;
      
      if (restoDiv < 2) {
        primeiroDig = 0;
      } else {
        primeiroDig = 11-restoDiv;
      }

      cpf += Convert.ToString(primeiroDig);

      //Segundo Dígito
      contador = 11;
      posicao = 0;
      somaNum = 0;

      for (int i=0; i<10; i++)
      {
        somaNum += Convert.ToInt32(cpf.Substring(posicao, 1)) * contador;
        contador--;
        posicao++;
      }

      restoDiv = somaNum%11;
      
      if (restoDiv < 2) {
        segundoDig = 0;
      } else {
        segundoDig = 11-restoDiv;
      }

      cpf += Convert.ToString(segundoDig);

      Console.WriteLine("Os últimos digitos são {0} e {1}", primeiroDig, segundoDig);
      Console.WriteLine("Seu CPF completo é: " + Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00"));
    }
  }
}