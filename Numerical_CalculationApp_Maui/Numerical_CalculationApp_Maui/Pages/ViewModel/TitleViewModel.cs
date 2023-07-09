using Numerical_CalculationApp_Maui.Rogic.DataSave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Numerical_CalculationApp_Maui.ViewModel;

class TitleViewModel : INotifyPropertyChanged
{
    private OperatorAndLevelSaverAndGetter _operatorAndLevelSaverAndGetter = new();

    public TitleViewModel() {
        StartButtonCommand = new Command(
            () =>
            {
                PressStertButton();
            });
    }

    public int Lebel { get => _operatorAndLevelSaverAndGetter.GetLevel;
        set { 
            if(_operatorAndLevelSaverAndGetter.GetLevel != value)
            {
                _operatorAndLevelSaverAndGetter.GetLevel = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand StartButtonCommand { get; private set; }

    private void PressStertButton()
    {
        _operatorAndLevelSaverAndGetter.SaveNowOperatorAndLevel();
    }

    #region OperatorsSet
    public bool IsAddition
    {
        get => _operatorAndLevelSaverAndGetter.IsAddition;
        set
        {
            if (_operatorAndLevelSaverAndGetter.IsAddition != value)
            {
                _operatorAndLevelSaverAndGetter.IsAddition = value;
                OnPropertyChanged();
            }
        }
    }

    public bool IsSubtraction
    {
        get => _operatorAndLevelSaverAndGetter.IsSubtraction;
        set
        {
            if(_operatorAndLevelSaverAndGetter.IsSubtraction != value)
            {
                _operatorAndLevelSaverAndGetter.IsSubtraction = value;
                OnPropertyChanged();
            }
        }
    }

    public bool IsMultiplication
    {
        get => _operatorAndLevelSaverAndGetter.IsMultiprication;
        set
        {
            if(_operatorAndLevelSaverAndGetter.IsMultiprication != value)
            {
                _operatorAndLevelSaverAndGetter.IsMultiprication = value;
                OnPropertyChanged();
            }
        }
    }

    public bool IsDivision
    {
        get => _operatorAndLevelSaverAndGetter.IsDivision;
        set
        {
            if(_operatorAndLevelSaverAndGetter.IsDivision != value)
            {
                _operatorAndLevelSaverAndGetter.IsDivision = value;
                OnPropertyChanged();
            }
        }
    }
    #endregion

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
