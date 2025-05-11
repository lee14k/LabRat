using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabRat.Server.Models
{
    [Table("booking_status")]
    public class SubjectArea
    {
        [Key]
        [Column("status_id")]
        public int StatusId { get; set; }
        
        [Required]
        [Column("status_code")]
        public string StatusCode { get; set; }
        
        [Required]
        [Column("description")]
        public string Description { get; set; }
        
        public const string Hematology = "pending";
        public const string ClinicalChemistry = "confirmed";
        public const string Microbiology = "cancelled";
        public const string BloodBank = "checked_in";
        public const string Immunology = "checked_out";
        public const string LabOperations = "no_show";
        public const string MolecularBiology = "completed";
    }
}