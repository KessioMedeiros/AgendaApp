using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Entities
{
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Descricao { get; set; }
        public List<Tarefa>? Tarefas { get; set; }
    }
}
