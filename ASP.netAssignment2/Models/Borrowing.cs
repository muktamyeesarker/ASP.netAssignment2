using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Borrowing
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int ReaderId { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}

