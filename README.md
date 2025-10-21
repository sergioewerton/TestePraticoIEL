# Teste Prático IEL - Cadastro de Estudantes

Este projeto é uma aplicação web desenvolvida como parte do processo seletivo para estágio em TI do Instituto Euvaldo Lodi (IEL).

O objetivo foi desenvolver uma aplicação web em ASP.NET, utilizando C# e o padrão MVC, para gerenciar o cadastro de estudantes do IEL.

## 🚀 Tecnologias Utilizadas

Para a construção deste projeto, foram utilizadas as seguintes tecnologias:

* **ASP.NET Core MVC**: Framework principal para a construção da aplicação web.
* **C#**: Linguagem de programação utilizada para o backend.
* **Entity Framework Core**: ORM utilizado para o mapeamento objeto-relacional e comunicação com o banco de dados.
* **SQL Server LocalDB**: Sistema de banco de dados utilizado para a persistência dos dados.
* **HTML, CSS & Bootstrap**: Tecnologias de frontend para a estruturação e estilização das páginas (Bootstrap foi mencionado como um diferencial).
* **JavaScript & JQuery**: Utilizados para adicionar interatividade e a máscara de CPF (JQuery foi mencionado como um diferencial).

## ✨ Funcionalidades Implementadas

O sistema atende a todos os requisitos solicitados no teste prático:

* **Listagem de Estudantes**: Exibição de todos os estudantes cadastrados em uma tabela.
* **Campo de Pesquisa**: Filtro dinâmico que permite pesquisar estudantes por qualquer informação (nome, CPF, etc.).
* **Cadastro de Novo Estudante**: Botão "Novo" que direciona para o formulário de cadastro.
* **Exclusão de Estudantes**: Opção de excluir um registro, com uma janela de confirmação antes de concluir a ação.
* **Validação de Campos**:
    * **Nome**: Obrigatório, máximo de 100 caracteres.
    * **CPF**: Obrigatório, com validação de formato e máscara `000.000.000-00`.
    * **Endereço**: Máximo de 200 caracteres.
    * **Data de Conclusão**: Campo do tipo data.

## ▶️ Como Executar o Projeto

Para executar este projeto localmente, siga os passos abaixo:

1.  **Pré-requisitos**:
    * Visual Studio 2022 (com a carga de trabalho "ASP.NET e desenvolvimento web").
    * .NET SDK (v8.0 ou superior).
    * SQL Server Express LocalDB (normalmente instalado com o Visual Studio).

2.  **Clonar o Repositório**:
    ```bash
    git clone [https://github.com/sergioewerton/TestePraticoIEL.git](https://github.com/sergioewerton/TestePraticoIEL.git)
    ```

3.  **Abrir a Solução**:
    * Abra o arquivo `.sln` (ex: `TestePraticoIEL.sln`) com o Visual Studio.

4.  **Criar o Banco de Dados (Migration)**:
    * No Visual Studio, vá em `Ferramentas` > `Gerenciador de Pacotes NuGet` > `Console do Gerenciador de Pacotes`.
    * Execute o comando abaixo para criar o banco de dados e as tabelas:
    ```powershell
    Update-Database
    ```

5.  **Executar a Aplicação**:
    * Pressione **F5** ou clique no botão "Play" (IIS Express) na barra de ferramentas do Visual Studio.
    * A aplicação irá abrir no seu navegador.
    * Para acessar a funcionalidade principal, navegue para a URL: `https://localhost:PORTA/Estudantes` (ex: `https://localhost:7123/Estudantes`).
