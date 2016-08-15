using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC_BIKE.DTO
{
    public class ClienteDTO
    {
        private int codigo;
        private string nomeCliente;
        private string empresa;
        private string cpf_cnpj; //'varchar(14) COLLATE latin1_bin DEFAULT NULL COMMENT 'CPF - 11 DIGITOS OBRIGATORIOS\nCNPJ - 14 DIGITOS OBRIGATÓRIO',
        private string email;
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string uf;
        private string celular1;
        private string telFixo1;
        private string celular2;
        private string telFixo2;
        private string whatsApp;
        private int usuarios_idUsuario;
        private DateTime dataCadastro;
        private DateTime dataUltimaAtualizacao;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Cpf_cnpj
        {
            get { return cpf_cnpj; }
            set { cpf_cnpj = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Celular1
        {
            get { return celular1; }
            set { celular1 = value; }
        }

        public string TelFixo1
        {
            get { return telFixo1; }
            set { telFixo1 = value; }
        }

        public string Celular2
        {
            get { return celular2; }
            set { celular2 = value; }
        }

        public string TelFixo2
        {
            get { return telFixo2; }
            set { telFixo2 = value; }
        }

        public string WhatsApp
        {
            get { return whatsApp; }
            set { whatsApp = value; }
        }

        public int Usuarios_idUsuario
        {
            get { return usuarios_idUsuario; }
            set { usuarios_idUsuario = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public DateTime DataUltimaAtualizacao
        {
            get { return dataUltimaAtualizacao; }
            set { dataUltimaAtualizacao = value; }
        }

    }
}
