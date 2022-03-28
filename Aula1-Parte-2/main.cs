using System;

class Program {
  public static void Main (string[] args) {
    /*for(int i=0; i<2; i++){
    Console.WriteLine ("Hello World");
    }

    int qtdItens;
    float valorTotal = 0;
    int numItem = 1;

    Console.WriteLine("Quantos itens você quer adicionar no carrinho?");
    qtdItens = Convert.ToInt32(Console.ReadLine());

    for (int i=0; i<qtdItens; i++) {
      Console.WriteLine("Qual o valor do item {0}:", numItem);
      valorTotal += float.Parse(Console.ReadLine());
      numItem+= 1;
    }

    Console.WriteLine("O total da compra é de R${0}", valorTotal);
  */
    string nome;
    int contador = 0;
    /*Console.WriteLine("Digite um nome:");
    nome = Console.ReadLine();

    while (nome!="Ruama" && contador < 5)
    {
      Console.WriteLine("Digite um nome:");
      nome = Console.ReadLine();
      contador++;
    }*/

    do {
      Console.WriteLine("Digite um nome:");
      nome = Console.ReadLine();
      contador++;
    } while (nome!="Ruama" && contador < 5);
  
  }
}