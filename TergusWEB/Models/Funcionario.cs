using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TergusWEB.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "{0} deve está entre {2} e {1}.")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public string Data_de_nascimento { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "RG")]
        public string Rg { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Salário")]
        public double Salario { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Advogado?")]
        public bool Advogado { get; set; }
        [Display(Name = "Demitido?")]
        public bool Demitido { get; set; }
        [Display(Name = "Data da Demissão")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data_da_demissao { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Telefone 1")]
        public string telefone_1 { get; set; }
        [Display(Name = "Telefone 2")]
        public string telefone_2 { get; set; }
        [Display(Name = "Telefone 3")]
        public string telefone_3 { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public ICollection<Processo> Processos { get; set; }
        public Funcionario()
        {
        }
        public Funcionario(int id, string nome, string data_de_nascimento, string cpf, string rg, double salario, string usuario, string senha, bool advogado, bool demitido, DateTime data_da_demissao, string telefone_1, string telefone_2, string telefone_3)
        {
            Id = id;
            Nome = nome;
            Data_de_nascimento = data_de_nascimento;
            Cpf = cpf;
            Rg = rg;
            Salario = salario;
            Usuario = usuario;
            Senha = senha;
            Advogado = advogado;
            Demitido = demitido;
            Data_da_demissao = data_da_demissao;
            this.telefone_1 = telefone_1;
            this.telefone_2 = telefone_2;
            this.telefone_3 = telefone_3;
        }
    }
}
