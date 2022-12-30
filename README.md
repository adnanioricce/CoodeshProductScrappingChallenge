# Product Scrapping

Product Scrapping é uma solução de Scrapping criada para resolver o Backend Challenge 20220626, da coodesh.

# Para executar o projeto

## Requisitos

- .NET SDK 7.0 ou maior
- Uma instância do Microsoft Sql Server 
- Ou docker e docker-compose

### Com docker compose

execute o seguinte comando na raiz do projeto:

```bash
docker-compose up -d
```

### Sem Docker Compose



#### Crie o banco de dados

execute o script ``Db/mssql/createdb.sql`` na sua instância do MSSQL para criar o banco de dados.

#### Execute o projeto Scrapper

Para realizar o scrapping das páginas e alimentar o banco de dados, é necessário executar o projeto Scrapper, seja executando o mesmo em um terminal separado, ou usando ``Start-Process``.

Então, vá até a pasta `src/Scrapper` e inicie o projeto com alguma das opções abaixo.

Powershell:

```powershell
Start-Process dotnet run
```

Bash:

```bash
dotnet run &
```

ou simplesmente em um terminal separado:

```bash
dotnet run
```

#### Execute a Api Web

Para executar a API, vá até a pasta `src/Api` e execute alguma das opções abaixo:

Powershell:

```powershell
Start-Process dotnet run
```

Bash:

```bash
dotnet run &
```

ou simplesmente em um terminal separado:

```bash
dotnet run
```

