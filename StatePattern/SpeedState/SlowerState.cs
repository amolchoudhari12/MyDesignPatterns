using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.StatePattern.SpeedState
{
    public class SlowerState :State
    {
        public SlowerState(State state)
        {
            thisCar = state.ThisCar;
            currentSpeed = state.CurrentSpeed;
            InitiLizeSpeedLimits();
        }

        private void InitiLizeSpeedLimits()
        {
            lowerLimit = 0;
            upperLimit = 50;
        }

        public override void IncreaseSpeed(double speed)
        {
            thisCar.CurrentSpeed += speed;
        }

        public override void DecreaseSpeed(double speed)
        {
            thisCar.CurrentSpeed -= speed;
        }

        public override void ShowSpeedIndicator()
        {
            if (thisCar.CurrentSpeed > upperLimit)
            {
                thisCar.SpeedState = new NormalState(this);
            }
            if (thisCar.CurrentSpeed < lowerLimit)
            {
                thisCar.SpeedState = new StoppedState(this);
            }

            Console.WriteLine("Car is in {0} state", thisCar.SpeedState.GetType().Name);
        }
    }
}
