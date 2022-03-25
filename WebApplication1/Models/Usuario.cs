using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("FORMULARIO")]

    public class Usuario
    {
        [Display(Name = "ID_FUNDACAO")]
        [Column("ID_FUNDACAO")]
        public int Id { get; set; }


        [Display(Name = "NOME")]
        [Column("NOME")]
        public int Nome { get; set; }


        [Display(Name = "CNPJ")]
        [Column("CNPJ")]
        public int CNPJ { get; set; }


        [Display(Name = "EMAIL")]
        [Column("EMAIL")]
        public int EMAIL { get; set; }


        [Display(Name = "TELEFONE")]
        [Column("TELEFONE")]
        public int TELEFONE { get; set; }


        [Display(Name = "INSTITUICAO DE APOIO")]
        [Column("INSTITUICAO_APOIO")]
        public int INSTITUICAO_APOIO { get; set; }

    }
}