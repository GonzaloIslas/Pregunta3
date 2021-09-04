using System.Collections.Generic;
using Tesis.Repository.Entity;
using Tesis.Utilities.Enums;

namespace Tesis.Service.Interface
{
    public interface IQuestionService
    {
        Question GetQuestion(CategoryType type);

        bool GetSetup();
    }
}
