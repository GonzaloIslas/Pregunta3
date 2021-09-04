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
        public ActionResult<bool> IsSettedUp()
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
    }
}
