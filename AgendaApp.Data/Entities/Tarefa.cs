using AgendaApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Entities
{
    public class Tarefa
    {
        public Guid? Id { get; set; }
        public string?  Nome { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan? Hora { get; set; }
        public PrioridadeTarefa? Prioridade { get; set; }
        public Guid? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
