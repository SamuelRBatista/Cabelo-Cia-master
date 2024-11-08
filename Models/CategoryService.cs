using System.ComponentModel;

namespace MyApp.Models
{
    public class CategoryService
    {
        public int Id { get; set; }

        [DisplayName("Serviço")]
        public string Name { get; set; }
        // Other relevant properties
    }
}
