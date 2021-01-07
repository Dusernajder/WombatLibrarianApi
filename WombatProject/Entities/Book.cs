using System;
using System.Collections.Generic;

#nullable disable

namespace WombatLibrarianApi.Entities
{
    public partial class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public int? PageCount { get; set; }
        public double? Rating { get; set; }
        public double? RatingCount { get; set; }
        public string Language { get; set; }
        public int? CategoryId { get; set; }
        public string MaturityRating { get; set; }
        public string Published { get; set; }
        public string Publisher { get; set; }
    }
}
