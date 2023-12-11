using oop.Model;
using System;
using System.Windows;
using ViewModels.BaseClass;

namespace HamsterBatteryProject.ViewModels
{
        public class HamsterViewModel : ViewModelBase
        {
            private Hamster _hamster;

            public HamsterViewModel()
            {
                _hamster = new Hamster(1, 5, 200000);
                CalculationCommand = new RelayCommand(execute => Calculation());
            }
            public RelayCommand CalculationCommand { get; private set; }

            public double Number
            {
                get
                {
                    return _hamster.Number;
                }
                set
                {
                    double number = Convert.ToDouble(value);
                    _hamster.Number = number;
                }
            }
            public double Time
            {
                get
                {
                    return _hamster.Time;
                }

                set
                {
                    double time = Convert.ToDouble(value);
                    _hamster.Time = time;
                }
            }

            public double Consuption
            {
                get
                {
                    return _hamster.Consuption;
                }

                set
                {
                    double consuption = Convert.ToDouble(value);
                    _hamster.Consuption = consuption;
                }
            }

            public string EnergyOneDay
            {
                get
                {
                    double number = _hamster.Number;
                    double energy= _hamster.EnergyOneDay;
                    return number + " darab hörcsög egy nap alatt " + energy + " W energiát termel";
                }
            }

            public string EnergyOneMonth
            {
                get
                {
                    double number = _hamster.Number;
                    double energy = _hamster.EnergyOneMonth;
                    return number + " darab hörcsög egy hónap alatt " + energy + " W energiát termel";
                }
            }

            public string EnergyPercent
            {
                get
                {
                    double energypercent = _hamster.EnergyPercent;
                    return "A megtermelt energia a háztartás energia használtának " +energypercent+ "%-a";
                }
            }

            public string NumberOfHamsters
            {
                get
                {
                    double hamsterNumber = Math.Ceiling(_hamster.NumberOfHamsters);
                    double fullenergy = _hamster.Consuption;
                    return fullenergy +" W energia megtermeléséhez "+hamsterNumber+" db hörcsög szükséges";
                }
            }

            private void Calculation()
            {
                OnPropertyChanged(nameof(EnergyOneDay));
                OnPropertyChanged(nameof(EnergyOneMonth));
                OnPropertyChanged(nameof(EnergyPercent));
                OnPropertyChanged(nameof(NumberOfHamsters));
            }
        }
}
