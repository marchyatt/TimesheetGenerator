using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimesheetGenerator.Models
{
    public class Timesheet
    {
        public int ID { get; set; }

        [Display(Name = "Candidate Name"), StringLength(60, MinimumLength = 3)]
        [Required]
        public string CandidateName { get; set; }

        [Display(Name = "Client Name"), StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClientName { get; set; }

        [Display(Name = "Job Title"), StringLength(60, MinimumLength = 3)]
        [Required]
        public string JobTitle { get; set; }

        [Display(Name = "Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime EndDate { get; set; }

        [Display(Name = "Placement Type")]
        public int PlacementType { get; set; }
    }
}
