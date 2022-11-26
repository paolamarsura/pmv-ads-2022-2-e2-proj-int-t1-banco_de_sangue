# Banco de sangue 

This application is generated using C# And Visual Studio 2019 

## Dependencies

- Microsoft.EntityFrameworkCore
- Docker


## Run the application

```sh

docker pull mcr.microsoft.com/mssql/server:2019-latest
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=BcoSague#2022" -p 1450:1433 -d mcr.microsoft.com/mssql/server:2019-latest

dotnet restore
dotnet tool install --global dotnet-ef --version 5.0.0
dotnet ef migrations add Migration5 --context BancoContext
dotnet ef database update --context BancoContext

dotnet run

```


## Ecosistema da Aplicação

```

Ide de desenvolvimento Visual Studio 2019
Linguagem C#
.Net FrameWork 5
Docker-distribuição
Banco sqlserver
Construção do banco EF-Migrations
Distribuição - Docker
Autenticação: Custom
Revisão de codigo foi utilisado a extensão  eslint
Padroes de projeto:(??) ( Acoplamento/ Coesão)
    - Factory 
    - Singleto : Control de numero de coneção (pool)
    - injeção de dependencia: Data Contexto Repository
    - MVC: 
    - Princípio de responsabilidade única -> 


```

## Trello atividades

```sh

#01 - Analise e entendimento da demanda
#02 - Subir docker em uma maquina Windows
#03 - Subir projeto para o Git
#04 - Identificar Imagem sqlserver adequada
#05 - Subir SqlServer para o  Contenier
#06 - Conectar Aplicação na base
#07 - Gerar e rodar os Migrations
#08 - Gerar carga com Seeds 
#09 - Configurar Docker compose 
#10 - Validações
#11 - pipline
#12 - Crud Basico Sinup
#13 - Pegar Aceite do Cliente

```

## Check List

```sh

- Conexão-OK
- crud -


```

## Video Projeto execultaldo

```sh
 
https://www.youtube.com/

```
