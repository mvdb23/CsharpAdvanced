using System.ComponentModel.DataAnnotations;

namespace CsharpAdvanced23_24.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

        public bool IsCover { get; set; }
    }
}
