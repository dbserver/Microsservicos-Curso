﻿using Domain.Dtos;

namespace Domain.CadastroClientePF.Entidades
{
    public class ContaPJ : IRaizDeAgregacao
    {
		private string agencia;
		private string matriculaGerente;
		private DateTime dataAbertura;
		private List<ClientePF> clientes = new List<ClientePF>();

        public ContaPJ(CriadorContaPF criadorConta)
        {
            // Validações

            agencia = criadorConta.Agencia;
            matriculaGerente = criadorConta.MatriculaGerente;
            dataAbertura = DateTime.Now;
        }

        public void AdicionarTitular(CriadorContaPF criadorConta)
        {
            var titular = new ClientePF(criadorConta);
            titular.IdentificarTitular();

            clientes.Add(titular);
        }
    }
}
