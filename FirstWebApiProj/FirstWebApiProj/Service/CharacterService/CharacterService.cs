using FirstWebApiProj.Controllers;
using FirstWebApiProj.Models;

namespace FirstWebApiProj.Service.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> // for the list of the characters
        {
            new Character(), // this is default that we are created in Character Model
            new Character{ Id=3, Name = "Hussain"},
            new Character{ Name = "Malik"}
        };
        
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
