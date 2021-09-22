using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
 

namespace PollAPI.Models
{
    public class PollDbContext : DbContext
    {
        public PollDbContext(DbContextOptions<PollDbContext> options)
        : base(options)
        {
            LoadQuestions();
            LoadUsers();
        }
        /// <summary>
        /// Veritabanı yerine Entity Core un UseInMemoryDatabase özelliği kullanıldığı için burada user ve örnek 1 soru tanımlandı.
        /// </summary>
        private void LoadQuestions()
        {
            
            Question question = new()
            {
                Answers = new List<Answer> { new Answer
                {
                    AnswerID = 1,
                    IsTrue = false,
                    SelectedTime = 0,
                    Text = "yanlış cevap"
                } },
                QuestionID = 1,
                QuestionText = "Bu doğru mu?"
            };
            Questions.Add(question);
        }


       
        private void LoadUsers()
        {
            User userAdmin = new()
            {
                IsAdmin = true,
                Name = "Kion Admin",
                Id = "1",
                UserName = "admin",
                Password = "test"
            };
            User userEnd = new() {
                IsAdmin = false,
                
                Name="Hasan Bakan",
                Id="2",
                UserName="hbakan",
                Password="123qweasd"

            };
            Userss.Add(userAdmin);
            Userss.Add(userEnd);
        }

        public List<User> GetUsers()
        {
            return Userss.Local.ToList<User>();
        }
        public List<Question> GetQuestions()
        {
            return Questions.Local.ToList<Question>();
        }

        public DbSet<User> Userss { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
