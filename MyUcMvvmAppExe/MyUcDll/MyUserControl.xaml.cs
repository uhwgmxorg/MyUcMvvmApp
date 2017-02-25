using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MyUcDll
{
    /// <summary>
    /// Interaktionslogik für MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        #region INotifyPropertyChanged Properties
        private Visibility event1Green;
        public Visibility Event1Green
        {
            get { return event1Green; }
            set
            {
                if (value != Event1Green)
                {
                    event1Green = value;
                    OnPropertyChanged("Event1Green");
                }
            }
        }
        private Visibility event1Red;
        public Visibility Event1Red
        {
            get { return event1Red; }
            set
            {
                if (value != Event1Red)
                {
                    event1Red = value;
                    OnPropertyChanged("Event1Red");
                }
            }
        }
        private String labeEventText1;
        public String LabeEventText1
        {
            get { return labeEventText1; }
            set
            {
                if (value != LabeEventText1)
                {
                    labeEventText1 = value;
                    OnPropertyChanged("LabeEvent1");
                }
            }
        }

        private Visibility event2Green;
        public Visibility Event2Green
        {
            get { return event2Green; }
            set
            {
                if (value != Event2Green)
                {
                    event2Green = value;
                    OnPropertyChanged("Event2Green");
                }
            }
        }
        private Visibility event2Red;
        public Visibility Event2Red
        {
            get { return event2Red; }
            set
            {
                if (value != Event2Red)
                {
                    event2Red = value;
                    OnPropertyChanged("Event2Red");
                }
            }
        }
        private String labeEventText2;
        public String LabeEventText2
        {
            get { return labeEventText2; }
            set
            {
                if (value != LabeEventText2)
                {
                    labeEventText2 = value;
                    OnPropertyChanged("LabeEvent2");
                }
            }
        }

        private Visibility event3Green;
        public Visibility Event3Green
        {
            get { return event3Green; }
            set
            {
                if (value != Event3Green)
                {
                    event3Green = value;
                    OnPropertyChanged("Event3Green");
                }
            }
        }
        private Visibility event3Red;
        public Visibility Event3Red
        {
            get { return event3Red; }
            set
            {
                if (value != Event3Red)
                {
                    event3Red = value;
                    OnPropertyChanged("Event3Red");
                }
            }
        }
        private String labeEventText3;
        public String LabeEventText3
        {
            get { return labeEventText3; }
            set
            {
                if (value != LabeEventText3)
                {
                    labeEventText3 = value;
                    OnPropertyChanged("LabeEvent3");
                }
            }
        }

        private Visibility event4Green;
        public Visibility Event4Green
        {
            get { return event4Green; }
            set
            {
                if (value != Event4Green)
                {
                    event4Green = value;
                    OnPropertyChanged("Event4Green");
                }
            }
        }
        private Visibility event4Red;
        public Visibility Event4Red
        {
            get { return event4Red; }
            set
            {
                if (value != Event4Red)
                {
                    event4Red = value;
                    OnPropertyChanged("Event4Red");
                }
            }
        }
        private String labeEventText4;
        public String LabeEventText4
        {
            get { return labeEventText4; }
            set
            {
                if (value != LabeEventText4)
                {
                    labeEventText4 = value;
                    OnPropertyChanged("LabeEvent4");
                }
            }
        }

        private Visibility event5Green;
        public Visibility Event5Green
        {
            get { return event5Green; }
            set
            {
                if (value != Event5Green)
                {
                    event5Green = value;
                    OnPropertyChanged("Event5Green");
                }
            }
        }
        private Visibility event5Red;
        public Visibility Event5Red
        {
            get { return event5Red; }
            set
            {
                if (value != Event5Red)
                {
                    event5Red = value;
                    OnPropertyChanged("Event5Red");
                }
            }
        }
        private String labeEventText5;
        public String LabeEventText5
        {
            get { return labeEventText5; }
            set
            {
                if (value != LabeEventText5)
                {
                    labeEventText5 = value;
                    OnPropertyChanged("LabeEvent5");
                }
            }
        }
        #endregion


        /// <summary>
        /// DependencyProperties
        /// </summary>
        public String RecivedMassage
        {
            get { return (String)GetValue(RecivedMassageProperty); }
            set { SetValue(RecivedMassageProperty, value); }
        }
        public static readonly DependencyProperty RecivedMassageProperty =
            DependencyProperty.Register("RecivedMassage", typeof(string), typeof(MyUserControl), new PropertyMetadata(""));
        public MyUserControlAction MyUserControlActionObj
        {
            get
            {
                return (MyUserControlAction)GetValue(MyUserControlActionProperty);
            }
            set { SetValue(MyUserControlActionProperty, value); }
        }
        public static readonly DependencyProperty MyUserControlActionProperty =
            DependencyProperty.Register("MyUserControlActionObj", typeof(MyUserControlAction), typeof(MyUserControl), new PropertyMetadata(null));

        /// <summary>
        /// Constructor
        /// </summary>
        public MyUserControl()
        {
            InitializeComponent();
            DataContext = this;

            RecivedMassage = "I am the UserControl";
            MyUserControlActionObj = MyUcDll.MyUserControlAction.Instance;

            SetEventSignalText("Even 1","Even 2","Even 3","Even 4","Even 5");

            InitEvents(MyUserControlActionObj);
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~MyUserControl()
        {
        }

        /******************************/
        /*       Button Events        */
        /******************************/
        #region Button Events

        #endregion
        /******************************/
        /*      Menu Events          */
        /******************************/
        #region Menu Events

        #endregion
        /******************************/
        /*      Other Events          */
        /******************************/
        #region Other Events

        #endregion
        /******************************/
        /*      Other Functions       */
        /******************************/
        #region Other Functions

        #region Singnal Event Idicators

        /// <summary>
        /// SetEventSignal1
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal1(bool state)
        {
            if (state)
            {
                Event1Green = Visibility.Hidden;
                Event1Red = Visibility.Visible;
            }
            else
            {
                Event1Green = Visibility.Visible;
                Event1Red = Visibility.Hidden;
            }
        }

        /// <summary>
        /// SetEventSignal2
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal2(bool state)
        {
            if (state)
            {
                Event2Green = Visibility.Hidden;
                Event2Red = Visibility.Visible;
            }
            else
            {
                Event2Green = Visibility.Visible;
                Event2Red = Visibility.Hidden;
            }
        }

        /// <summary>
        /// SetEventSignal3
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal3(bool state)
        {
            if (state)
            {
                Event3Green = Visibility.Hidden;
                Event3Red = Visibility.Visible;
            }
            else
            {
                Event3Green = Visibility.Visible;
                Event3Red = Visibility.Hidden;
            }
        }

        /// <summary>
        /// SetEventSignal4
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal4(bool state)
        {
            if (state)
            {
                Event4Green = Visibility.Hidden;
                Event4Red = Visibility.Visible;
            }
            else
            {
                Event4Green = Visibility.Visible;
                Event4Red = Visibility.Hidden;
            }
        }

        /// <summary>
        /// SetEventSignal5
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal5(bool state)
        {
            if (state)
            {
                Event5Green = Visibility.Hidden;
                Event5Red = Visibility.Visible;
            }
            else
            {
                Event5Green = Visibility.Visible;
                Event5Red = Visibility.Hidden;
            }
        }

        #endregion

        /// <summary>
        /// SetEventSignalText
        /// </summary>
        /// <param name="setext1"></param>
        /// <param name="setext2"></param>
        /// <param name="setext3"></param>
        /// <param name="setext4"></param>
        /// <param name="setext5"></param>
        public void SetEventSignalText(string setext1, string setext2, string setext3, string setext4, string setext5)
        {
            LabeEventText1 = setext1;
            LabeEventText2 = setext2;
            LabeEventText3 = setext3;
            LabeEventText4 = setext4;
            LabeEventText5 = setext5;
        }

        /// <summary>
        /// InitEvents
        /// </summary>
        /// <param name="myUserControlAction"></param>
        public void InitEvents(MyUserControlAction myUserControlAction)
        {
            if (myUserControlAction != null)
            {
                myUserControlAction.SignalEvent1 += SetEventSignal1;
                myUserControlAction.SignalEvent2 += SetEventSignal2;
                myUserControlAction.SignalEvent3 += SetEventSignal3;
                myUserControlAction.SignalEvent4 += SetEventSignal4;
                myUserControlAction.SignalEvent5 += SetEventSignal5;
            }
        }

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

    public class MyUserControlAction
    {

        private static MyUserControlAction instance;

        public static MyUserControlAction Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyUserControlAction();
                }
                return instance;
            }
        }

        private Random _random = new Random();

        public delegate void SignalEventHandler(bool state);
        public event SignalEventHandler SignalEvent1;
        public event SignalEventHandler SignalEvent2;
        public event SignalEventHandler SignalEvent3;
        public event SignalEventHandler SignalEvent4;
        public event SignalEventHandler SignalEvent5;

        private DispatcherTimer _dispatcherRandomEvent = null;

        public int Ms { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        private MyUserControlAction()
        {
            InitAndStartRandomEvent(250);
        }

        /// <summary>
        /// InitAndStartRandomEvent
        /// </summary>
        private void InitAndStartRandomEvent(int ms = 1000)
        {
            Ms = ms;
            _dispatcherRandomEvent = new DispatcherTimer();
            _dispatcherRandomEvent.Tick += new EventHandler(DispatcherRandomEvent);
            _dispatcherRandomEvent.Interval = new TimeSpan(0, 0, 0, 0, Ms);
            _dispatcherRandomEvent.Start();
        }

        /// <summary>
        /// DispatcherRandomEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatcherRandomEvent(object sender, EventArgs e)
        {
            SetEventSignal1(RandomDouble(0, 100, 0) <= 50 ? true : false);
            SetEventSignal2(RandomDouble(0, 100, 0) <= 50 ? true : false);
            SetEventSignal3(RandomDouble(0, 100, 0) <= 50 ? true : false);
            SetEventSignal4(RandomDouble(0, 100, 0) <= 50 ? true : false);
            SetEventSignal5(RandomDouble(0, 100, 0) <= 50 ? true : false);
        }

        #region private Set Singnal Events

        /// <summary>
        /// SetEventSignal1
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal1(bool state)
        {
            if (SignalEvent1 != null) SignalEvent1(state);
        }

        /// <summary>
        /// SetEventSignal2
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal2(bool state)
        {
            if (SignalEvent2 != null) SignalEvent2(state);
        }

        /// <summary>
        /// SetEventSignal3
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal3(bool state)
        {
            if (SignalEvent3 != null) SignalEvent3(state);
        }

        /// <summary>
        /// SetEventSignal4
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal4(bool state)
        {
            if (SignalEvent4 != null) SignalEvent4(state);
        }

        /// <summary>
        /// SetEventSignal5
        /// True is Red
        /// </summary>
        /// <param name="state"></param>
        private void SetEventSignal5(bool state)
        {
            if (SignalEvent5 != null) SignalEvent5(state);
        }

        #endregion

        /// <summary>
        /// RandomDouble
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="deci"></param>
        /// <returns></returns>
        private double RandomDouble(double min, double max, int deci)
        {
            double d;
            d = _random.NextDouble() * (max - min) + min;
            return Math.Round(d, deci);
        }

        /// <summary>
        /// ChangeRandomEventInterval
        /// </summary>
        /// <param name="ms"></param>
        public void ChangeRandomEventInterval(int ms = 500)
        {
            if (ms < 100)
            {
                ms = 100;
                Console.Beep();
            }
            Ms = ms;
            _dispatcherRandomEvent.Stop();
            _dispatcherRandomEvent.Interval = new TimeSpan(0, 0, 0, 0, Ms);
            _dispatcherRandomEvent.Start();
        }
    }
}
