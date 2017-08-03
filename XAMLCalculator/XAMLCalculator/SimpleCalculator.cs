﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XAMLCalculator
{
    public static class SimpleCalculator
    {
        public static double Calculate(double value1, double value2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "/":
                    result = value1 / value2;
                    break;
                case "X":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}
