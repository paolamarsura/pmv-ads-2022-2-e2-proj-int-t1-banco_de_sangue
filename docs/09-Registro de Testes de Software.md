# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

- CT-01-Cadastro de Usuário
Durante o desenvolvimento do cadastro de usuário ao realizar o teste proposto no CT-01 em primeira instância o cadastro não era concluído pois não havíamos definido a PRIMARY KEY, desta forma a aplicação não conseguia cadastrar e ter um retorno do banco de dados. Após a definição da variável e-mail como PRIMARY KEY na UsuarioModel.cs o problema foi resolvido. A captura de tela abaixo exemplifica o ocorrido e o vídeo CT VÍDEO 01 registrou o teste.
 
 ![image](https://user-images.githubusercontent.com/103156976/198860482-bbb07279-0653-442d-abd3-96693e4e666b.png)


https://user-images.githubusercontent.com/103156976/198860751-97a16f90-4585-45a7-aeeb-528c30066191.mp4



- CT-02-Efetuar login. 
	No caso de teste CT-02 tivemos uma situação relacionada a senha, onde a criptografia adotada (método HASH) não retornava ao fazer login, isto aconteceu pois havíamos aplicado somente o código de criptografia sem exigir o retorno do mesmo após cadastro no banco de dados. A tela abaixo ilustra como a criptografia foi resolvida, e o vídeo CT VÍDEO 02 registra o caso de teste. 
 
 ![image](https://user-images.githubusercontent.com/103156976/198860492-9ebe535e-438e-4764-90d4-1f5dfb333e7a.png)

https://user-images.githubusercontent.com/103156976/198860728-227194e4-bdf7-4ceb-b26a-1da2f6dffac5.mp4


- CT-04-Formulário de Aptidão 
No caso de teste CT-04 a dificuldade estava em conseguir retornar o valor do formulário para a model, tentamos a execução utilizando o @Html.Helper.BeginForm porém sem sucesso, desta forma a solução encontrada foi aplicar o “asp-for” em cada tag de radio para  fazer o biding da view para a model dentro da controller. 
A tela abaixo mostra o retorno das variáveis após submissão do formulário.

 ![image](https://user-images.githubusercontent.com/103156976/198860499-da628b68-4c9f-4329-94a3-cded7831e606.png)
 
 - CT-05-Cadastro como doador
 No caso de teste CT-05 os vídeos abaixo mostram a integração do cadastro do usuário como doador e sua interação com o banco de dados bem como a programação das funcionalidades editar e apagar. 

https://user-images.githubusercontent.com/103156976/204138563-07669494-d95a-45de-a16a-44e6b7a2040c.mp4

https://user-images.githubusercontent.com/103156976/204138554-cf92dc2f-2906-4a01-9bdd-0f0ee94d1662.mp4


