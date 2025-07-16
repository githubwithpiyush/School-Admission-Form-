using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace StudentEntryForm.Models
{
    public partial class StudentDataDataContext : DataContext
    {
        public Table<Studentt> Students;

        public StudentDataDataContext()
            : base("Data Source=PIYUSH;Initial Catalog=StudentDB;Integrated Security=True")
        {
        }
    }
}
