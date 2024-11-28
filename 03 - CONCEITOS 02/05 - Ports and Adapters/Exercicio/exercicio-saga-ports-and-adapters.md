1. Qual é o principal objetivo do padrão Saga em sistemas distribuídos?

A) Reduzir a latência das chamadas REST<br/>
B) Melhorar a segurança entre microsserviços<br/>
C) Coordenar etapas de uma transação distribuída e lidar com falhas<br/>
D) Evitar a comunicação entre microsserviços<br/>

2. No padrão Saga, o que ocorre quando uma etapa falha?

A) Todo o sistema para até que a falha seja resolvida<br/>
B) O orquestrador encerra a saga imediatamente<br/>
C) O orquestrador inicia um processo de compensação para reverter as operações anteriores<br/>
D) O erro é ignorado para continuar as etapas restantes<br/>

3. Qual dos seguintes exemplos ilustra melhor a aplicação do padrão Saga?

A) Atualização de um banco de dados centralizado<br/>
B) Coordenação de um pedido de e-commerce, desde pagamento até entrega<br/>
C) Envio de uma única mensagem entre dois serviços<br/>
D) Processamento de dados em tempo real em um pipeline<br/>

4. Qual é a diferença fundamental entre orquestração e coreografia no padrão Saga?

A) Coreografia não utiliza microsserviços, enquanto orquestração utiliza<br/>
B) Orquestração é síncrona, enquanto coreografia é assíncrona<br/>
C) Na orquestração, um orquestrador central gerencia as etapas; na coreografia, os serviços decidem de forma independente<br/>
D) Coreografia é mais eficiente que orquestração em todos os cenários<br/>

5. Ao utilizar comunicação síncrona (REST), qual estratégia pode ajudar em caso de falha na comunicação?

A) Ignorar o erro e continuar a execução<br/>
B) Implementar mecanismos de retry, como backoff exponencial<br/>
C) Utilizar apenas chamadas HTTP GET<br/>
D) Garantir que todos os serviços estejam sempre disponíveis<br/>

6. Qual é uma vantagem do uso de filas em sistemas distribuídos?

A) Menor uso de memória em microsserviços<br/>
B) Redução de erros em tempo de execução<br/>
C) Maior resiliência, pois as mensagens são armazenadas até que o serviço esteja disponível<br/>
D) Garantia de que todas as mensagens serão entregues imediatamente<br/>

7. O que é um tópico de erros em um sistema baseado em filas?

A) Uma lista de logs gerados pelos serviços<br/>
B) Um local onde falhas de compensação são registradas para monitoramento e resolução<br/>
C) Uma funcionalidade de backup de dados sensíveis<br/>
D) Um mecanismo que ignora mensagens com erro<br/>

8. Por que sistemas modernos utilizam comunicação assíncrona entre microsserviços?

A) Para eliminar a necessidade de monitoramento<br/>
B) Para aumentar a resiliência e desacoplar os serviços<br/>
C) Para evitar o uso de bancos de dados independentes<br/>
D) Para garantir respostas imediatas entre os serviços<br/>

9. Qual é a principal desvantagem da comunicação síncrona entre serviços?

A) Alto consumo de recursos de hardware<br/>
B) Dependência da disponibilidade imediata dos serviços chamados<br/>
C) Complexidade na implementação de retries<br/>
D) Redução da escalabilidade do sistema<br/>

10. Na Arquitetura Hexagonal, o que os “Ports” representam?

A) Conexões diretas com o banco de dados<br/>
B) Classes que implementam lógica de negócio<br/>
C) Pontos de comunicação entre a aplicação e o mundo externo<br/>
D) Serviços que gerenciam os dados da aplicação<br/>

11. Qual é a principal vantagem da Arquitetura Hexagonal?

A) Redução do tempo de desenvolvimento inicial<br/>
B) Flexibilidade para substituir tecnologias externas sem afetar o núcleo do sistema<br/>
C) Simplicidade na estrutura do código<br/>
D) Menor consumo de recursos no runtime<br/>

12. Como a Arquitetura Hexagonal melhora a testabilidade de sistemas?

A) Fornecendo um modelo único para testes integrados<br/>
B) Ao isolar as interações tecnológicas em Adapters, permitindo testes independentes do núcleo do sistema<br/>
C) Garantindo que todas as classes sejam mockadas<br/>
D) Substituindo o Domain Layer por uma implementação simplificada<br/>

13. O que é o Infrastructure Layer na Arquitetura Hexagonal?

A) A camada onde ficam as regras de negócio<br/>
B) A camada que permite a comunicação com o mundo externo, como bancos de dados e APIs externas<br/>
C) A camada que gerencia as transações distribuídas<br/>
D) A camada que conecta o Domain diretamente à interface do usuário<br/>

14. Qual dos seguintes cenários seria mais adequado para aplicar a Arquitetura Hexagonal?

A) Um sistema monolítico com poucas interações externas<br/>
B) Um sistema de microsserviços que precisa trocar tecnologias de armazenamento frequentemente<br/>
C) Uma aplicação com lógica de negócio trivial e poucos pontos de integração<br/>
D) Uma aplicação estática que não será alterada no futuro<br/>

15. Quais são as principais desvantagens da Arquitetura Hexagonal?

A) Redução da flexibilidade e aumento de bugs<br/>
B) Necessidade de frameworks proprietários e maior dependência externa<br/>
C) Mais esforço inicial para implementar abstrações e risco de overengineering<br/>
D) Dificuldade em gerenciar interações entre microsserviços<br/>