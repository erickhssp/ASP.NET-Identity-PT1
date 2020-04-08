using System;
using System.ComponentModel.DataAnnotations;

namespace ByteBank.Forum.ViewModels
{
    public class ContaRegistrarViewModel
    {
        [Required]

        public String UserName { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        public String NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Senha { get; set; }

    }
}