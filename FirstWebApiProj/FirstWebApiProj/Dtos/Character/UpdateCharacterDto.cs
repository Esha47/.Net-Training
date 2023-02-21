using FirstWebApiProj.Models;

namespace FirstWebApiProj.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Nazar";
        public int Hitpoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
