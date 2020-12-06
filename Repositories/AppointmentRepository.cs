using BookTestAppointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTestAppointment.Repositories
{
    public class AppointmentRepository:IAppointment
    {
        private static readonly List<TestAppointment> testAppointments = new List<TestAppointment>(){};
        public List<TestAppointment> Get()
        {
            return testAppointments;
        }
        public int BookAppointment(TestAppointment t)
        {
            try
            {
                testAppointments.Add(t);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
