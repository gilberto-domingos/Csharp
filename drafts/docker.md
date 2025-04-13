# Rascunho de comandos

docker exec -it --user root cs.sql /bin/bash

docker-compose down -v

set -a
source .env
set +a

docker logs -f cs.sql

telnet localhost 1433

dotnet ef database update

docker-compose down
docker-compose up --build -d


docker run -e 'ACCEPT_EULA=Y' -e "SA_PASSWORD=$SA_PASSWORD" -p 1433:1433 --name cs.sql -d mcr.microsoft.com/mssql/server:2022-latest


docker volume ls  
docker volume rm nome_do_volume


dotnet ef database update


docker logs cs.sql

dotnet tool install --global dotnet-ef


docker exec -it cs.tools bash

docker-compose up -d cs.tools

docker-compose down
docker-compose up -d --build


docker exec -it cs.net /bin/bash

cd /src/csharp/ApiRestFull/SistemaVendas
dotnet ef migrations add InitialCreate
dotnet ef database update


cd /src/csharp/ApiRestFull/SistemaVendas


dotnet ef migrations add InitialCreate

 
dotnet ef database update

docker-compose up -d --build cs.net

 

