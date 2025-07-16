using System;
using System.Data.Linq.Mapping;

namespace StudentEntryForm.Models
{
    [System.Data.Linq.Mapping.Table(Name = "Students")]
    public class Studentt
    {
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [System.Data.Linq.Mapping.Column]
        public string FirstName { get; set; }

        [System.Data.Linq.Mapping.Column]
        public string LastName { get; set; }

        [System.Data.Linq.Mapping.Column]
        public string Grade { get; set; }

        [System.Data.Linq.Mapping.Column]
        public string SchoolName { get; set; }
    }
}
