using System.Collections.Generic;
using Tesis.Repository.Entity;

namespace Tesis.Service.Interface
{
    public interface IAnswerService
    {
        List<Answer> GetAnswers(int questionId);
    }
}
