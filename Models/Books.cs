using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publicated_at { get; set; }
        public string Publisher { get; set; }
        public bool Available { get; set; }

        public void Update(string title, string author, string publicated_at, string publisher, bool availabe)
        {
            Title = title;
            Author = author;
            Publicated_at = publicated_at;
            Publisher = publisher;
            Available = availabe;
        }
    }
}