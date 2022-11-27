# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados por meio de uma discussão entre os membros da equipe a partir da explanação de situações reais e elucidação de histórias. Os detalhes levantados nesse processo foram compilados na forma de personas e histórias de usuários. 

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na tabela abaixo: 

|Persona  | Descritivo  | Aplicativos | Motivações |Frustações |Hobies |
|---------|-------------|-------------|------------|-----------|-------|
|![paola](https://user-images.githubusercontent.com/103156976/204135284-b9866dcd-90ae-4c61-b06f-af62ff702646.PNG)Paola Marsura| Idade: 29 anos;Ocupação: enfermeira intensivista, vivenciou as consequências da escassez de sangue no Brasil durante a pandemia.| Instagram, linkedIn| Disseminar informações sobre a doação de sangue e capacitar o potencial doador da decisão de doar. | Ver a não doação de sangue por falta de informação e saber que possíveis doadores não realizam doação por medo de contaminação | Viajar, estudar tecnologia e pets.
|![jair](https://user-images.githubusercontent.com/103156976/204135386-e5a7b878-e007-4b8d-a04a-0cbaba2f4507.PNG) Jair Junio da Silva | Idade 43 anos; Ocupação: Engenheiro Mecânico, funcionário de uma multinacional do setor da indústria automotiva. |Instagram, LinkedIn, aplicativos de bancos e GitHub. | Criar meio de comunicação digital que alcance a população em geral para que todos dentro da exigência mínima de saúde, se torne um potencial doador de sangue. | Ver que ainda há tabus por desinformação sobre a doação de sangue. | Inovação, tecnologia, esportes, viajar e cinema.
|![roberto](https://user-images.githubusercontent.com/103156976/204135391-6693023a-3590-4904-a204-192527dcd13a.PNG) Roberto Arimuja| Idade: 36 anos; Ocupação: Engenheiro de Software, trabalha em uma empresa da área financeira. | LinkedIn, TikTok, aplicativos de bancos e GitHub. | Desde quando sua prima foi diagnosticada com leucemia, aumentou o desejo de resolver o problema para divulgar para o máximo de pessoas os benefícios da doação de sangue. |Ser incompatível sanguíneo com sua prima. | Inovação, tecnologia, jiu-jitsu, seriados e caminhar.

## Histórias de Usuários

|Eu como...[PERSONA]  | ...quero/desejo...[O QUE] | ...para...[POR QUE]... | 
|---------------------|---------------------------|------------------------|
|Paola Marsura | Quero mostrar a população brasileira que é possível ser doador sem riscos para saúde | Aumentar o número de potenciais doares de sangue no Brasil. |
|Paola Marsura | Aumentar cultura de doação de sangue no Brasil  | Minimizar os efeitos da escassez de sangue no Brasil |
|Paola Marsura | Queria doar sangue e não sabia onde efetuar a doação | Para ajudar um familiar que precisava de sangue |
|Paola Marsura | Precisei de doação de sangue para um familiar. Não sabia onde procurar | Por questões de saúde |
|Jair Junio | Queria saber se posso ser doador de sangue, antes da doação | Para evitar deslocamento desnecessário |
|Jair Junio | Queria saber se posso doar sangue novamente.  | Para fazer uma nova doação. |
|Jair Junio | O banco de sangue da instituição de saúde da minha região está com estoque baixo. | Poucos doadores. |
|Roberto Arimuja | Usar o poder das redes sociais para atrair a atenção de novos doadores ou conseguir novos ativistas na área de doação | Quanto mais pessoas no processo, mais a possibilidade de aumentar doadores. |
|Roberto Arimuja | Saber quem precisa do meu tipo sanguíneo e qual o lugar para doar para me integrar mais do caso da pessoa que vou doar | Assim crio um laço de relacionamento com as pessoas que precisam do meu sangue.|

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues. 



|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve ter cadastro de usuário com login e senha |Alta | 
|RF-002| A aplicação deve permitir o cadastro da pessoa física doadora | Alta |
|RF-003| A aplicação deve gerar um formulário com os requisitos básicos para triar o potencial doador | Alta | 
|RF-004| A aplicação deve oferecer ao usuário um listagem de bancos de sangue existentes no seu estado   | Alta |
|RF-005| A aplicação deve notificar por e-mail o usuário que esta inapto ou inapto temporariamente para doar sangue. | Média | 
|RF-006| A aplicação deve oferecer a opção de compartilhamento do endereço do portal para todos o usuários a fim de disseminar informação   | Baixa |
|RF-007| A aplicação deve permitir o compartilhamento da aptidão de doação nas plataformas de mídias sociais | Baixa | 

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RNF-01| A aplicação deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | Alta |
|RNF-02| A aplicação deverá ser responsivo permitindo a visualização em um celular de forma adequada | Média |
|RNF-03| A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade  | Média |
|RNF-04| A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) | Alta |
|RNF-05| O servidor da aplicação deve atender altas demandas de acesso no mínimo 1000 requisições por minuto | Alta |


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID    | Descrição | 
|------|-----------|
|RE-01 |O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 11/12/2022. 
|RE-02 |O site deve se restringir a programação com a linguagem C# para back-end. Devendo utilizar Framework ASP.NET Core MVC. |
|RE-03 |O site deve utilizar como Sistema de Gerenciamento de Banco de Dados (SGBD) um sistema compatível com o ambiente de desenvolvimento e publicação.  |
|RE-04 |A equipe não pode subcontratar o desenvolvimento do trabalho. |
|RE-05 |O site deve obedecer a LGPD Brasileira para compartilhamento e armazenamento de dados sensíveis. |


## Diagrama de Casos de Uso

O diagrama apresentado abaixo contempla as principais ligações previstas entre casos de uso e atores, permitindo detalhar os Requisitos Funcionais definidos e elicitar as histórias de usuários.

![diagrama de caso de uso corrigido](https://user-images.githubusercontent.com/103156976/193267052-da4e12ca-91b3-4b25-b25a-7ce462b065bb.jpg)


