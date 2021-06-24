using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WADWebsite.Models
{
    public class Festival
    {
        [Key]
        public Int16 FestivalID { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string FestivalName { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Location { get; set; }

        [Required]
        [Column(TypeName = "varchar(35)")]
        public string TicketType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(28, 0)")]
        public decimal TicketPrice { get; set; }

        [Required]
        public bool CampingIncluded { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string LineupLink { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string FestivalImage { get; set; }
    }
}
