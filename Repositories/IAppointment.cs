using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookTestAppointment.Models;

namespace BookTestAppointment.Repositories
{
    public interface IAppointment
    {
        public List<TestAppointment> Get();
        public int BookAppointment(TestAppointment t);
    }
}
