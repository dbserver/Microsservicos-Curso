1. O que é CQRS (Command Query Responsibility Segregation)?

a) Um padrão que combina comandos e consultas em uma única responsabilidade.<br/>
b) Um padrão que separa responsabilidades de comandos e consultas.<br/>
c) Uma forma de criar APIs RESTful.<br/>
d) Um sistema de gerenciamento de filas de mensagens.<br/>

2. Qual é a principal vantagem da separação de comandos e consultas no CQRS?

a) Redução do uso de memória.<br/>
b) Melhor controle de permissões.<br/>
c) Otimização para operações de leitura e escrita.<br/>
d) Simplificação do código, removendo eventos.<br/>

3. Qual conceito foi base para o surgimento do CQRS?

a) Arquitetura Hexagonal.<br/>
b) Clean Architecture.<br/>
c) CQS (Command Query Separation).<br/>
d) Event Sourcing.<br/>

4. Em uma implementação de CQRS, qual é a característica de comandos?

a) Eles retornam dados diretamente ao usuário.<br/>
b) Eles processam e modificam o estado do sistema.<br/>
c) São otimizados para consultas rápidas.<br/>
d) Geram eventos assíncronos para múltiplos consumidores.<br/>

5. Qual benefício principal surge ao separar bancos de dados para leitura e escrita em CQRS?

a) Evitar a replicação de dados.<br/>
b) Permitir operações simultâneas de leitura e escrita sem competição.<br/>
c) Reduzir custos de armazenamento.<br/>
d) Eliminar a necessidade de índices em bancos relacionais.<br/>

6. No exemplo de código do CalcularJurosCommand, qual é a principal função do comando?

a) Retornar os juros calculados para o usuário.<br/>
b) Modificar o estado do sistema e salvar as parcelas.<br/>
c) Recuperar informações de juros de um banco de dados.<br/>
d) Gerar notificações para consumidores de eventos.<br/>

7. O que caracteriza um evento em uma arquitetura orientada a eventos (EDA)?

a) Algo que está acontecendo em tempo real.<br/>
b) Uma notificação de algo que já ocorreu no sistema.<br/>
c) Uma mudança de estado prevista para o futuro.<br/>
d) Uma tarefa agendada para ser executada posteriormente.<br/>

8. Qual é a característica fundamental dos eventos?

a) São mutáveis para ajustes posteriores.<br/>
b) Representam ações planejadas para o futuro.<br/>
c) São imutáveis e descrevem mudanças passadas.<br/>
d) Devem conter todos os dados do sistema para otimização.<br/>

9. Qual das opções é um exemplo de evento de domínio?

a) "Cache Atualizado".<br/>
b) "Pedido Criado".<br/>
c) "Log de Depuração".<br/>
d) "Memória Liberada".<br/>

10. Qual é a responsabilidade principal de um mediador (Message Broker)?

a) Modificar eventos recebidos.<br/>
b) Criar eventos baseados em consultas.<br/>
c) Facilitar a comunicação entre produtores e consumidores.<br/>
d) Processar dados de eventos diretamente.<br/>

11. Qual é um exemplo de produtor de eventos?

a) Uma fila de mensagens vazia.<br/>
b) Um serviço backend que emite eventos após ações de usuários.<br/>
c) Um banco de dados que somente lê informações.<br/>
d) Uma interface gráfica que processa eventos localmente.<br/>

12. O que é idempotência no contexto de eventos?

a) Garantir que eventos sejam entregues exatamente uma vez.<br/>
b) Permitir que eventos sejam processados múltiplas vezes sem efeitos duplicados.<br/>
c) Certificar-se de que eventos sempre gerem respostas rápidas.<br/>
d) Reordenar eventos com base no timestamp.<br/>

13. O que distingue Event Notification de Event Sourcing?

a) Event Notification armazena todos os eventos no banco de dados.<br/>
b) Event Sourcing é usado apenas em sistemas monolíticos.<br/>
c) Event Notification transmite informações mínimas sobre mudanças de estado.<br/>
d) Event Sourcing reduz o volume de dados transmitidos.<br/>


14. Qual é a relação entre CQRS e Event Sourcing?

a) Ambos são incompatíveis em arquiteturas de microsserviços.<br/>
b) CQRS fornece a base para replicação de eventos.<br/>
c) Event Sourcing registra mudanças de estado e pode complementar CQRS.<br/>
d) CQRS elimina a necessidade de armazenamento de eventos.<br/>

15. Qual é uma vantagem de usar Event Sourcing em sistemas financeiros?

a) Reduz custos de processamento.<br/>
b) Simplifica a lógica de negócios.<br/>
c) Permite reconstruir o estado atual a partir de eventos passados.<br/>
d) Garante que eventos sejam descartados após o uso.<br/>