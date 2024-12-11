﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BozhukovVP.Sprint6.Task4.V25.Lib
{
    public class DataService : ISprint6Task4V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                vallueArray[count] = Math.Round(Math.Cos(x) + 2 * x - Math.Sin(x) * 3 * x, 2);
                count++;
            }
            return vallueArray;
        }
    }
}
