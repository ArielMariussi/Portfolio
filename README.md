# Ariel Mariussi — Portfólio

Portfólio desenvolvido em **Blazor WebAssembly (.NET 8)**, hospedado na **Vercel**.

## Stack
- Blazor WebAssembly
- .NET 8
- C#
- Vercel (hospedagem)
- Render (API)
- Neon (PostgreSQL serverless)

## Como rodar localmente

```bash
dotnet run
```

Acesse: `https://localhost:5001`

## Deploy na Vercel

1. Suba este repositório no GitHub
2. Importe na [Vercel](https://vercel.com)
3. Configure o build:
   - **Build Command:** `dotnet publish -c Release -o release`
   - **Output Directory:** `release/wwwroot`
4. Clique em Deploy ✅

> O arquivo `vercel.json` já está configurado para o roteamento do Blazor funcionar corretamente.

## Configuração importante

Antes do deploy, atualize os seguintes valores em `Program.cs` e `Pages/Index.razor`:

- URL da sua API no Render
- Seu email de contato
- URLs do GitHub e LinkedIn

## CORS na API do Render

Para que o Blazor consiga chamar sua API, adicione no `Program.cs` da sua API:

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("Portfolio", policy =>
        policy.WithOrigins("https://seu-portfolio.vercel.app")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

app.UseCors("Portfolio");
```
