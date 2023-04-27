using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque {
    internal class Principal {

        static void Main(string[] args)
        {
            //Entrada de Dados
            Console.WriteLine("APRESENTAÇAO DE ESTOQUE.");
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite o Nome, Preço e Quantidade!.");
            Dados dados = new Dados();

            //Entrada do nome
            Console.Write("Digite o Nome: ");
            dados.nome = PrimeiraLetraMaiuscula.Primeira_LetraMaiuscula(Console.ReadLine());

            //Entrada da preço
            Console.Write("Digite o Preço: ");
            dados.preco = decimal.Parse(Console.ReadLine());

            //Entrada da quantidade
            Console.Write("Digite a Quantidade: ");
            dados.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("//////////////////////////////");

            //Exibição de dados
            Console.WriteLine("(EXIBIÇAO DE DADOS)");
            Console.WriteLine("Nome do produto: " + dados.nome);
            Console.WriteLine("Preço do produto: " + dados.preco);
            Console.WriteLine("Quantidade do produto: " + dados.quantidade);
            Console.WriteLine("//////////////////////////////");

            //Interação para alterar dados
            Console.Write("Deseja alterar algum Dado do Produto? Sim/Não: ");
            string resposta = Console.ReadLine();
            resposta = RemoverAcentos.Remover(resposta);

            //Condiçao sim
            switch (resposta)
            {
                case "sim":
                    Console.Write("Qual dado você deseja alterar? Nome, Preço ou Estoque: ");
                    string escolha = RemoverAcentos.Remover(Console.ReadLine());
                    Console.WriteLine("//////////////////////////////");

                    //Opçao nome
                    switch (escolha)
                    {
                        case "nome":
                            Console.WriteLine("A opção escolhida foi (Nome).");
                            Console.WriteLine("//////////////////////////////");
                            Console.Write("Digite o novo nome: ");
                            dados.nome = PrimeiraLetraMaiuscula.Primeira_LetraMaiuscula(Console.ReadLine());
                            Console.WriteLine("Nome alterado com sucesso!");
                            Console.WriteLine("(EXIBIÇAO DE DADOS)");
                            Console.WriteLine("Nome do produto: " + dados.nome);
                            Console.WriteLine("Preço do produto: " + dados.preco);
                            Console.WriteLine("Quantidade do produto: " + dados.quantidade);
                            Console.WriteLine("//////////////////////////////");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }
                    switch (escolha)
                    {
                        case "preco":
                            Console.WriteLine("A opção escolhida foi (Preço).");
                            Console.Write("Deseja somar ou subtrair um valor do Preço?: ");
                            string acao_preço = RemoverAcentos.Remover(Console.ReadLine());

                            switch (acao_preço)
                            //Condiçao somar
                            {
                                case "somar":
                                    Console.WriteLine("//////////////////////////////");
                                    Console.WriteLine("A opção escolhida foi (Somar).");
                                    Console.Write("Digite o valor que deseja adicionar: ");
                                    decimal adi = decimal.Parse(Console.ReadLine());
                                    dados.preco = dados.preco + adi;
                                    Console.WriteLine("//////////////////////////////");

                                    Console.WriteLine("Preço alterado com sucesso!");
                                    Console.WriteLine("(EXIBIÇAO DE DADOS)");
                                    Console.WriteLine("Nome do produto: " + dados.nome);
                                    Console.WriteLine("Preço do produto: " + dados.preco);
                                    Console.WriteLine("Quantidade do produto: " + dados.quantidade);
                                    Console.WriteLine("//////////////////////////////");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                    break;

                                case "subtrair":
                                    Console.WriteLine("//////////////////////////////");
                                    Console.WriteLine("A opção escolhida foi (Subtrair).");
                                    Console.Write("Digite o valor que deseja adicionar: ");
                                    decimal sub = decimal.Parse(Console.ReadLine());
                                    dados.preco = dados.preco - sub;
                                    Console.WriteLine("//////////////////////////////");

                                    Console.WriteLine("Preço alterado com sucesso!");
                                    Console.WriteLine("(EXIBIÇAO DE DADOS)");
                                    Console.WriteLine("Nome do produto: " + dados.nome);
                                    Console.WriteLine("Preço do produto: " + dados.preco);
                                    Console.WriteLine("Quantidade do produto: " + dados.quantidade);
                                    Console.WriteLine("//////////////////////////////");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                    break;
                            }
                            break;

                    }
                    switch (escolha)
                    {
                        case "estoque":
                            Console.WriteLine("A opção escolhida foi (Estoque).");
                            Console.Write("Deseja somar ou subtrair um valor do Estoque?: ");
                            string acao_estoque = RemoverAcentos.Remover(Console.ReadLine());

                            switch (acao_estoque)
                            //Condiçao somar
                            {
                                case "somar":
                                    Console.WriteLine("//////////////////////////////");
                                    Console.WriteLine("A opção escolhida foi (Somar).");
                                    Console.Write("Digite o valor que deseja adicionar: ");
                                    decimal adi = decimal.Parse(Console.ReadLine());
                                    dados.preco = dados.quantidade + adi;
                                    Console.WriteLine("//////////////////////////////");

                                    Console.WriteLine("Preço alterado com sucesso!");
                                    Console.WriteLine("(EXIBIÇAO DE DADOS)");
                                    Console.WriteLine("Nome do produto: " + dados.nome);
                                    Console.WriteLine("Preço do produto: " + dados.preco);
                                    Console.WriteLine("Quantidade do produto: " + dados.quantidade);
                                    Console.WriteLine("//////////////////////////////");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                    break;

                                case "subtrair":
                                    Console.WriteLine("//////////////////////////////");
                                    Console.WriteLine("A opção escolhida foi (Subtrair).");
                                    Console.Write("Digite o valor que deseja adicionar: ");
                                    decimal sub = decimal.Parse(Console.ReadLine());
                                    dados.preco = dados.quantidade - sub;
                                    Console.WriteLine("//////////////////////////////");

                                    Console.WriteLine("Preço alterado com sucesso!");
                                    Console.WriteLine("(EXIBIÇAO DE DADOS)");
                                    Console.WriteLine("Nome do produto: " + dados.nome);
                                    Console.WriteLine("Preço do produto: " + dados.preco);
                                    Console.WriteLine("Quantidade do produto: " + dados.quantidade);
                                    Console.WriteLine("//////////////////////////////");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    //Exibição de dados
                    Console.WriteLine("(EXIBIÇAO DE DADOS)");
                    Console.WriteLine("Nome do produto: " + dados.nome);
                    Console.WriteLine("Preço do produto: " + dados.preco);
                    Console.WriteLine("Quantidade do produto: " + dados.quantidade);
                    Console.WriteLine("//////////////////////////////");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
