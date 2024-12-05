Questionário - Conceitos de S.O.L.I.D.

1. Qual é o principal objetivo dos princípios S.O.L.I.D.?

A) Facilitar o uso de linguagens funcionais.
B) Reduzir o acoplamento e aumentar a flexibilidade e a manutenibilidade do software.
C) Eliminar a necessidade de testes de unidade.
D) Aumentar a complexidade dos sistemas.

Resposta correta: B

2. Quem unificou os princípios S.O.L.I.D.?

A) Bertrand Meyer
B) Barbara Liskov
C) Robert C. Martin (Uncle Bob)
D) Tom DeMarco

Resposta correta: C

3. Qual princípio afirma que "uma classe deve ter apenas uma razão para mudar"?

A) Princípio da Substituição de Liskov
B) Princípio da Responsabilidade Única
C) Princípio de Segregação de Interfaces
D) Princípio Aberto/Fechado

Resposta correta: B

4. Qual é um problema apontado no exemplo da classe LinhaExtrato que viola o SRP?

A) Ela não usa herança.
B) Ela possui vários atores solicitando alterações.
C) Ela implementa métodos desnecessários.
D) Ela é muito pequena para ser útil.

Resposta correta: B

5. O que significa o Princípio Aberto/Fechado?

A) Um sistema deve ser aberto para ser editado por qualquer desenvolvedor.
B) Um sistema deve estar aberto para modificação, mas fechado para extensão.
C) Um sistema deve estar aberto para extensão, mas fechado para modificação.
D) Um sistema não deve ser modificado após o deploy.

Resposta correta: C

6. Qual prática abaixo viola o Princípio Aberto/Fechado?

A) Uso de polimorfismo para estender funcionalidades.
B) Adição de novos tipos sem modificar classes existentes.
C) Adição de muitos if ou switch para tratar diferentes condições.
D) Criação de classes base específicas.

Resposta correta: C

7. Quem é uma das principais colaboradoras do Princípio de Substituição de Liskov?

A) Uncle Bob
B) Barbara Liskov
C) Tom DeMarco
D) Timothy Lister

Resposta correta: B

8. O Princípio de Substituição de Liskov garante que:

A) Classes base e derivadas possam ser usadas de forma intercambiável.
B) Uma classe deve ser aberta para extensão e fechada para modificação.
C) Classes derivadas devem implementar métodos não utilizados.
D) Interfaces devem ser segregadas em várias classes.

Resposta correta: A

9. Qual é um sintoma de violação do LSP?

A) Classes derivadas que precisam alterar o comportamento da classe base.
B) Uso de polimorfismo para especializar comportamentos.
C) Implementação de métodos em interfaces separadas.
D) Criação de múltiplas classes para tratar diferentes cenários.

Resposta correta: A

10. Qual prática evita a violação do LSP?

A) Utilizar herança sem critérios claros.
B) Garantir que as classes derivadas sejam especializações da classe base.
C) Alterar comportamentos diretamente na classe base.
D) Ignorar o uso de polimorfismo.

Resposta correta: B

11. O Princípio de Segregação de Interfaces afirma que:

A) Classes devem herdar de apenas uma interface.
B) Interfaces devem ser divididas em partes pequenas e específicas.
C) Classes devem implementar todas as interfaces disponíveis no sistema.
D) Interfaces devem ser grandes e abrangentes.

Resposta correta: B

12. Qual é um problema causado por interfaces grandes, segundo o ISP?

A) Reduz a reutilização do código.
B) Aumenta o acoplamento entre classes.
C) Dificulta a implementação de polimorfismo.
D) Torna o código menos modular.

Resposta correta: B

13. Qual é o principal benefício do Princípio Aberto/Fechado?

A) Reduz a coesão entre classes.
B) Facilita a manutenção e extensão do código.
C) Elimina a necessidade de testes de integração.
D) Permite alterações diretas em classes base.

Resposta correta: B

14. Qual prática é recomendada para aplicar o ISP?

A) Criar interfaces grandes com todos os métodos possíveis.
B) Dividir interfaces grandes em pequenas e específicas.
C) Implementar métodos vazios ou com exceções.
D) Utilizar classes genéricas para toda a aplicação.

Resposta correta: B

15. Qual é um impacto negativo de violar os princípios S.O.L.I.D.?

A) Código mais limpo e organizado.
B) Redução de erros e bugs.
C) Aumento da dificuldade de manutenção e testabilidade.
D) Extensibilidade facilitada do sistema.

Resposta correta: C

