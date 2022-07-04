using System;

namespace BrighteyeTest
{
    internal class Randomizer
    {
        private static int _minValue = 1;
        private static int _limiteValue = 11;

        private static Random _random = new Random(); 
        internal static int[] CreateArray(int amount)
        {
            int[] array = new int[amount];
            for (int i = 0; i < amount; i++) array[i] = _random.Next(_minValue, _limiteValue);
            return array;
        }
    }
}
