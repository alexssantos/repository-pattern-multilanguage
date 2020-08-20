# repository-pattern-multilanguage
A repository with examples of Repository Pattern implementation in some programming language.


- code first com EF Core
Tecnica usada para primeiro criar o codigo e depois gerar o banco a partir do codigo.

#Mapeamento com FluentAPI
- De acordo com as boas praticas, evitar sujar a camiada de dominio com questoes de infraestrutura acompanahando a arquitetura hexagonal ou de cebola (Onion Archtecture)
- Prejudica quem tem mania de usar anotações e está aconstumado com a facilidade de abrir a classe de dominio e ver onde ela está mapeada.

# Migrations
- Ajuda ao time de DevOps quando ha alterações no banco de dados mantendo uma versão e um melhor controle de alteração.

- Add EF Core tools reference for .NET Core CLI. 
cmd: dotnet tool install --global dotnet-ef

- Criar as Migrações:
IMPORTATNTE: Precisa estar dentro da pasta do projeto Repositorio
ir para a pasta do projeto .\repository-pattern.repository
cmd: dotnet ef migrations add InitialDatabase --startup-project ..\repository-pattern.api -v

> para desfazer 
cmd: ef migrations remove

- Aplicar as migrações
obs: nao precisa estar dentro da pasta do projeto repositorio. 
cmd: dotnet ef database update --startup-project ..\repository-pattern.api -v