using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PollAPI.Models;

namespace PollAPI.Services
{
    public interface IPollRepository
    {
        IEnumerable<Question> GetQuestions();

    }
}
