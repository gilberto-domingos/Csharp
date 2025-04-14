# Imagem base do SQL Server
FROM mcr.microsoft.com/mssql/server:2022-latest

# Usuário root para instalar pacotes
USER root

# Variáveis de ambiente para aceitar os termos da Microsoft
ENV ACCEPT_EULA=Y
ENV DEBIAN_FRONTEND=noninteractive

# Atualiza pacotes, instala dependências e mssql-tools
RUN apt-get update && \ apt-get UPGRADE && \  
    apt-get install -y curl gnupg apt-transport-https software-properties-common && \
    curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add - && \
    curl https://packages.microsoft.com/config/debian/12/prod.list > /etc/apt/sources.list.d/mssql-release.list && \
    apt-get update && \
    ACCEPT_EULA=Y apt-get install -y mssql-tools unixodbc-dev && \
    # Adiciona o caminho ao PATH para acesso ao sqlcmd no terminal
    echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> /etc/profile && \
    echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc && \
    rm -rf /var/lib/apt/lists/*

USER mssql

