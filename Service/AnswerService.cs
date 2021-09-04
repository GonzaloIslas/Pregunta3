using System;
using System.Collections.Generic;
using Tesis.Repository.Entity;
using Tesis.Repository.Interface;
using Tesis.Service.Interface;

namespace Tesis.Service
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public List<Answer> GetAnswers(int questionId)
        {
            return _answerRepository.GetAnswers(questionId);
        }
    }
}
