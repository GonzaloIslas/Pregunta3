using Dapper;
using System.Collections.Generic;
using System.Linq;
using Tesis.Repository.Context;
using Tesis.Repository.Entity;
using Tesis.Repository.Interface;
using Tesis.Utilities.Enums;

namespace Tesis.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DapperContext _context;

        public QuestionRepository(DapperContext context)
        {
            _context = context;
        }

        //public List<Question> GetQuestions(CategoryType type)
        //{
        //    var query = @"SELECT [QuestionID]
        //                        ,[QuestionName]
        //                        ,[FinalInfo]
        //                        ,[CategoryType]
        //                    FROM [tesis].[dbo].[question]
        //                    Where [CategoryType] = @CategoryType";
        //    using (var connection = _context.CreateConnection())
        //    {
        //        var companies = connection.Query<Question>(query, new { type });
        //        return companies.ToList();
        //    }
        //}}

        public List<Question> GetQuestions(CategoryType type)
        {
            var id = 40;

            var query = @"SELECT [QuestionID]
                                ,[QuestionName]
                                ,[FinalInfo]
                                ,[CategoryType]
                            FROM [tesis].[dbo].[question]
                            Where [QuestionID] = @id";
            using (var connection = _context.CreateConnection())
            {
                var companies = connection.Query<Question>(query, new { id });
                return companies.ToList();
            }
        }


        public List<Question> GetQuestions()
        {
            var query = @"SELECT * FROM [tesis].[dbo].[question]";
            using (var connection = _context.CreateConnection())
            {
                var companies = connection.Query<Question>(query);
                return companies.ToList();
            }
        }
    }
}
