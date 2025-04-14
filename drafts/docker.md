# Rascunho de comandos docker, verificações e testes

╰─ docker exec -it cs.net /bin/bash                                                                      
echo $ASPNETCORE_ENVIRONMENT

docker network connect app_network cs.sql

docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' cs.sql

docker network connect app_network cs.sql

docker run -d --name cs.net \
  -v $(pwd)/SistemaVendas:/app \
  -p 5000:5000 curso-senac-cs.net


docker exec -it cs.sql /bin/bash
echo $DB_SERVER
echo $DB_NAME
echo $SA_PASSWORD

docker exec -it cs.sql ping sqlserver

docker start $(docker ps -a -q)
docker stop $(docker ps -q)

docker exec -it --user root cs.sql /bin/bash

docker-compose down -v

set -a
source .env
set +a


docker exec -u 0 -it cs.sql /bin/bash
apt update
apt install -y mssql-tools


docker logs -f cs.sql

telnet localhost 1433

dotnet ef database update

docker-compose down
docker-compose up -d --build 
docker-compose up -d
docker-compose up -d --build cs.net

docker run -d --name cs.net -p 5000:5000 curso-senac-cs.net


docker run -e 'ACCEPT_EULA=Y' -e "SA_PASSWORD=$SA_PASSWORD" -p 1433:1433 --name cs.sql -d mcr.microsoft.com/mssql/server:2022-latest


docker volume ls  
docker volume rm nome_do_volume


dotnet ef database update


docker logs cs.sql

dotnet tool install --global dotnet-ef


docker exec -it cs.tools bash

docker exec -it cs.net /bin/bash

cd /src/csharp/ApiRestFull/SistemaVendas
dotnet ef migrations add InitialCreate
dotnet ef database update


cd /src/csharp/ApiRestFull/SistemaVendas


dotnet ef migrations add InitialCreate

 
dotnet ef database update



 

