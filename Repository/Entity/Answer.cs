namespace Tesis.Repository.Entity
{
    public class Answer
    {
        public int QuestionId { get; set; }

        public string AnswerName { get; set; }

        public bool IsCorrect { get; set; }
    }
}