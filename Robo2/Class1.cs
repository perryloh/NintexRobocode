using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;

namespace Nintex
{
    public class Viva :Robot
    {

        public override void Run()
        {
            // -- Initialization of the robot --

            // Here we turn the robot to point upwards, and move the gun 90 degrees
            TurnRight(Heading - 90);
            TurnGunLeft(90);

            // Infinite loop making sure this robot runs till the end of the battle round
            while (true)
            {
                // -- Commands that are repeated forever --

                // Move our robot 5000 pixels ahead
                Ahead(3000);

                // Turn the robot 90 degrees
                TurnRight(90);

                // Our robot will move along the borders of the battle field
                // by repeating the above two statements.
            }
        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            Fire(1);
        }
    }
}
