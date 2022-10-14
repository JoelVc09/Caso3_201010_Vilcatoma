using System;
using System.Collections.Generic;

namespace Caso3Biblio.Domain.Infraestructure.Data
{
    public partial class Doctor
    {
        public int DoctorId { get; set; }
        public string? FullName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? YearOfExperience { get; set; }
    }
}
