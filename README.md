# Biblioteca de Mídias

Este projeto é uma aplicação F# adapatada com base no livro **Ruby - Aprenda a Programar na Linguagem mais Divertida** da editora **Casa do Código**. Ele gerencia uma biblioteca de mídias, como livros, filmes, CDs e DVDs. A aplicação utiliza serialização YAML para persistir dados e inclui funcionalidades para filtrar mídias por categoria e formatar valores monetários.

## Estrutura do Projeto

- **`lib/midia.fs`**: Contém a definição da classe `Midia`, que representa uma mídia com propriedades como título, valor, desconto e categoria. Também inclui validações para os valores fornecidos e um método para calcular o valor com desconto.
- **`Program.fs`**: Arquivo principal do programa, onde a classe `Midia` é utilizada para criar instâncias e exibir informações no console.

## Funcionalidades

- **Classe `Midia`**:
  - Propriedades:
    - `Titulo`: O título da mídia.
    - `Valor`: O valor da mídia (com valor padrão de 10.0).
    - `Desconto`: O desconto aplicado à mídia (com valor padrão de 0.1).
    - `Categoria`: A categoria da mídia (opcional).
  - Método:
    - `ValorComDesconto`: Calcula o valor da mídia com o desconto aplicado.

- **Programa Principal**:
  - Cria uma instância da classe `Midia` e exibe o título e o valor com desconto no console.

## C

1. Certifique-se de que você tem o .NET SDK instalado (versão 8.0 ou superior).
2. Clone este repositório ou copie os arquivos para o seu ambiente local.
3. Navegue até o diretório do projeto:
   ```bash
   cd c:\PROJETOS\FSharp\Biblioteca
   ```
4. Compile o projeto:
   ```dotnet build
   ```
5. Execute o programa:
   ```
    dotnet run
   ```

## Requisitos
.NET SDK 8.0 ou superior
Editor de texto ou IDE com suporte a F# (como Visual Studio Code ou JetBrains Rider)
