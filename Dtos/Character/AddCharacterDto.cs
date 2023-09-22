namespace test.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Jaifan";
        public int HitPoint { get; set; } = 100;
        public MvpClass Class { get; set; } = MvpClass.frontend;
    }
}