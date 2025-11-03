using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.StatePattern
{
    public abstract class State
    {

        protected Car thisCar;

        public Car ThisCar
        {
            get
            {
                return thisCar;
            }
            set
            {
                thisCar = value;
            }
        }

        protected double currentSpeed;

        public double CurrentSpeed
        {
            get
            {
                return currentSpeed;
            }
            set
            {
                currentSpeed = value;
            }
        }

        protected double lowerLimit;
        protected double upperLimit;

        public abstract void IncreaseSpeed(double speed);
        public abstract void DecreaseSpeed(double speed);
        public abstract void ShowSpeedIndicator();
    }
}
