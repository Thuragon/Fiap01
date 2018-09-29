using System.ComponentModel.DataAnnotations;

namespace Fiap01.Models
{
    public class Pergunta
    {
        public Pergunta()
        {
        }

        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string Autor { get; set; }
    }
}