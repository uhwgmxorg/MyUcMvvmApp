using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;

namespace MyUcMvvmAppExe
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region OnPropertyChanged Properties
        private String massageToUC;
        public String MassageToUC
        {
            get { return massageToUC; }
            set
            {
                if (value != MassageToUC)
                {
                    massageToUC = value;
                    OnPropertyChanged("MassageToUC");
                }
            }
        }

        private string buttonIncremenText;
        public string ButtonIncremenText
        {
            get { return buttonIncremenText; }
            set
            {
                if (value != ButtonIncremenText)
                {
                    buttonIncremenText = value;
                    OnPropertyChanged("ButtonIncremenText");
                };
            }
        }
        private string buttonDecrementText;
        public string ButtonDecrementText
        {
            get { return buttonDecrementText; }
            set
            {
                if (value != ButtonDecrementText)
                {
                    buttonDecrementText = value;
                    OnPropertyChanged("ButtonDecrementText");
                };
            }
        }
        private string buttonCloseText;
        public string ButtonCloseText
        {
            get { return buttonCloseText; }
            set
            {
                if (value != ButtonCloseText)
                {
                    buttonCloseText = value;
                    OnPropertyChanged("ButtonCloseText");
                };
            }
        }

        private MyUcDll.MyUserControlAction userControlAction;
        public MyUcDll.MyUserControlAction UserControlAction
        {
            get { return userControlAction; }
            set 
            {
                if (value != UserControlAction)
                {
                    userControlAction = value;
                    OnPropertyChanged("UserControlAction");
                };
            }
        }                
        #endregion

        /// <summary>
        /// Commands
        /// <summary>
        public RelayCommand IncrementCommand { get; private set; }
        public RelayCommand DecrementCommand { get; private set; }
        public RelayCommand CloseCommand { get; private set; }         


        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindowViewModel()
        {
            IncrementCommand = new RelayCommand(IncremenCommandCF, CanIncremenCommand);
            DecrementCommand = new RelayCommand(DecrementCommandCF, CanDecrementCommand);
            CloseCommand = new RelayCommand(CloseCommandCF, CanCloseCommand);

            MassageToUC = "Greetings from MainWindowViewModel to UserControl";
            UserControlAction = MyUcDll.MyUserControlAction.Instance;

            ButtonIncremenText = "Incremen Speed";
            ButtonDecrementText = "Decrement Speed";
            ButtonCloseText = "Close";
        }

        /******************************/
        /*      Button Functions      */
        /******************************/
        #region Button Command Functions

        /// <summary>
        /// IncremenCommandCF
        /// </summary>
        private void IncremenCommandCF()
        {
            int Ms = UserControlAction.Ms - 10;
            UserControlAction.ChangeRandomEventInterval(Ms);
            MassageToUC = String.Format("Delay is {0} ms", UserControlAction.Ms);
        }

        /// <summary>
        /// CanIncremenCommand
        /// </summary>
        /// <returns></returns>
        private bool CanIncremenCommand()
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void DecrementCommandCF()
        {
            int Ms = UserControlAction.Ms + 10;
            UserControlAction.ChangeRandomEventInterval(Ms);
            MassageToUC = String.Format("Delay is {0} ms", UserControlAction.Ms);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CanDecrementCommand()
        {
            return true;
        }

        /// <summary>
        /// CloseCommandCF
        /// </summary>
        private void CloseCommandCF()
        {
            App.Current.Shutdown();
        }

        /// <summary>
        /// CanCloseCommand
        /// </summary>
        /// <returns></returns>
        private bool CanCloseCommand()
        {
            return true;
        }

        #endregion
        /******************************/
        /*     Command Functions      */
        /******************************/
        #region Command Functions

        #endregion
        /******************************/
        /*      Menu Events          */
        /******************************/
        #region Menu Events

        #endregion
        /******************************/
        /*      Other Functions       */
        /******************************/
        #region Other Functions

        /// <summary>
        /// OnPropertyChanged
        /// </summary>
        /// <param name="p"></param>
        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }

        #endregion
    }
}
