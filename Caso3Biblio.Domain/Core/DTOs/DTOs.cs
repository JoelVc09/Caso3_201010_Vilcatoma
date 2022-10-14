using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3Biblio.Domain.Core.DTOs
{
    internal class DTOs
    {

        public class DoctorDTO
        {
            public int Doctor_id { get; set; }
            public string FullName { get; set; } = null!;
            public string DateOfBirth { get; set; } = null!;
            public string? CYearOfExperience { get; set; }

        }
    }
}
