namespace RazorLibrary.Models
{
    public class QuestionAndAnswerModel
    {
        public int QuestionId { get; set; }
        public string Question { get; set; } = String.Empty;
        public string Answer { get; set; } = String.Empty;
        public Image AnswerImage { get; set; }
        public int Points { get; set; }
        public bool Show { get; set; }
        public QuestionTypeEnum TypeEnum { get; set; }
    }

    public enum QuestionTypeEnum
    {
        None,
        Siltums1,
        Siltums2,
    }

}
