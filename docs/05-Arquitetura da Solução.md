# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Diagrama de classe - banco de sangue - Página 1 (3)](https://user-images.githubusercontent.com/103156976/193410583-6be60dc5-0c77-48ce-8efc-6856a8c00001.jpeg)


## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![modelo er conceitual](https://user-images.githubusercontent.com/103156976/193477105-dc9164ab-c294-430b-8f59-a56b3d8c3541.jpeg)

O modelo ER foi desenvolvido utilizando a plataforma Lucidchart.

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
![BDFISICO](https://user-images.githubusercontent.com/103156976/193477261-5e3243b5-6787-419d-b6f7-eb6b20c4b6ac.JPG)

## Tecnologias Utilizadas, arquitetura e hospedagem

Abaixo segue a lista de tecnologias utilizadas neste projeto:

- **Controle de Versão:** Git no Github
- **Linguagem:** ASP.NET MVC
- **SGBD:** POSTGRESQL
- **IDE:** Visual Studio 2019
- **Orquestrador:** Docker
- **Hospedagem:** Google Cloud IAM

![image](https://user-images.githubusercontent.com/112259936/198887846-65b43edc-656b-4a46-a23e-51897fe87903.png)

### Processo de entrega continua

Com ajuda de ferramentas como github e orquestração do docker, vamos criar um script de entrega continua de modo que toda vez que rodarmos o script as atualizações definidas e revisadas na branch master sejam publicadas, verifique o arquivo docker-compose.yml na pasta raiz do projeto.

