namespace BandsMvc.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } // Sökvägen till bandets bild

        public Band(int id, string name, string description, string imagePath)
        {
            Id = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;
        }
    }
}
