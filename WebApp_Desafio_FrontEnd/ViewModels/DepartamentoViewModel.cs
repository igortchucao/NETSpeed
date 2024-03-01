using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace WebApp_Desafio_FrontEnd.ViewModels
{
    [DataContract]
    public class DepartamentoViewModel
    {
        [Display(Name = "ID")]
        [DataMember(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Descricao")]
        [DataMember(Name = "Descricao")]
        [StringLength(128, MinimumLength = 1, ErrorMessage = "O campo Descrição deve ter entre 1 e 128 caracteres.")]
        public string Descricao { get; set; }

    }
}
