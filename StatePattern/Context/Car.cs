using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDesignPatterns.StatePattern.SpeedState;

namespace MyDesignPatterns.StatePattern
{
    public class Car
    {
        public Car(string name)
        {
            this.CarName = name;
            this.state = new StoppedState(0, this);
        }

        private State state;

        public State SpeedState
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public double CurrentSpeed { get; set; }

        public string CarName { get; set; }

        public void IncreaseSpeed(double speed)
        {
            SpeedState.IncreaseSpeed(speed);
            SpeedState.ShowSpeedIndicator();
          
        }

        public void DecreaseSpeed(double speed)
        {
            SpeedState.DecreaseSpeed(speed);
            SpeedState.ShowSpeedIndicator();
        }
    }
}
