using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebApp_Desafio_FrontEnd.ViewModels
{
    [DataContract]
    public class ChamadoViewModel
    {
        private CultureInfo ptBR = new CultureInfo("pt-BR");

        [Display(Name = "ID")]
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Assunto")]
        [DataMember(Name = "Assunto")]
        [StringLength(128, MinimumLength = 1, ErrorMessage = "O campo Assunto deve ter entre 1 e 128 caracteres.")]
        public string Assunto { get; set; }

        [Display(Name = "Solicitante")]
        [DataMember(Name = "Solicitante")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo Solicitante deve ter entre 2 e 50 caracteres.")]
        public string Solicitante { get; set; }

        [Display(Name = "IdDepartamento")]
        [DataMember(Name = "IdDepartamento")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Somente números são permitidos.")]
        [Range(0, 100, ErrorMessage = "Por favor, insira um número válido.")]
        public int IdDepartamento { get; set; }

        [Display(Name = "Departamento")]
        [DataMember(Name = "Departamento")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo Solicitante deve ter entre 2 e 50 caracteres.")]
        public string Departamento { get; set; }

        [Display(Name = "DataAbertura")]
        [DataMember(Name = "DataAbertura")]
        public DateTime DataAbertura { get; set; }

        [DataMember(Name = "DataAberturaWrapper")]
        public string DataAberturaWrapper
        {
            get
            {
                return DataAbertura.ToString("d", ptBR);
            }
            set
            {
                DataAbertura = DateTime.Parse(value, ptBR);
            }
        }
    }
}
