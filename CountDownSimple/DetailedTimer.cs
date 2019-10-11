using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownSimple
{
    public class DetailedTimer
    {
        private Timer timerSecond = new Timer();
        private TimeSpan span = new TimeSpan();
        private DateTime targetTime = new DateTime();

        /// <summary>
        /// Fires when the Day property changes
        /// </summary>
        public event EventHandler OnDayChange;
        private void DayChange()
        {
            EventHandler handler = OnDayChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when the Hour property changes
        /// </summary>
        public event EventHandler OnHourChange;
        public void HourChange()
        {
            EventHandler handler = OnHourChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when the Minute property changes
        /// </summary>
        public event EventHandler OnMinuteChange;
        public void MinuteChange()
        {
            EventHandler handler = OnMinuteChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when the Second property changes
        /// </summary>
        public event EventHandler OnSecondChange;
        public void SecondChange()
        {
            EventHandler handler = OnSecondChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when timer reaches 0
        /// </summary>
        public event EventHandler OnTimerDone;
        public void TimerDone()
        {
            EventHandler handler = OnTimerDone;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Returns True or False depending on if the timer is running
        /// </summary>
        public bool IsRunning
        {
            get { return timerSecond.Enabled; }
        }

        public int Days
        {
            get { return span.Days; }
        }

        public int Hours
        {
            get { return span.Hours; }
        }

        public int Minutes
        {
            get { return span.Minutes; }
        }
        
        public int Seconds
        {
            get { return span.Seconds; }
        }

        /// <summary>
        /// Creates a new instance of DetailedTimer
        /// </summary>
        public DetailedTimer()
        {
            timerSecond.Interval = 1000;
            timerSecond.Tick += timerSecond_Tick;
        }

        /// <summary>
        /// Creates a new instance of DetailedTimer
        /// </summary>
        /// <param name="hour">Set hours</param>
        /// <param name="minute">Set minutes</param>
        /// <param name="second">Set seconds</param>
        public DetailedTimer(DateTime endTime)
            : this()
        {
            targetTime = endTime;
        }

        void timerSecond_Tick(object sender, EventArgs e)
        {
            TimeSpan oldSpan = new TimeSpan(span.Ticks);
            span = targetTime - DateTime.Now;

            if (span.Ticks <= 0)
            {
                Stop();
                span = new TimeSpan();
            }

            if (oldSpan.Days != span.Days)
                DayChange();
            if (oldSpan.Hours != span.Hours)
                HourChange();
            if (oldSpan.Minutes != span.Minutes)
                MinuteChange();

            SecondChange();
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        public void Start()
        {
            timerSecond.Start();
        }

        public void Start(DateTime targetTime)
        {
            this.targetTime = targetTime;
            timerSecond.Start();
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        public void Stop()
        {
            timerSecond.Stop();
        }
    }
}