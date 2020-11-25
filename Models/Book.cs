﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WombatLibrarianApi.Models
{
    public class Book
    {
        public string Id { get; set; }
        public List<Author> Authors { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public double Rating { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        public string MaturityRating { get; set; }
        public int Published { get; set; }
        public string Publisher { get; set; }
    
        public override string ToString() => JsonSerializer.Serialize<Book>(this);
    }
}
