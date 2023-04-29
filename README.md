
README

Este projeto foi criado com o objetivo de apresentar dados de um produto em estoque e permitir ao usuário alterar esses dados de acordo com sua necessidade. O projeto é escrito em C#.

O arquivo Principal.cs contém a classe Principal que possui o método Main como ponto de entrada da aplicação. O código possui algumas dependências de bibliotecas padrões do C#, incluindo System, System.Collections.Generic, System.Linq, System.Text, System.Threading.Tasks e System.Globalization.

O programa solicita ao usuário que insira os dados do produto, incluindo o nome, preço e quantidade, e os armazena na classe Dados.

Em seguida, exibe os dados inseridos pelo usuário e solicita que o usuário decida se deseja alterar algum dado do produto. Se o usuário optar por alterar, ele pode escolher entre nome, preço ou estoque. Dependendo da escolha do usuário, o programa executa uma das opções de alteração. Se o usuário escolher o preço ou estoque, ele também pode optar por somar ou subtrair um valor.

O código está dividido em classes diferentes para cada tipo de operação. A classe PrimeiraLetraMaiuscula é responsável por garantir que a primeira letra do nome inserido pelo usuário seja maiúscula. A classe RemoverAcentos é responsável por remover acentos das palavras inseridas pelo usuário para evitar erros de digitação.

Como usar:

Abra o projeto em uma IDE C# de sua escolha.
Compile e execute o código.
Insira o nome, preço e quantidade do produto.
Verifique se os dados inseridos estão corretos.
Decida se deseja alterar algum dado do produto.
Selecione o dado que deseja alterar (nome, preço ou estoque).
Se estiver alterando o preço ou estoque, selecione se deseja somar ou subtrair um valor.
Insira o valor desejado.
Verifique se os dados foram alterados corretamente.
Nota: Certifique-se de ter todas as dependências instaladas em sua IDE C# antes de compilar e executar o código.
