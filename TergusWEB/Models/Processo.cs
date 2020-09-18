using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TergusWEB.Models.Enums;

namespace TergusWEB.Models
{
    public class Processo
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "ID Cliente")]
        public int Id_cliente { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Número do Processo")]
        public string Numero_do_processo { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public StatusProcesso Status { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Foro { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Display(Name = "Valor da Ação")]
        public float Valor_da_acao { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name ="Competência")]
        public string Competencia { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Classe { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Assunto Principal")]
        public string Assunto_principal { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Outros Assuntos")]
        public string Outros_asssuntos { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Grau { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Ré")]
        public string Re { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Autor { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Testemunha { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Advogado { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public string Vara { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        public PortalDoProcesso Portal { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Processo()
        {
        }

        public Processo(int id, int id_cliente, string numero_do_processo, StatusProcesso status, string foro, float valor_da_acao, string competencia, string classe, string assunto_principal, string outros_asssuntos, string grau, string re, string autor, string testemunha, string advogado, string vara, PortalDoProcesso portal)
        {
            Id = id;
            Id_cliente = id_cliente;
            Numero_do_processo = numero_do_processo;
            Status = status;
            Foro = foro;
            Valor_da_acao = valor_da_acao;
            Competencia = competencia;
            Classe = classe;
            Assunto_principal = assunto_principal;
            Outros_asssuntos = outros_asssuntos;
            Grau = grau;
            Re = re;
            Autor = autor;
            Testemunha = testemunha;
            Advogado = advogado;
            Vara = vara;
            Portal = portal;
        }
    }
}
