using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PollAPI.Models;

namespace PollAPI.Services
{
    public class PollRepository : IPollRepository
    {
        public IEnumerable<Question> GetQuestions()
        {
            return null;
        }
    }
}
