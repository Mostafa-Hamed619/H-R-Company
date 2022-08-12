using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public interface EmployeeRepository
    {
        public Contacting AddContact(Contacting contact);
        public newsLetters Addnews(newsLetters news);
        public information info(int id);
        public Job_App AddJob(Job_App NewApp);
        public IEnumerable<Contacting> showcontact();
        public IEnumerable<newsLetters> showNewsLetters();
        public IEnumerable<Job_App> showJobApps();
        public information UpdateInfo(information information);
    }
}
