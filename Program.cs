using System;

namespace exercicio3
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string produto;
            int quantidadeProduto;
            float precoProduto;
            float totalpreco1;
            float resultado1;
            float resultado2;
            float totalFinal;
            string desconto;

            Console.WriteLine("Adicione o nome do produto adquirido:");
            produto = Console.ReadLine();
            Console.WriteLine($"Acrescente valor unitário do(a) {produto}:");
            precoProduto = float.Parse(Console.ReadLine());
            Console.WriteLine($"Adicione a quantidade adquirida de {produto}:");
            quantidadeProduto = int.Parse(Console.ReadLine());
            totalpreco1 = quantidadeProduto*precoProduto;
            

            if (quantidadeProduto <=5)
            {
              resultado1 = totalpreco1/100;
              resultado2 = resultado1*2;
              totalFinal =  totalpreco1 - resultado2;
              desconto = "2%";
            }
            else if (quantidadeProduto >5 && quantidadeProduto <=10)
            {
              resultado1 = totalpreco1/100;
              resultado2 = resultado1*3;
              totalFinal =  totalpreco1 - resultado2;
              desconto = "3%";
            }
            else
            {
              resultado1 = totalpreco1/100;
              resultado2 = resultado1*5;
              totalFinal = totalpreco1 - resultado2;
              desconto = "5%";
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Valor da compra: {totalpreco1}$ \nDesconto de: -{desconto} \nTotal a pagar: {totalFinal}$");
            

        }
    }
}
