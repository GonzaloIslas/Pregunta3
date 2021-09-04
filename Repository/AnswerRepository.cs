using Dapper;
using System.Collections.Generic;
using System.Linq;
using Tesis.Repository.Context;
using Tesis.Repository.Entity;
using Tesis.Repository.Interface;

namespace Tesis.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly DapperContext _context;

        public AnswerRepository(DapperContext context)
        {
            _context = context;
        }


        public List<Answer> GetAnswers(int questionId)
        {
            var query = @"SELECT [QuestionID]
                                ,[AnswerName]
                                ,[IsCorrect]
                            FROM [tesis].[dbo].[answer]
                            where QuestionID = @questionId";
            using (var connection = _context.CreateConnection())
            {
                var answerList = connection.Query<Answer>(query, new { questionId });
                return answerList.ToList();
            }
        }
    }
}
