
namespace mvcPractica.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum TypeContact
    {
        PhoneNumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN
    }
    public class Practica
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        public string Contact { get; set; }
       


    }
}