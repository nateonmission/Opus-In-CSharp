using System;

namespace OpusInCSharp.Entities
{
    public record Publisher
    {
        public Guid id { get; init; }
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public Book[] books { get; set; }
        public string notes { get; set; }
    }
}