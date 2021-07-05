using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorbittQuiz1
{
    class Gravity
    {
        private const double GRAV = 6.67408e-11;  //grav constant
        private double mass1;
        private double mass2;
        private double distance = -1.0; //init to -1 to stop div by zero error in calc prior to all values set        

        public double Force { get; private set; }
        public double Mass1
        {
            get
            {
                return mass1;
            }
            set
            {
                mass1 = value;
                calcForce();
            }
        }
        public double Mass2

        {
            get
            {
                return mass2;
            }
            set
            {
                mass2 = value;
                calcForce();
            }
        }
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
                calcForce();
            }
        }

        public void calcForce()
        {
            Force = GRAV * Mass1 * Mass2 / (Distance * Distance);
        }

    }
}

