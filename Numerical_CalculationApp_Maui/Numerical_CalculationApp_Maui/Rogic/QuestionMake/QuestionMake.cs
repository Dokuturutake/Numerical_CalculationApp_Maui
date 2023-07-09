namespace Numerical_CalculationApp_Maui.Rogic.QuestionMake
{
    public static class QuestionMake
    {

        public static QuestionDatas AdditionMake(int maxNum)
        {
            var random = new Random();
            var _firstNum = random.Next(0, maxNum);
            var _secondNum = random.Next(0, maxNum);
            var _answer = _firstNum + _secondNum;
            return new QuestionDatas($"{_firstNum:F0} + {_secondNum:F0}", _answer);
        }

        public static QuestionDatas SubtractionMake(int maxNum)
        {
            var random = new Random();
            var _firstNum = random.Next(0, maxNum);
            var _secondNum = random.Next(0, _firstNum);
            var _answer = _firstNum - _secondNum;
            return new QuestionDatas($"{_firstNum:F0} - {_secondNum:F0}", _answer);
        }

        public static QuestionDatas MultiplicationQuestionMake(int maxNum)
        {
            var random = new Random();
            var _firstNum = random.Next(0, maxNum);
            var _secondNum = random.Next(0, maxNum);
            var _answer = _firstNum * _secondNum;
            return new QuestionDatas($"{_firstNum:F0} × {_secondNum:F0}", _answer);
        }

        public static QuestionDatas DivisionQuestionMake(int maxNum)
        {
            var random = new Random();
            var _secondNum = random.Next(1, maxNum);
            var _answer = random.Next(0, maxNum);
            var _firstNum = _answer * _secondNum;
            return new QuestionDatas($"{_firstNum:F0} ÷ {_secondNum:F0}", _answer);
        }
    }
}
