using FirstWebApiProj.Models;

namespace FirstWebApiProj.Service.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponsive<List<Character>>> GetAllCharacters();
        Task<ServiceResponsive<Character>> GetCharacterById(int id);
        Task<ServiceResponsive<List<Character>>> AddCharacter(Character newCharacter);
    }
}
