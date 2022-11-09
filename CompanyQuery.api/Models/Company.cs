using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyQuery.api.Models
{
    public class Company
    {
        [Key]
        public int CompanyId {get; set;}

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set;}


        [Column(TypeName = "nvarchar(50)")]
        public string CompanyName { get; set; }

        public string? Answers { get; set; }


    }
}
