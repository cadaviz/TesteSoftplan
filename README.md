# TesteSoftplan
## Resumo
Projeto desenvolvido durante um teste realizado para a empresa Softplan em maio de 2019.
Era desenvolver uma api que calculasse o valor de juros compostos.

## Funcionalidades
### Calculajuros

Acessada através de ```api/softplan/calculajuros```.
Recebe como parâmetros **valorInicial** que é do tipo decimal e **meses** que é um número inteiro.
Retorna o resultado com os valores truncados em duas casas decimais.
Exemplo:
A chamada ```api/softplan/calculajuros?valorInicial=1000&meses=2``` irá retornar 1020.10.

### Showmethecode
Acessada através de ```api/softplan/showmethecode```.
Exibe a url do repositório git do projeto.


## Tecnologias envolvidas
- Sistema desenvolvido utilizando .Net Framework 4.6.1;
- Foi implementado teste de unidade com as bibliotecas nativas; 
- Toda a aplicação foi desenvolvida no Visual Studio 2017 Enterprise.

## Executando em modo debug
- Executar o projeto Softplan.MiguelCadaviz.WebApi.

