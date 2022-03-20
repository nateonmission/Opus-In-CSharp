using System;

namespace OpusInCSharp.Entities
{


    public record Book
    {

        public Guid id { get; init; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string isbn { get; set; }
        public string isbn13 { get; set; }
        public string description { get; set; }


    }


    
}
