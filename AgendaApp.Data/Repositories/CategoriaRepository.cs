using AgendaApp.Data.Contexts;
using AgendaApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Repositories
{
    public class CategoriaRepository
    {
        public List<Categoria> GetAll()
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Set<Categoria>().OrderBy(c => c.Descricao).ToList(); 
            } 
        }
    }
}
