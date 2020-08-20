# repository-pattern-multilanguage
A repository with examples of Repository Pattern implementation in some programming language.


- code first com EF Core
Tecnica usada para primeiro criar o codigo e depois gerar o banco a partir do codigo.

# Migrations
- Ajuda ao time de DevOps quando ha alterações no banco de dados mantendo uma versão e um melhor controle de alteração.

- Add EF Core tools reference for .NET Core CLI. 
cmd: dotnet tool install --global dotnet-ef

- Criar as Migrações:
ir para a pasta do projeto .\repository-pattern.repository
cmd: dotnet ef migrations add InitialDatabase --startup-project ..\repository-pattern.api -v

> para desfazer 
cmd: ef migrations remove