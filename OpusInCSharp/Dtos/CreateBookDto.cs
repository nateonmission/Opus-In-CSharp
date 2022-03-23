using System;

namespace OpusInCSharp.Dtos
{

 public record CreateBookDto
    {
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public string isbn13 { get; set; }
    }

}

