# Source Season 6

Repositorio da source Season 6 do MuServer, incluindo projetos do servidor, cliente/main e utilitarios auxiliares.

## Conteudo principal

- `Server/` - projetos do lado servidor, incluindo GameServer, GameServerCS, ConnectServer, DataServer e JoinServer.
- `Main_EX603/` - projeto do cliente/main EX603.
- `GetMainInfo/` - ferramenta para gerar informacoes do cliente.
- `AuthServer/`, `GameGuard/`, `EncryptBMD/`, `Tool`s/` e `Util/` - componentes auxiliares e bibliotecas usadas pelos projetos.

## Requisitos

- Windows.
- Visual Studio com workload de C++ desktop.
- Toolset compativel com projetos antigos do Visual Studio C++.
- Windows SDK instalado.

O ambiente local usado neste servidor possui MSBuild em:

```powershell
C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe
```

## Build rapido dos servidores

Abra um PowerShell na raiz do repositorio e ajuste o caminho do MSBuild se necessario.

```powershell
$msbuild = "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe"

& $msbuild "Server\ConnectServer\ConnectServer\ConnectServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\DataServer\DataServer\DataServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\JoinServer\JoinServer\JoinServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\GameServer\GameServer\GameServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\GameServer\GameServer\GameServer.vcxproj" /p:Configuration=Release_EX603CS /p:Platform=Win32 /m
```

## Publicacao dos executaveis no MuServer

Depois do build, copie os executaveis gerados para as pastas de execucao do servidor com os processos fechados:

```powershell
Copy-Item "Server\ConnectServer\Release\ConnectServer_EX603\ConnectServer.exe" "C:\MuServer\ConnectServer\ConnectServer.exe" -Force
Copy-Item "Server\DataServer\Release\DataServer_EX603\DataServer.exe" "C:\MuServer\DataServer\DataServer.exe" -Force
Copy-Item "Server\JoinServer\Release\JoinServer_EX603\JoinServer.exe" "C:\MuServer\JoinServer\JoinServer.exe" -Force
Copy-Item "Server\GameServer\Release\GameServer_EX603\GameServer.exe" "C:\MuServer\GameServer\GameServer.exe" -Force
Copy-Item "Server\GameServer\Release\GameServer_EX603CS\GameServerCS.exe" "C:\MuServer\GameServerCS\GameServerCS.exe" -Force
```

## Observacoes

- Caches do Visual Studio, builds, logs, dumps e binarios gerados ficam fora do Git por `.gitignore`.
- Bibliotecas `.lib` foram mantidas versionaveis porque alguns projetos antigos podem depender delas para compilar.
- Nao publique arquivos de licenca, tokens, senhas ou configuracoes locais de producao.
- Se o Windows bloquear a copia de um `.exe`, feche o processo correspondente antes de substituir.

## Documentacao

- [Build](docs/BUILD.md)
- [Estrutura](docs/STRUCTURE.md)
- [Manutencao](docs/MAINTENANCE.md)
