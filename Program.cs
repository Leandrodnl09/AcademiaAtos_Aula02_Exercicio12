using System.Drawing;
using System.Security.Cryptography;

namespace Aula02Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            // marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
            // dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.
            //    Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia

            // Média do consumo = Total quilometragem / quantidade de combustível gasto

            // Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            double marcacaoInicial, marcacaoFinal, litrosCombustivel, valorTotalRecebido;

            // Leitura dos valores de entrada
            Console.Write("Digite a marcação do odômetro no início do dia (em Km): ");
            marcacaoInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a marcação do odômetro no final do dia (em Km): ");
            marcacaoFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de litros de combustível gasto: ");
            litrosCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor total recebido dos passageiros (em R$): ");
            valorTotalRecebido = Convert.ToDouble(Console.ReadLine());

            // Cálculo dos valores
            double totalQuilometragem = marcacaoFinal - marcacaoInicial;
            double mediaConsumo = totalQuilometragem / litrosCombustivel;
            double lucroDia = valorTotalRecebido - (litrosCombustivel * 6.90);

            // Exibição dos resultados
            Console.WriteLine("Média de consumo: " + mediaConsumo.ToString("F2") + " Km/l");
            Console.WriteLine("Lucro líquido do dia: R$" + lucroDia.ToString("F2"));
        }
    }
}