using AgendaApp.Data.Entities;
using AgendaApp.WebAPI.Dtos;
using AutoMapper;

namespace AgendaApp.WebAPI.Mappings
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            //Copiar os dados da classe 'categoria' para a classe 'categoriaResponseDto'
            CreateMap<Categoria, CategoriaResponseDto>();
        }
    }
}
