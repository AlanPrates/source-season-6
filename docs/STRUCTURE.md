# Estrutura

## Pastas principais

- `Server/ConnectServer` - conexao inicial dos clientes.
- `Server\DataServer` - comunicacao com banco/dados.
- `Server\JoinServer` - autenticacao/entrada de contas.
- `Server\GameServer` - logica principal do jogo e Castle Siege.
- `Main_EX603` - cliente/main.
- `GetMainInfo` - gerador de configuracoes do cliente.
- `Util` e `Server\Util` - bibliotecas e codigo compartilhado.

## Fluxo comum de alteracao

1. Alterar a source no projeto correspondente.
2. Compilar a configuracao correta.
3. Fechar o processo em execucao.
4. Fazer backup do `.exe` atual.
5. Copiar o novo `.exe`.
6. Abrir o servidor e validar no painel/logs.

## Arquivos nao versionados

O repositorio ignora:

- Caches do Visual Studio.
- Saidas `Release` e `Debug`.
- Objetos de compilacao.
- Executaveis e DLLs gerados.
- Logs e dumps.
- Licencas ou configuracoes locais.
