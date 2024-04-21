using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLTest.Models;

namespace SQLTest.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection connection;
        
        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }
        public void init()
        {
            connection = new SQLiteConnection(this.dbPath);
            connection.CreateTable<StudentClass>();
        }
        public List<StudentClass> getAllStudents() {
            init();
            return connection.Table<StudentClass>().ToList();
        }
        public void Add(StudentClass student)
        {
            connection = new SQLiteConnection(this.dbPath);
            connection.Insert(student);
        }
        public void Delete(int student_ID) {
            connection = new SQLiteConnection(this.dbPath);
            connection.Delete(new StudentClass {ID = student_ID});
        }
    }
}
