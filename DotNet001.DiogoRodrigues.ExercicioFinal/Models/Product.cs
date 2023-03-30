using System.Text.Json.Serialization;

namespace DotNet001.DiogoRodrigues.ExercicioFinal.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
