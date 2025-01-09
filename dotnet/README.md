## Postgres and .NET Semantic Kernel Examples

TODO

Copy the `appsettings.json.example` file to `appsettings.json` and fill in the connection string for your PostgreSQL database, or keep the
existing one if using the provided `docker-compose.yml` file. You must provide Azure OpenAI details for an instance with
text embedding and chat completion models deployed.

```
> cd dotnet
> dotnet restore
> dotnet build
> dotnet run load --topic RAG --total 100
> dotnet run query "What are good chunking strategies to use for unstructured text in RAG applications?"
```