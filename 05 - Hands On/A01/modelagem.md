# Criar modelagem para orientação a dominio para Cadastro de contas.

- Contas devem possibilitar titular e dependentes
- Contas devem ter endereço e telefone para contato
- Gerentes PF chamam o titular de titular
- Gerentes PJ chamam o titular de administrador
- Dependentes só podem ser adicionados após a conta ser criada

## Validações

cpf e cnpj válidos
endereço deve receber todas as informações ou nenhuma

## Campos

### dados do titular e / ou dependente

cpf = texto 11 digitos
Nome do Cliente = texto 300 digitos
Nome da Mae do Cliente = texto 300 digitos

### dados da conta 

Agencia = texto 4 digitos
Matricula do gerente da abertura da conta = texto 10 digitos
Data abertura da conta = data

### dados da conta apenas para PJ

cnpj = texto 14 digitos
Data da Constituicao = data
Nome Fantasia = texto 300 digitos
Valor do Capital Social = decimal

### dados do endereço

cep = texto 8 digitos
endereço = texto 300 digitos
numero = texto 5 digitos
cidade = texto 300 digitos
estado = texto 100 digitos

# dados para contato
numero telefone = texto 14 digitos 
tipo telefone


