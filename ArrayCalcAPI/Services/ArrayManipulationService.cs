using System;
using ArrayCalcAPI.Services;

namespace ArrayCalcAPI.Services
{
    public class ArrayManipulationService : IArrayManipulationService
    {
        public int[] ReverseArray(string[] array)
        {
            var arraySize = array.Length;
            var newArray = new int[arraySize];

            var index = 0;
            for (int i = arraySize - 1; i >= 0; i--)
            {
                newArray[index] = ConvertToIntOrThrowException(array[i]);
                index++;
            }
            return newArray;
        }

        public int[] DeleteArrayElement(string[] array, string strPosition)
        {
            // when position not provided or it is out of range, new array will be same size as original
            var position = string.IsNullOrEmpty(strPosition) ? 0: ConvertToIntOrThrowException(strPosition);
            var arraySize = array.Length;
            var newArraySize = (position < 1 || position > arraySize) ? arraySize : arraySize - 1;
            var newArray = new int[newArraySize];

            var index = 0;
            for (int i = 0; i < arraySize; i++)
            {                
                if (i != position - 1)
                {
                    newArray[index] = ConvertToIntOrThrowException(array[i]);
                    index++;
                }
            }
            return newArray;
        }

        private int ConvertToIntOrThrowException(string stringElement)
        {
            int element;
            if (!int.TryParse(stringElement, out element))
            {
                throw new Exception("NaN");
            }
            return element;
        }
    }
}