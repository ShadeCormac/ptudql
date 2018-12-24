using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.Utils
{
    class MyTimer
    {
        private System.Windows.Forms.Timer _timer;
        private long _second;

        public delegate void MyTimerTickHanler(long time);
        public delegate void MyTimerStopHandler(long time);
        public event MyTimerTickHanler onMyTimerTick;
        public event MyTimerStopHandler onMyTimerStop;

        public MyTimer(long second)
        {
            _second = second;
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Interval = 1000; // 1 second
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _second--;
            if (_second <= 0)
            {
                _timer.Stop();
                onMyTimerStop(_second);
            }
            else
            {
                onMyTimerTick(_second);
            }
        }
    }


}
