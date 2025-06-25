import os
import requests
from dotenv import load_dotenv

# Carrega o token do arquivo .env
load_dotenv()
GITHUB_TOKEN = os.getenv('MY_GITHUB_TOKEN')
REPO_OWNER = 'gilberto-domingos'
REPO_NAME = 'Csharp'

headers = {
    'Authorization': f'token {GITHUB_TOKEN}',
    'Accept': 'application/vnd.github.v3+json'
}

def fechar_issues_abertas():
    url = f'https://api.github.com/repos/{REPO_OWNER}/{REPO_NAME}/issues?state=open&per_page=100'
    response = requests.get(url, headers=headers)

    if response.status_code != 200:
        print(f'Erro ao obter issues: {response.status_code}, {response.text}')
        return

    issues = response.json()
    if not issues:
        print('Nenhuma issue aberta encontrada.')
        return

    for issue in issues:
        if 'pull_request' in issue:
            continue  # Ignora pull requests, só fecha issues

        issue_number = issue['number']
        fechar_url = f'https://api.github.com/repos/{REPO_OWNER}/{REPO_NAME}/issues/{issue_number}'
        fechar_response = requests.patch(fechar_url, headers=headers, json={'state': 'closed'})

        if fechar_response.status_code == 200:
            print(f'Issue #{issue_number} fechada com sucesso.')
        else:
            print(f'Erro ao fechar issue #{issue_number}: {fechar_response.status_code}, {fechar_response.text}')

if __name__ == '__main__':
    fechar_issues_abertas()
