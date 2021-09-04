using System.Collections.Generic;
using Tesis.Repository.Entity;

namespace Tesis.Repository.Interface
{
    public interface IAnswerRepository
    {
        List<Answer> GetAnswers(int questionId);
    }
}
