# Rascunho de comamdos do github :

git rebase -i --root
git rebase -i HEAD~1
git reset HEAD^
git add caminho/para/backend/*
git rebase --continue
git commit -m "feat: ..."
git push --force

divisão de commits, fluxo:
git status → vê os arquivos modificados (todos os do commit original)
git add <arquivo1> <arquivo2> → seleciona os arquivos pro primeiro commit
git commit -m "mensagem do primeiro commit"
git add <arquivo3> <arquivo4> → seleciona os arquivos pro segundo commit
git commit -m "mensagem do segundo commit"
(repete até terminar de dividir os arquivos)
git rebase --continue → informa ao Git que terminou de dividir

git pull --rebase origin main
git pull origin main

git log --oneline origin/main..HEAD
git log --oneline HEAD..origin/main

git log
git log --oneline
git log --oneline --graph --all --decorate
git show --name-only

git restore --staged .

git log --since=midnight --pretty=format:"%h %ad | %s" --date=short
git log --since=midnight
git log --since=midnight --author="$(git config user.name)"
git log --since="2 days ago" --pretty=format:"%h %ad | %s" --date=short

git reset
git reset --mixed HEAD~1
git reset nome_do_arquivo
git restore --staged Program.cs

git rev-parse --is-inside-work-tree

git add -A
git commit --amend --no-edit
git push origin main --force

git add -A
git commit -m "Renomeando pasta "
git push origin main
git log --follow csharp/TestandoEntidadesDDD/TestandoEntidadesDDD.sln

git fetch origin
git reset --hard origin/main

pip install git-filter-repo

git remote -v 
git push origin --force

git mv "Csharp_projects" "csharp"
git filter-repo --path-rename "Csharp_projects":"csharp/"
git commit -m "Renomeando ..."
git push origin main

git pull origin main --rebase
git push origin main

git clone --mirror git@github.com:gilberto-domingos/CS.git
cd CS.git

def blob_callback(blob, metadata):
    if metadata.path == b'README.md':
        blob.data = b"# Este conteúdo foi removido por questões de segurança.\n"
git filter-repo --force --blob-callback ./rewrite_readme.py
git log -p README.md

git filter-repo \
  --path README.md \
  --blob-callback "$(cat rewrite-readme.py)" \
  --force


 # Padrão de Commits - Conventional Commits
  Boas práticas recomendadas pelo GitHub, especificação [Conventional Commits]
  (https://www.conventionalcommits.org/)

| **Prefixo**   | **Quando usar**                                                                                   | **Exemplo prático (frase)**                          |
|---------------|--------------------------------------------------------------------------------------------------|----------------------------------------------------|
| `feat:`        | Para **novas funcionalidades** ou recursos que **adicionam valor ao usuário**                     | Use ao criar um endpoint novo no controller.       |

| `fix:`         | Para **correção de bugs** ou erros **que afetam o usuário ou produção**                           | Use ao corrigir um bug de lógica no serviço.       |

| `docs:`        | Para **alterações apenas na documentação** (README, wiki, comentários, etc.)                      | Use ao atualizar o README ou Swagger docs.         |

| `style:`       | Para **ajustes de formatação** ou **refatoração visual** (sem alterar lógica ou funcionalidade)   | Use ao arrumar identação ou espaços no código.     |

| `refactor:`    | Para **alterações de código que não mudam o comportamento externo**, mas melhoram estrutura       | Use ao reorganizar métodos ou classes sem alterar funcionalidade. |

| `perf:`        | Para **melhorias de performance** sem mudar a funcionalidade                                      | Use ao otimizar uma query SQL ou um algoritmo.     |

| `test:`        | Para **adição ou ajuste de testes unitários, de integração, etc.**                                | Use ao adicionar um teste no xUnit para um handler.|

| `chore:`       | Para **tarefas auxiliares não ligadas diretamente ao código de produção ou testes**               | Use ao atualizar pacotes NuGet ou configs do projeto. |

| `build:`       | Para **mudanças no processo de build ou ferramentas de build** (pipelines, CI/CD)                 | Use ao alterar o arquivo do GitHub Actions ou Dockerfile. |

| `ci:`          | Para **ajustes em configurações de integração contínua**                                          | Use ao modificar o workflow de deploy automático.  |

| `revert:`      | Para **reverter um commit anterior**                                                              | Use ao desfazer uma feature ou bug fix.            |

## Exemplo de uso

```bash
feat: adicionar endpoint GET /clientes
fix: corrigir busca de clientes inativos
style: corrigir identação nos controllers
perf: otimizar algoritmo de cálculo de saldo
refactor: extrair lógica de validação para um método separado
chore: atualizar pacote MediatR para versão 10
