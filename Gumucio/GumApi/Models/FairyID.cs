


namespace GumApi.Models
{
    using System.ComponentModel.DataAnnotations;

    public class FairyID
    {
        [Key]
        public int Fairy { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Birthdate { get; set; }
    }
}