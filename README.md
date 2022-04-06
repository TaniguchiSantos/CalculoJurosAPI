<img src="https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" /> <img src="https://img.shields.io/badge/Docker-2CA5E0?style=flat-square&logo=docker&logoColor=white" /> 

# API Calculo de Juros

### Tabela de Conteúdo

<!--ts-->
   * [Descrição](#descrição)
   * [Recursos](#recursos)
   * [Desafio técnico](#how-to-use)
      * [Pre-requisitos](#pre-requisitos)
      * [Demanda](#a-demanda)
      * [API 1](api-1)
      * [API 2](api-2)
   * [Tecnologias](#tecnologias)
   * [Autor](#autor)
   * [Licença](#licença)
<!--te-->

### Descrição
<p align="center">Projeto .NET que retorna a taxa de juros e o link do repositório do github e faz calculo do juros composto </p>

<h4 align="center">
	🚧 Finalizada  🚧
</h4>

### Recursos

- [x] Retornar Taxa de Juros
- [x] Retornar Link do Repositório do Github
- [x] Calculo de Juros Composto
- [x] Teste Unitário
- [x] Swagger
- [x] NUnit Framework
- [x] Query Params and Paged Search
- [x] Versioning
- [x] Cors
- [x] Docker Support

### Pre-requisitos

Antes de iniciar, tenha essas ferramentas instaladas:
[Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/), [.NET 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1), [Docker](https://www.docker.com/products/docker-desktop/).

## A demanda
Você deverá criar duas API's uma com dois endpoints e outra com um endpoint.

### API 1
1) Retorna taxa de juros
Responde pelo path relativo &quot;/taxaJuros&quot;
Retorna o juros de 1% ou 0,01 (fixo no código)
Exemplo: /taxaJuros Resultado esperado: 0,01 

### API 2
1) Calcula Juros
    Responde pelo path relativo &quot;/calculajuros&quot;
    Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final =
    Valor Inicial * (1 + juros) ^ Tempo
    Valor inicial é um decimal recebido como parâmetro.
    Valor do Juros deve ser consultado na API 1.
    Tempo é um inteiro, que representa meses, também recebido como parâmetro.
    ^ representa a operação de potência.
    Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.


    *Exemplo: /calculajuros?valorinicial=100&amp;meses=5 Resultado esperado: 105,10*
2) Show me the code
Este responde pelo path relativo /showmethecode Deverá retornar a url de onde
encontra-se o fonte no github

### Tecnologias

🛠

As seguintes tecnologias foram usadas nesse projeto:

- [.NET 3.1](https://docs.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-core-3-1)
- [Docker](https://www.docker.com/)
- [NUnit Framework](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-nunit)

### Autor
![filename](https://user-images.githubusercontent.com/57140933/161768960-63c7a0b0-4f54-44cb-914d-a7592a52b4d8.png)

Feito com ❤️ por Taniguchi Santos 👋🏽 Entre em contato!  

<a href="https://www.linkedin.com/in/taniguchi-santos/>" alt="linkedin" target="_blank">
<img src="https://img.shields.io/badge/LinkedIn-0077B5?style=flat-square&logo=linkedin&logoColor=white">
</a>
<a href="mailto:tani_sales@hotmail.com" alt="outlook" target="_blank">
<img src="https://img.shields.io/badge/Microsoft_Outlook-0078D4?style=flat-square&logo=microsoft-outlook&logoColor=white" />
</a>

### Licença

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
