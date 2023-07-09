using Numerical_CalculationApp_Maui.Rogic.QuestionMake;
namespace TestCalkLationCommandApp;

public class Program
{

    public static void Main()
    {
        QuestionOperate questionOperate = new QuestionOperate();

        var numOfQuestion = int.Parse(Console.ReadLine());
        var operate = byte.Parse(Console.ReadLine());
        var digits = int.Parse(Console.ReadLine());

        var _ = questionOperate.MakeQuestion(numOfQuestion, operate, digits);


        var timeOfQuestion = 0;
        while(questionOperate.HasQuestion())
        {
            timeOfQuestion++;
            Console.WriteLine($"{timeOfQuestion:F0}問め");
            Console.WriteLine($"{questionOperate.GetQuestion():F0} =");

            var answer = long.Parse(Console.ReadLine());

            while(answer != questionOperate.GetCorrectAnswer())
            {
                Console.WriteLine($"{answer:F0}は間違いです．もう一度入力してください．");
                answer = long.Parse(Console.ReadLine());
            }

            Console.WriteLine("正解です.");
            questionOperate.GoNextQuestion();
        }

        Console.WriteLine("すべての問題に正解しました．");
    }
}
