﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_API.Data
{
    [Table("Authors")]
    public partial class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
    public class AuthorCreateDTO
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }
    public class AuthorUpdateDTO
    {
        //[Required]
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }
}
