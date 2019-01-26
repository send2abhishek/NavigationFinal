
using SQLite;

namespace NavigationFinal
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Degination { get; set; }
        public int age { get; set; } 
    }
}
