using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    //create a model for our commands
    public class CommandCreateDto
    {

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

    }
}