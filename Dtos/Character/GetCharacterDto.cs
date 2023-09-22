namespace test.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Jaifan";
        public int HitPoint { get; set; } = 100;
        public MvpClass Class { get; set; } = MvpClass.frontend;
    }
}