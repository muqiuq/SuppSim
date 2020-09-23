﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPOCSimulator
{
    public static class BoundaryConditions
    {

        public static int DayLength = 1440;

        public static int EmployeeWarmUpDuration = 15;
        public static int EmployeeCleanUpDuration = 15;

        // All values in ticks (1 tick = 1 minute)
        public static int TicketResolvTime1stLevelMean = 10;
        public static int TicketResolvTime1stLevelStdDev = 20;
         
        public static int TicketResolvTime2ndLevelMean = 60;
        public static int TicketResolvTime2ndLevelStdDev = 45;

        // Factor of 2 would mean 50% 1st, 50% 2nd, 1.5 is 70% 1st
        public static double LevelDistributionFactor = 1.5;

        public static int EmployeeEfficencyDecayStartTicks = 360;
        public static int EmployeeEfficencyDecayInterval = 15;
        public static double EmployeeEfficencyDecayStartValue = 0.01;
        public static double EmployeeEfficencyDecayFactor = 1.2;

    }
}
