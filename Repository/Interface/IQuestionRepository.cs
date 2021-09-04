using System.Collections.Generic;
using Tesis.Repository.Entity;
using Tesis.Utilities.Enums;

namespace Tesis.Repository.Interface
{
    public interface IQuestionRepository
    {
        List<Question> GetQuestions(CategoryType type);

        List<Question> GetQuestions();
    }
}
