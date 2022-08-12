using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class EmployeeMock : EmployeeRepository
    {
        private readonly AppDbContext db;

        public EmployeeMock(AppDbContext db)
        {
            this.db = db;
        }

        public Contacting AddContact(Contacting contact)
        {
            db.contact.Add(contact);
            db.SaveChanges();
            return contact;
        }

        public Job_App AddJob(Job_App NewApp)
        {
            db.Apps.Add(NewApp);
            db.SaveChanges();
            return NewApp;
        }
        public newsLetters Addnews(newsLetters news)
        {
            db.newsLetters.Add(news);
            db.SaveChanges();
            return news;
        }

        public information info(int id)
        {
           return db.information.SingleOrDefault(i=>i.id==id); 
        }

        public IEnumerable<Contacting> showcontact()
        {
            return db.contact;
        }

        public IEnumerable<Job_App> showJobApps()
        {
            return db.Apps;
        }

        public IEnumerable<newsLetters> showNewsLetters()
        {
            return db.newsLetters;
        }

        public information UpdateInfo(information information)
        {
            var info = db.information.Attach(information);
            info.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return information;
        }
    }
}
