using System;


namespace C_fundamental3
{

    public class ClockPublisher
    {
        //create delegate
        public delegate void SecondChangeHandler(ClockPublisher clockPublisher, Clock time);
        
        
        //create event based on delegate
        public event SecondChangeHandler SecondChange;
        
        //create method to fire event
        public void OnSecondChange(ClockPublisher clockPublisher, Clock time)
        {
            SecondChange(clockPublisher, time);
        }

        //set up clock running
        //on each second it will raise an event to display clock
        public void Run() {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                var dateTime = DateTime.Now;
                Clock time = new Clock(dateTime.Hour, dateTime.Minute, dateTime.Second);
                OnSecondChange(this, time);
            }
        }
    }
}