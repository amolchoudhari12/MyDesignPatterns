using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDesignPatterns.StatePattern.SpeedState
{
    public class NormalState : State
    {
        public NormalState(State state)
        {
            thisCar = state.ThisCar;
            currentSpeed = state.CurrentSpeed;
            InitiLizeSpeedLimits();
        }

        private void InitiLizeSpeedLimits()
        {
            lowerLimit = 50;
            upperLimit = 80;
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
                thisCar.SpeedState = new FasterState(this);
            }
            if (thisCar.CurrentSpeed < lowerLimit)
            {
                thisCar.SpeedState = new SlowerState(this);
            }

            Console.WriteLine("Car is in {0} state", thisCar.SpeedState.GetType().Name);
        }
    }
}
