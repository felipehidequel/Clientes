using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClientesSystem.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Column("Phone")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Column("Status")]
        [Display(Name = "Status")]
        public int Status { get; set; }
        [Column("Birthdate")]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }
        [Column("Cep")]
        [Display(Name = "Cep")]
        public string Cep { get; set; }
        [Column("Street")]
        [Display(Name = "Street")]
        public string Street { get; set; }
        [Column("Number")]
        [Display(Name = "Number")]
        public string Number { get; set; }
        [Column("Complement")]
        [Display(Name = "Complement")]
        public string Complement { get; set; }
        [Column("Neighborhood")]
        [Display(Name = "Neighborhood")]
        public string Neighborhood { get; set; }
        [Column("City")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Column("State")]
        [Display(Name = "State")]
        public string State { get; set; }
    }
}