# AvaliacaoGestran

##tecnologias

.NET 7;
EF core;
WEBAPI;
C#;
JSON;

##Dicas

Para realizar o teste que integre com o BD, é necessário alterar o arquivo "appsettings.Development.json"

E após isso deve certificar que alguns comandos no terminal tenham sido feitos, como:

dotnet tool install --global dotnet-ef
dotnet-ef migrations add <<nome da migration>>
dotnet-ef database update
