namespace PokemonReviewApp.Models
{
    public class pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BrithDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
