## Back-end => C# .Net 
- Dotnet version 9.0.202 - .NETCore.App 9.0.3 - AspNetCore.App 9.0.3 /
- ### Conteúdo :
- Lógica de Programação.
- POO - Programação Orientada a Objetos.
- Docker(containers/comunicação entre containers) e RabbitMq(Message Broker) e Microserviços.
- Uso de Expressões Lambadas.
- Aplicações em cenário real
- ### ==> Padrões de Projetos (Design Patterns) 
- Factory Method -> (Criacional : Oferece uma interface para criar objetos, permitindo que subclasses decidam qual classe concreta será instanciada, usar quando você não quer depender diretamente de classes concretas.)
- Decorator Pattern -> (Estrutural: Extender funcionalidades de um objeto sem modificar seu código-fonte original, usar quando precisa seguir o princípio aberto/fechado (Open/Closed Principle - SOLID)
- Facade Pattern -> (Estrutural: Fornece uma interface simplificada para um conjunto complexo de subsistemas, expondo apenas uma API simples para os clientes.
- Abstract Factory -> (Criacional - fornecer uma interface para criar famílias de objetos relacionados sem especificar suas classes concretas,  uma camada de abstração para a criação de objetos, seguindo o princípio Aberto/Fechado do SOLID.)
- Observer Pattern -> (Comportamental - define uma dependência um-para-muitos entre objetos, de forma que quando um objeto muda de estado, todos os seus observadores são notificados automaticamente. Objetivo criar um sistema de notificação automática.)
- Adapter Pattern -> (Estrutural - objetivo é permitir que duas interfaces incompatíveis trabalhem juntas ou exemplo: quando você precisa integrar um sistema legado com um sistema novo.)
- Builder Pattern -> (Criacional - permite a criação de diferentes representações de um objeto utilizando o mesmo código de construção. Objeto precisa ser criado passo a passo. Objetivo é separar a construção de um objeto complexo de sua representação, usar quando há a necessidade de criar diferentes variações do mesmo objeto sem poluir o código com muitos construtores sobrecarregados.

- ### ==> S.O.L.I.D
- -> (S) Single Responsibility Principle - Cada classe deve ter uma única responsabilidade no sistema, e apenas uma razão para mudar.
- -> (O) Open/Closed Principle - As classes devem estar "abertas para extensão, mas fechada para modificação". Novas funcionalidades só através de extensões.
- -> (L) Liskov Substitution Principle - Objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa. Quando você cria uma subclasse, ela deve manter o contrato da classe base. Confiabiliade polimorfismo seguro.
- -> (I) Interface Segregation Principle - Cliente não deve ser forçado a depender de métodos que não utiliza. Objetivo é evitar interfaces grandes e genéricas demais. Dividir em interfaces menores e mais específicas, conforme a responsabilidade da classe.
- -> (D) Dependency Inversion Principle - Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações. Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações. Objetivo é reduzir o acoplamento entre os módulos do sistema.

- ### ==> TESTES UNITÁRIOS
- -> Testando entidades no DDD - As entidades no (Domain-Driven Design) são mais do que apenas classes elas encapsulam comportamento e regras de negócio que precisam ser validadas corretamente.
- -> Testes Unitários com XUnit - framework de testes automatizados para projetos .NET C# mais usado no momento, desenvolver escrever, organizar e executar testes unitários no código.
- ### ==> API RESTfull, princípio (Representational State Transfer) -> Front-end, Back-end e Servidor são separados e se comunicam via requisições HTTP.
- Desenvolvimento ApiRestFull (.Net + React + SqlServer + RabbitMq) e containerização Docker.
- Organização de estrutura -> Models, Interfaces, Services, Controllers, DTOs, Data, DbContext, etc.
- Configuração do Banco de dados(SqlServer) + EF Core + Migrations - InitialCreate 
- SWAGGER - Configuração e teste de end-points na web envio requisições HTTP (GET, POST, PUT, DELETE) 
- CRUD - Create, Read, Update, Delete
- Dockerfiles, docker-compose.yml , configuração dos containers, teste de conexão e comunicação entre os containers.
- Configuração de .env (variáveis de ambiente) - Portas, connection strings, secrets, etc.


 


----------------------------------------------------------------------------

# Front-end => React + TypeScript
- React @19.0.0
- Vite @6.2.0
- yarn v1.22.22
- Routers - react-router-dom @7.4.0
- TypeScript @5.7.3
- Material UI @6.4.8
- ### Conteúdo :
- Implementação de temas : 'Light' | 'Dark'
- Botão alternar temas (Toggle Theme)
- Menu lateral (side-menu)
- Drawer responsivo

