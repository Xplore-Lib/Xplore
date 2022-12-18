using Xplore.Enums;

namespace Xplore.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Book Book { get; set; }  
    }
}
