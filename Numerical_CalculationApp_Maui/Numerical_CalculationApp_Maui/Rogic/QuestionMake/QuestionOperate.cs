using Numerical_CalculationApp_Maui.Rogic.DataSave;
using System.Collections.ObjectModel;

namespace Numerical_CalculationApp_Maui.Rogic.QuestionMake
{
    public class QuestionOperate
    {
        public QuestionOperate()
        {
            _nowQuestionData = MakeQuestion();
            _answerdQuestionData = _nowQuestionData;
        }
        private QuestionDatas _nowQuestionData;
        public string GetNowQuestion => _nowQuestionData.Question;
        public long GetNowQuestionAnswer() => _nowQuestionData.Answer;
        private bool IsTrueAnswer(long answer) => _nowQuestionData.Answer == answer;

        private OperatorAndLevelSaverAndGetter _operatorAndLevelSaverAndGetter = new();
        private int nowLevel { get { return _operatorAndLevelSaverAndGetter.GetLevel; } }

        private bool isAddition { get { return _operatorAndLevelSaverAndGetter.IsAddition; } }
        private bool isSubtraction { get { return _operatorAndLevelSaverAndGetter.IsSubtraction; } }
        private bool isMultplication { get { return _operatorAndLevelSaverAndGetter.IsMultiprication; } }
        private bool isDivision { get { return _operatorAndLevelSaverAndGetter.IsDivision; } }

        private QuestionDatas _answerdQuestionData;
        public string GetAnswerdQuestion() => _answerdQuestionData.Question;

        private QuestionDatas MakeQuestion()
        {
            var tOperatorNum = 0;
            if (isAddition) tOperatorNum++;
            if (isSubtraction) tOperatorNum++;
            if (isMultplication) tOperatorNum++;
            if (isDivision) tOperatorNum++;

            if(tOperatorNum > 0)
            {
                var OperatorNum = new Random().Next(tOperatorNum);
                var operatorLength = (int)Math.Pow(10, LevelToOperatorlength(nowLevel));

                if (isAddition && OperatorNum == 0)
                    return QuestionMake.AdditionMake(operatorLength);
                else if(OperatorNum == 0) OperatorNum++;
                if (isSubtraction && OperatorNum == 1)
                    return QuestionMake.SubtractionMake(operatorLength);
                else if(OperatorNum == 1) OperatorNum++;
                if (isMultplication && OperatorNum == 2)
                    return QuestionMake.MultiplicationQuestionMake(operatorLength);
                else if(OperatorNum == 2) OperatorNum++;
                if (isDivision&& OperatorNum == 3)
                    return QuestionMake.DivisionQuestionMake(operatorLength);

            }

                return QuestionMake.AdditionMake(1);
        }

        private int LevelToOperatorlength(int level) 
        {
            return level;
        }

        public bool AnswerToQuestion(long answer)
        {
            if(IsTrueAnswer(answer))
            {
                _answerdQuestionData = _nowQuestionData;
                _nowQuestionData = MakeQuestion();
                return true;
            }

            return false;
        }
    }
}
