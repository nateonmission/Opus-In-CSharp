using System;

namespace OpusInCSharp.Entities
{
    public record Author
    {
        public Guid id { get; init; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public Book[] books { get; set; }
        public string biogragphy { get; set; }
    }
}