namespace Numerical_CalculationApp_Maui.Rogic.QuestionMake
{
    public class QuestionDatas
    {
        public QuestionDatas(string question, int answer)
        {
            _question = question;
            _answer = answer;
        }
        private string _question;
        public string Question => _question;

        private long _answer;
        public long Answer { get { return _answer; } }

    }
}
