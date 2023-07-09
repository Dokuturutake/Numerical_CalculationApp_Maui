using Numerical_CalculationApp_Maui.Rogic.DataSave;
using Numerical_CalculationApp_Maui.Rogic.QuestionMake;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Numerical_CalculationApp_Maui.ViewModel
{
    class CalculationPageViewModel : INotifyPropertyChanged
    {
        private readonly QuestionOperate _questionOperate = new();

        public CalculationPageViewModel()
        {
            AddCharCommand = new Command<string>((key) => InputString += key);

            DeleteCharCommand = new Command(
                () => InputString = InputString[..^1],
                () => InputString.Length > 0
                );

            AnswerCheckCommand = new Command(
                () => Answer(long.Parse(InputString)),
                () => InputString.Length > 0);

        }

        #region Question

        public string NowQuestion
        {
            get => _questionOperate.GetNowQuestion;
        }

        public string AnswerdQuestion
        {
            get => _questionOperate.GetAnswerdQuestion();
        }

        void Answer(long answer)
        {
            if(_questionOperate.AnswerToQuestion(answer))
            {
                InputString = "";
                OnPropertyChanged(nameof(AnswerdQuestion));
                OnPropertyChanged(nameof(NowQuestion));
            }
        }



        #endregion

        #region テンキー
        public event PropertyChangedEventHandler PropertyChanged;


        public ICommand AddCharCommand { get; private set; }
        public ICommand DeleteCharCommand { get; private set; }
        public ICommand AnswerCheckCommand { get; private set; }

        private string _inputString = "";
        private string _displayText = "";
        private readonly int maxDigit = 16;


        public string InputString
        {
            get => _inputString;
            private set
            {
                if (_inputString != value && value.Length < maxDigit)
                {
                    _inputString = value;
                    OnPropertyChanged();
                    DisplayText = CalculationPageViewModel.FormatText(_inputString);
                    ((Command)DeleteCharCommand).ChangeCanExecute();
                    ((Command)AnswerCheckCommand).ChangeCanExecute();
                }
            }
        }

        public string DisplayText
        {
            get => _displayText;
            private set
            {
                if (_displayText != value)
                {
                    _displayText = value;
                    OnPropertyChanged();
                }
            }
        }

        static string FormatText(string str)
        {
            string formatted = str;

            return formatted;
        }

        #endregion


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
