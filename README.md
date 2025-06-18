# Abrir Arquivo

**AbrirArquivo** é um utilitário simples de linha de comando desenvolvido em C# (.NET) que permite abrir qualquer arquivo com o aplicativo padrão associado no sistema operacional Windows.

Ideal para automações, scripts, ou como ferramenta de suporte técnico para testar rapidamente a abertura de arquivos via terminal.

---

## 📦 Download

Você pode baixar o executável compilado clicando no link abaixo:

👉 [Download do AbrirArquivo.exe](https://github.com/mayconwisley/AbrirArquivo/raw/refs/heads/master/Download/AbrirArquivo.exe)

> Após o download, você pode executá-lo via terminal:
>
> ```bash
> AbrirArquivo.exe "C:\Caminho\Para\Seu\Arquivo.pdf"
> ```

---
## ✅ Funcionalidades

- Abre arquivos com o aplicativo padrão do Windows (como se fosse um duplo clique no Explorer).
- Verifica se o caminho do arquivo foi fornecido corretamente.
- Informa se o arquivo não existir.
- Trata erros de execução com mensagens claras ao usuário.

---

## ⚙️ Requisitos

- [.NET 6.0 SDK ou superior](https://dotnet.microsoft.com/download)
- Sistema operacional: **Windows**

---

## 🛠️ Como compilar

1. Clone o repositório e compile:
   ```bash
   git clone https://github.com/mayconwisley/AbrirArquivo.git
   cd AbrirArquivo
   dotnet build -c Release
   ```
2. O executável:
   ```bash
   ./bin/Release/net6.0/AbrirArquivo.exe
   ```

## ▶️ Como usar

1. Sintaxe:
   ```bash
   AbrirArquivo.exe "caminho\para\o\arquivo.extensao"
   ```
   Use aspas se o caminho contiver espaços.

## 📌 Exemplos

1.Abrir um PDF:
   ```bash
   AbrirArquivo.exe "C:\Arquivos\RelatorioMensal.pdf"
   ```
1.Abrir uma imagem:
   ```bash
   AbrirArquivo.exe "C:\Imagens\foto.jpg"
   ```
1.Abrir um arquivo de texto:
   ```bash
   AbrirArquivo.exe "C:\Notas\lembrete.txt"
   ```

## ❓ Não quer usar o .exe? Existe uma alternativa!
1.Sim, via arquivo .bat, segue abaixo. Copiar e salvar em um arquivo com a extensão .bat
   ```bat
   @echo off
   rem ── 1) Validação de quantidade de argumentos ───────────────────────────────
   if "%~1"=="" (
      echo Nenhum parâmetro de inicialização informado.
      pause
      goto :eof
   )

   if not "%~2"=="" (
      echo Informar apenas um parâmetro de inicialização.
      pause
      goto :eof
   )

   rem ── 2) Verifica se o arquivo existe ─────────────────────────────────────────
   set "arquivo=%~1"
   if not exist "%arquivo%" (
      echo Arquivo não encontrado.
      pause
      goto :eof
   )

   rem ── 3) Abre o arquivo no app padrão ─────────────────────────────────────────
   start "" "%arquivo%"
   exit /b 0
```