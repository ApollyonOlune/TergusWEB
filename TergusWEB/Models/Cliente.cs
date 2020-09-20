using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TergusWEB.Models
{
    public class Cliente
    {
        //informações basicas de cadastro
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Nome/Razão Social")]
       // [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [StringLength(200, MinimumLength =3, ErrorMessage ="{0} deve está entre {2} e {1}")]
        public string Nome_Razao_Social { get; set; }
        [Remote("CPFCNPJExiste", "Clientes")]
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "CPF/CNPJ")]
        public string CpfCNPJ { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "RG/Inscrição Estadual")]
        public string Rg_IE { get; set; }
      //  [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Data da Expedição")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_da_expedicao { get; set; }
     //   [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Afiliação 1")]
        public string Afiliacao1 { get; set; }
      //  [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Afiliação 2")]
        public string Afiliacao2 { get; set; }
      //  [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Naturalidade Cidade")]
        public string Naturalidade_cidade { get; set; }
      //  [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Naturalidade Estado")]
        public string Naturalidade_estado { get; set; }
       // [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_de_nascimento { get; set; }
        //[Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Número")]
        public string Numero { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Bairro { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Estado { get; set; }
        public string Complemento { get; set; }
        //informações basicas para controles do sistema
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Data do Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_do_cadastro { get; set; }
        public string Status { get; set; }
        [Display(Name = "Observação")]
        [DataType(DataType.MultilineText)]
        public string Observacao { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Telefone 1")]
        public string Telefone_1 { get; set; }
        [Display(Name = "Telefone 2")]
        public string Telefone_2 { get; set; }
        [Display(Name = "Telefone 3")]
        public string Telefone_3 { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        //Iclusão de PJ
       // [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Nome Fantasia")]
        public string Nome_Fantasia { get; set; }
        [Display(Name = "Inscrição Municipal")]
        public string Inscricao_Municipal { get; set; }
        public string Site { get; set; }
        [Display(Name = "Cliente Jurídico?")]
        public bool Cliente_Juridico { get; set; }
        public ICollection<Processo> Processos { get; set; } = new List<Processo>();
        public Cliente()
        { 
        }
        public Cliente(int id, string nome_Razao_Social, string cpfCNPJ, string rg_IE, string cep, string endereco, string numero, string bairro, string cidade, string estado, string complemento, DateTime data_do_cadastro, string status, string observacao, string telefone_1, string telefone_2, string telefone_3, string email, string nome_Fantasia, string inscricao_Municipal, string site, bool cliente_Juridico)
        {
            Id = id;
            Nome_Razao_Social = nome_Razao_Social;
            CpfCNPJ = cpfCNPJ;
            Rg_IE = rg_IE;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            Data_do_cadastro = data_do_cadastro;
            Status = status;
            Observacao = observacao;
            Telefone_1 = telefone_1;
            Telefone_2 = telefone_2;
            Telefone_3 = telefone_3;
            Email = email;
            Nome_Fantasia = nome_Fantasia;
            Inscricao_Municipal = inscricao_Municipal;
            Site = site;
            Cliente_Juridico = cliente_Juridico;
        }
        public Cliente(int id, string nome_Razao_Social, string cpfCNPJ, string rg_IE, DateTime data_da_expedicao, string afiliacao1, string afiliacao2, string naturalidade_cidade, string naturalidade_estado, DateTime data_de_nascimento, string cep, string endereco, string numero, string bairro, string cidade, string estado, string complemento, DateTime data_do_cadastro, string status, string observacao, string telefone_1, string telefone_2, string telefone_3, string email)
        {
            Id = id;
            Nome_Razao_Social = nome_Razao_Social;
            CpfCNPJ = cpfCNPJ;
            Rg_IE = rg_IE;
            Data_da_expedicao = data_da_expedicao;
            Afiliacao1 = afiliacao1;
            Afiliacao2 = afiliacao2;
            Naturalidade_cidade = naturalidade_cidade;
            Naturalidade_estado = naturalidade_estado;
            Data_de_nascimento = data_de_nascimento;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            Data_do_cadastro = data_do_cadastro;
            Status = status;
            Observacao = observacao;
            Telefone_1 = telefone_1;
            Telefone_2 = telefone_2;
            Telefone_3 = telefone_3;
            Email = email;
        }
        public Cliente(int id, string nome_Razao_Social, string cpfCNPJ, string rg_IE, DateTime data_da_expedicao, string afiliacao1, string afiliacao2, string naturalidade_cidade, string naturalidade_estado, DateTime data_de_nascimento, string cep, string endereco, string numero, string bairro, string cidade, string estado, string complemento, DateTime data_do_cadastro, string status, string observacao, string telefone_1, string telefone_2, string telefone_3, string email, string nome_Fantasia, string inscricao_Municipal, string site, bool cliente_Juridico)
        {
            Id = id;
            Nome_Razao_Social = nome_Razao_Social;
            CpfCNPJ = cpfCNPJ;
            Rg_IE = rg_IE;
            Data_da_expedicao = data_da_expedicao;
            Afiliacao1 = afiliacao1;
            Afiliacao2 = afiliacao2;
            Naturalidade_cidade = naturalidade_cidade;
            Naturalidade_estado = naturalidade_estado;
            Data_de_nascimento = data_de_nascimento;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            Data_do_cadastro = data_do_cadastro;
            Status = status;
            Observacao = observacao;
            Telefone_1 = telefone_1;
            Telefone_2 = telefone_2;
            Telefone_3 = telefone_3;
            Email = email;
            Nome_Fantasia = nome_Fantasia;
            Inscricao_Municipal = inscricao_Municipal;
            Site = site;
            Cliente_Juridico = cliente_Juridico;
        }
    }
}
