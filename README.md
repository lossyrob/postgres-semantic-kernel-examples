## PostgreSQL & Semantic Kernel: Examples

### Introduction

This repository contains examples and sample code for using SemanticKernel with PostgreSQL in general and Azure DB for PostgreSQL in particular.

### Docker setup

Included is a `docker-compose.yml` file that sets up a PostgreSQL with the `pgvector` extension installed. This can be used to test the examples in this repository
in a local setup. To run, make sure you have Docker installed and run:

```bash
docker-compose up
```

You can now connect to the `postgres` database on `localhost:5432` with the username `postgres` and password `example`.

### Azure DB for PostgreSQL setup

TODO: Bicep template to setup Azure DB for PostgreSQL with `pgvector` extension installed.

### .NET Examples

The `dotnet` folder contains examples of using Postgres with the .net SemanticKernel library. See [dotnet/README.md](dotnet/README.md) for more details.

### Python Examples

The `python` folder contains examples of using Postgres with the Python SemanticKernel library. See [python/README.md](python/README.md) for more details.
