using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Email do contato")]
        [EmailAddress(ErrorMessage = "Email informado não existe")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Celular do contato")]
        [Phone(ErrorMessage ="Celular informado não existe")]
        public string Celular { get; set; }

    }
}
