using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.DataVisualization.Charting;

namespace WpfAppTest.ViewModel
{
   public  class ParametersViewModel: ViewModelBase
    {

      public    KeyValuePair<int, int>[] Lines { get; set; }
       
        private double  _min = 0.05;
        public double Min
        {
            get { return _min; }
            set
            {
                _min = value;

                RaisePropertyChanged("Min");
                SaveCmd.RaiseCanExecuteChanged();
            }
        }
        private double _max = 0.15;
        public double Max
        {
            get { return _max; }
            set
            {
                _max = value;

                RaisePropertyChanged("Max");
                SaveCmd .RaiseCanExecuteChanged();
            }
        }
        private double _durationMax =110;
        public double DurationMax
        {
            get { return _durationMax; }
            set
            {
                _durationMax = value;

                RaisePropertyChanged("DurationMax");
                SaveCmd.RaiseCanExecuteChanged();
            }
        }
        private double _durationMin = 70;
        public double DurationMin
        {
            get { return _durationMin; }
            set
            {
                _max = value;

                RaisePropertyChanged("DurationMin");
                SaveCmd.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand SaveCmd
        {
            get;
            private set;
        }
        public ParametersViewModel()
        {
            LoadLineChartData();
            SaveCmd = new RelayCommand(ExecuteMyCommand,CanExecuteMyCommand);
        }
        private void ExecuteMyCommand()
        {
            MessengerInstance.Send("dddd");
        }

        private bool CanExecuteMyCommand()
        {
            return Min < Max;
        }
        private void LoadLineChartData()
        {
            // ((LineSeries)mcChart.Series[0]).ItemsSource =
            Lines=  new KeyValuePair<int, int>[]{
        new KeyValuePair<int,int>(1, 100),
        new KeyValuePair<int,int>(2, 130),
        new KeyValuePair<int,int>(3, 200),
       new KeyValuePair<int,int>(4, 10),
          new KeyValuePair<int,int>(5, 20),
          new KeyValuePair<int,int>(6, 100),
        new KeyValuePair<int,int>(7, 130),
        new KeyValuePair<int,int>(8, 150),
       new KeyValuePair<int,int>(9, 125),
          new KeyValuePair<int,int>(10, 100),
          new KeyValuePair<int,int>(11, 10),
        new KeyValuePair<int,int>(12, 20),
        new KeyValuePair<int,int>(13, 150),
       new KeyValuePair<int,int>(14, 125),
          new KeyValuePair<int,int>(15, 100),
          new KeyValuePair<int,int>(16, 100),
        new KeyValuePair<int,int>(17, 130),
        new KeyValuePair<int,int>(18, 10),
       new KeyValuePair<int,int>(19, 125),
          new KeyValuePair<int,int>(20, 100),
        new KeyValuePair<int,int>(5,155) };
        }
    }
}
