using AutoMapper;
using FirstWebApiProj.Dtos.Character;
using FirstWebApiProj.Models;

namespace FirstWebApiProj
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Character, GetCharacterDto>(); //automapper for getting data
            CreateMap<AddCharacterDto, Character>(); //automapper for adding data
        }
    }
}
