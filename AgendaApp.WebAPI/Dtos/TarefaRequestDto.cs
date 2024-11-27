using System.ComponentModel.DataAnnotations;

namespace AgendaApp.WebAPI.Dtos
{
    /// <summary>
    /// Modelo de dados para cadastro / edição de tarefa
    /// </summary>
    public class TarefaRequestDto
    {
        [Required(ErrorMessage ="Por favor, informe o nome da tarefa.")]
        [MinLength(4, ErrorMessage = "Informe um nome com pelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe um nome no máximo {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da tarefa.")]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}")]
        public string? Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe a hora da tarefa.")]
        [RegularExpression(@"\d{2}:\d{2}")]
        public string? Hora { get; set; }

        [Required(ErrorMessage = "Por favor, informe a prioridade da tarefa.")]
        public int? Prioridade { get; set; }

        [Required(ErrorMessage = "Por favor, informe a categoria tarefa.")]
        public Guid? CategoriaId { get; set; }


    }
}
