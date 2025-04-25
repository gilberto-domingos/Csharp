# Rascunho de comamdos do github :

git reset --hard HEAD~1
git reset --hard origin/main
git status
git push --force origin main


git pull --rebase origin main
git add .
git rebase --continue
git push origin main


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


