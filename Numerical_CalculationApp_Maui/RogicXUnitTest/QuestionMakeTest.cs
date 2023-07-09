using Numerical_CalculationApp_Maui.Rogic.DataSave;
using Numerical_CalculationApp_Maui.Rogic.QuestionMake;

namespace RogicXUnitTest
{
    public class QuestionMakeTest
    {

        [Fact(DisplayName = "AdditionTest")]
        public void AddtionTest()
        {
        }

        [Fact(DisplayName = "Save&LoadTest")]
        public void SaveLoadTest()
        {
            var sampleResult = new ResultsOfCalculated()
            {
                DigitNumber = 2,
                NumberOfProbrems = 10,
                OperationSign = "Addition",
                ResultTime = 100.53
            };

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TestDataFile");
            var resultSaveOperate = new ResultSaveOperate(filePath);
            _ = resultSaveOperate.DataSave(sampleResult);
            var Datas = resultSaveOperate.DatasLoad(1);
            Assert.True(sampleResult.DigitNumber == Datas.Result.First().DigitNumber);

        }
    }
}