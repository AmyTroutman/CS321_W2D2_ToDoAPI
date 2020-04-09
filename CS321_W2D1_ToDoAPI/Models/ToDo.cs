using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W2D2_ToDoAPI.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="As much as you may want to, you can't do nothing.")]
        [MaxLength(80, ErrorMessage ="Description should be no more than 80 characters.")]
        public string Description { get; set; }

        public bool IsComplete { get; set; }

        public DateTime DueDate { get; set; }
    }
}
