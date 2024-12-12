# Hands On

## Minuta

- Inicialização do docker para levantar o rabbitmq
- Configuração do Masstransit no orquestrador
- Configuração do Masstransit nas apis/worker
    - Diferença entre comandos e 
    - Configurar comandos e eventos
    - Configurar compoentes / consumidores
    - verificar retry do evento de origem
    - criar evento de origem

- Configurar saga
    - criar maquina de estado
    - criar estado
    - criar propriedades dos eventos
    - terminar configuração no program


## Recomendações

## Video de mastransit, antigo e desatualizado, porém em pt-br com configuração completo
https://www.youtube.com/watch?v=2EpbDqeSl_w&ab_channel=PubDev

## guideline MS para microserviços
https://learn.microsoft.com/pt-br/dotnet/architecture/microservices/

## guideline MS para microserviços e orientação a domínio
https://learn.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/

## Mastransit documentação
https://masstransit.io/

## Exemplo bem completo sobre microserviços com uso do mastransit
https://medium.com/@ebubekirdinc/saga-orchestration-using-masstransit-in-net-9a2fcb427c1a


## Para rodar


### Pré-requisitos 

- Instalar o docker 
https://www.docker.com/

- Aplicação construída sobre o Visual Studio Community

- Com docker instalado rodar, rodar o arquivo docker-compose.yml que irá inicializar o RabbitMq

- Usuário e senha padrões para RabbitMq são:
user: guest 
pass: guest