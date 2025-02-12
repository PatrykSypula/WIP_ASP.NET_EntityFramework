﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASPNET.Models
{
    public class SubscribedDictionary
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        public int UserId { get; set; }
        [Column(TypeName = "int")]
        public int DictionaryId { get; set; }

        public User User { get; set; }
        public Dictionaries Dictionary { get; set; }

    }
}
