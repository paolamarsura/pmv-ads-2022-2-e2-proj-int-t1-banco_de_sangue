# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve ter cadastro de usuário com login e senha | LoginController.cs / CadastroUsuarioController.cs / UsuarioModel.cs / IUsuarioRepositorio.cs / UsuarioRepositorio.cs / Login: Index.cshtml / ListaDeUsuarios.cshtml | 
|RF-002| A aplicação deve permitir o cadastro da pessoa física doadora | CadastroUsuarioController.cs / UsuarioModel.cs / IUsuarioRepositorio.cs / UsuarioRepositorio.cs / CadastroUsuario: Apagar.cshtml Criar.cshtml Editar.cshtml |
|RF-003| A aplicação deve gerar um formulário com os requisitos básicos para triar o potencial doador | FormularioController.cs / FormularioModel.cs / IFormularioRepositorio.cs / FormularioRepositorio.cs| 
|RF-004| A aplicação deve oferecer ao usuário um listagem de bancos de sangue existentes no seu estado   | InstituicaoController.cs / InstitiuicaoModel.cs / IInstituicaoRepositorio.cs / InstituicaoRepositorio.cs / Instituicao: InstituicoesEndereco.cshtml / ListaDeInstituicao.cshtml |
|RF-005| A aplicação deve notificar por e-mail o usuário que esta inapto ou inapto temporariamente para doar sangue. | FormularioController.cs / FormularioModel.cs / IFormularioRepositorio.cs / FormularioRepositorio.cs| 
|RF-006| A aplicação deve oferecer a opção de compartilhamento do endereço do portal para todos o usuários a fim de disseminar informação   | Shared: _Layout.cshtml / HomeController.cs / Home: Index.csthml |
|RF-007| A aplicação deve permitir o compartilhamento da aptidão de doação nas plataformas de mídias sociais | Shared: _Layout.cshtml / HomeController.cs / Home: Index.csthml  | 


# Instruções de acesso

Faça o download do repositório para a sua máquina, abra ele com o Visual Studio Community 2019, você precisará também ter instalado o SQL Server Management Studio 2018. Para executar o banco de dados desta aplicação, instale o Docker e execute o comando executar.bat

Você pode acessar as credenciais de acesso ao nosso banco de dados no arquivo appsettings.json do repositório. Caso você tenha dúvidas o Tutorial pode te ajudar.

A aplicação esta disponível para acesso através deste link (por exemplo: Google Cloud IAM.)

Para testar as funcionalidades com o usuário admin você deve utilizar no login admin@admin.com senha: etapa 3


