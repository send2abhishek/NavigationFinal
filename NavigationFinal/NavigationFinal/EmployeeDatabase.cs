using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NavigationFinal
{
    public class EmployeeDatabase
    {
        readonly SQLiteAsyncConnection database;

        public EmployeeDatabase(String dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<Employee>().Wait();
        }

        //Get All employee's

        public Task<List<Employee>> getEmployeesAysnc()
        {
            //it will fetch all data of Employee table
            return database.Table<Employee>().ToListAsync();
        }

        //get Specfic Employee
        public Task<Employee> getEmployeesAysnc(int id)
        {
            return database.Table<Employee>().Where(i => i.EmpId==id).FirstOrDefaultAsync();
        }

        //Inserting Data to Table

        public Task<int> SaveEmployeeAsync(Employee employee)
        {
            if (employee.EmpId != 0)
            {

                return database.UpdateAsync(employee);

            }
            else
            {
                return database.InsertAsync(employee);
            }
        }

        //delete operation
        public Task<int> DeleteEmployeeAsync(Employee employee)
        {
            return database.DeleteAsync(employee);
        }
    }
}
