using FirstWebApiProj.Models;

namespace FirstWebApiProj.Service.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);

        List<Character> AddCharacter(Character newCharacter);
    }
}
