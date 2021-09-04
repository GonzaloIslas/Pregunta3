using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tesis.Repository.Entity;
using Tesis.Service.Interface;
using Tesis.Utilities;
using Tesis.Utilities.Enums;

namespace Tesis.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public ActionResult<Question> GetQuestion(CategoryType type)
        {
            var res = new ActionResult<Question>(_questionService.GetQuestion(type));

            return res;
        }

        [HttpGet]
        public ActionResult<bool> GetSetup()
        {
            var res = new ActionResult<bool>(_questionService.GetSetup());

            return res;
        }

        [HttpGet]
        public ActionResult<bool> MakeScript()
        {
            FileReader.MakeScript();

            return true;
        }

        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> GetCategories()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
