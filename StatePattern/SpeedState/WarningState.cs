using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.StatePattern.SpeedState
{
    public class WarningState : State
    {
        public WarningState(State state)
        {
            thisCar = state.ThisCar;
            currentSpeed = state.CurrentSpeed;
            InitiLizeSpeedLimits();
        }

        private void InitiLizeSpeedLimits()
        {
            lowerLimit = 120;
            upperLimit = 140;
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
                thisCar.SpeedState = new WarningState(this);
            }
            if (thisCar.CurrentSpeed < lowerLimit)
            {
                thisCar.SpeedState = new FasterState(this);
            }

            Console.WriteLine("Car is in {0} state", thisCar.SpeedState.GetType().Name);
        }
    }
}
