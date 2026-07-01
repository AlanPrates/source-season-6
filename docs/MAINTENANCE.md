# Manutencao

## Antes de mexer

Crie uma branch:

```powershell
git checkout -b ajuste/nome-da-tarefa
```

## Conferir alteracoes

```powershell
git status
git diff
```

## Commit

```powershell
git add .
git commit -m "Descreve a alteracao"
```

## Backup manual de executaveis

```powershell
$stamp = Get-Date -Format "yyyyMMdd-HHmmss"
Copy-Item "C:\MuServer\GameServer\GameServer.exe" "C:\MuServer\GameServer\GameServer.exe.backup-$stamp"
```

## Boas praticas

- Nao commitar arquivos de producao com senhas ou licencas.
- Nao commitar builds gerados se o codigo fonte permite recompilar.
- Guardar alteracoes visuais do GameServer em `Server\GameServer\GameServer\ServerDisplayer.cpp`.
- Validar GameServer e GameServerCS separadamente quando mexer em codigo condicionado por `GAMESERVER_TYPE`.
