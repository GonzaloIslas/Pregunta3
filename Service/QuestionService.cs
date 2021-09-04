using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Repository.Entity;
using Tesis.Repository.Interface;
using Tesis.Service.Interface;
using Tesis.Utilities;
using Tesis.Utilities.Enums;

namespace Tesis.Service
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerService _answerService;

        public QuestionService(IQuestionRepository questionRepository, IAnswerService answerService)
        {
            _questionRepository = questionRepository;
            _answerService = answerService;
        }

        public Question GetQuestion(CategoryType type)
        {
            var questionList = _questionRepository.GetQuestions(type);

            var random = new Random();

            var index = random.Next(questionList.Count);

            var result = questionList[index];

            result.AnswerList = _answerService.GetAnswers(result.QuestionId);

            result.AnswerList.Shuffle();
            result.AnswerList.Shuffle();
            result.AnswerList.Shuffle();
            result.AnswerList.Shuffle();
            result.AnswerList.Shuffle();

            return result;
        }

        public bool GetSetup()
        {
            var res = _questionRepository.GetQuestions();

            return res.Any();
        }
    }
}
