using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab_3___app.Models
{
    public class Travel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę podróży!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długa nazwa podróży, max 50 znaków!")]
        [Display(Name = "Nazwa podróży:")]
        public string Name { get; set; }

        [Display(Name = "Data rozpoczęcia:")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Data zakończenia:")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Miejsce początkowe:")]
        public string StartingLocation { get; set; }

        [Display(Name = "Cel podróży:")]
        public string Destination { get; set; }

        [Display(Name = "Uczestnicy:")]
        public string Participants { get; set; }

        [Display(Name = "Przewodnik:")]
        public string Guide { get; set; }

        public int? OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
