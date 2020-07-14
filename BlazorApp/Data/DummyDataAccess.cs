using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class DummyDataAccess : IDataAccess
    {
        private int age;

        public DummyDataAccess()
        {
            Random rnd = new Random();
            age = rnd.Next(1, 10);

        }
        public int GetUserAge()
        {
            return age;
        }
    }
}
