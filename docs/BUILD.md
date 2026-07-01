# Build

## Configuracoes usadas

Servidor normal:

- `Release_EX603|Win32`

Castle Siege/GameServerCS:

- `Release_EX603CS|Win32`

## Comandos

```powershell
$msbuild = "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe"

& $msbuild "Server\ConnectServer\ConnectServer\ConnectServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\DataServer\DataServer\DataServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\JoinServer\JoinServer\JoinServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\GameServer\GameServer\GameServer.vcxproj" /p:Configuration=Release_EX603 /p:Platform=Win32 /m
& $msbuild "Server\GameServer\GameServer\GameServer.vcxproj" /p:Configuration=Release_EX603CS /p:Platform=Win32 /m
```

## Saidas esperadas

- `Server\ConnectServer\Release\ConnectServer_EX603\ConnectServer.exe`
- `Server\DataServer\Release\DataServer_EX603\DataServer.exe`
- `Server\JoinServer\Release\JoinServer_EX603\JoinServer.exe`
- `Server\GameServer\Release\GameServer_EX603\GameServer.exe`
- `Server\GameServer\Release\GameServer_EX603CS\GameServerCS.exe`

## Avisos conhecidos

Alguns projetos antigos podem emitir warnings de funcoes C antigas ou variaveis nao inicializadas. Corrija antes de usar em producao quando o warning indicar risco real de comportamento incorreto.
