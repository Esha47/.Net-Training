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

        public async Task<ServiceResponsive<List<Character>>> AddCharacter(Character newCharacter)
        {
            ServiceResponsive<List<Character>> serviceResponsive = new ServiceResponsive<List<Character>>();
            characters.Add(newCharacter);
            serviceResponsive.Data = characters;
            return serviceResponsive;
        }

        public async Task<ServiceResponsive<List<Character>>> GetAllCharacters()
        {
            ServiceResponsive<List<Character>> serviceResponsive = new ServiceResponsive<List<Character>>();
            serviceResponsive.Data = characters;
            return serviceResponsive;
        }

        public async Task<ServiceResponsive<Character>> GetCharacterById(int id)
        {
            ServiceResponsive<Character> serviceResponsive = new ServiceResponsive<Character>();
            serviceResponsive.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceResponsive;
        }
    }
}
