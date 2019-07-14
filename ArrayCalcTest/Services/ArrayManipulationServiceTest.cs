using ArrayCalcAPI.Services;
using System;
using Xunit;
namespace ArrayCalcTest.Services
{
    public class ArrayManipulationServiceTest
    {
        [Fact]
        public void ReverseArray_ReturnsReversedArray()
        {
            string[] array = { "1","2","3","4","5" };
            int[] expectedResult = { 5, 4, 3, 2, 1 };

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.ReverseArray(array);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ReverseArray_WhenInputArrayIsEmpty_ReturnsEmptyArray()
        {
            string[] array = {};
            int[] expectedResult = {};

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.ReverseArray(array);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ReverseArray_WhenElementIsNotNumber_ThrowsException()
        {
            string[] array = { "1", "InvalidValue", "3", "4", "5" };
            int[] result = null;
            var errorMessage = "";

            try
            {
                var arrayManipulationService = new ArrayManipulationService();
                result = arrayManipulationService.ReverseArray(array);
            }
            catch (Exception error)
            {
                errorMessage = error.Message;
            }

            Assert.Null(result);
            Assert.Equal("NaN", errorMessage);
        }

        [Fact]
        public void DeleteArrayElement_ReturnsArrayWithElementRemoved()
        {
            var position = "3";
            string[] array = { "1", "2", "3", "4", "5" };
            int[] expectedResult = { 1, 2, 4, 5 };

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.DeleteArrayElement(array, position);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DeleteArrayElement_WhenPositionNotProvided_ReturnsOriginalArray()
        {
            var position = "";
            string[] array = { "1", "2", "3", "4", "5" };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.DeleteArrayElement(array, position);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DeleteArrayElement_WhenPositionOutOfRange_ReturnsOriginalArray()
        {
            var position = "8";
            string[] array = { "1", "2", "3", "4", "5" };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.DeleteArrayElement(array, position);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DeleteArrayElement_WhenPositionLowerThan1_ReturnsOriginalArray()
        {
            var position = "0";
            string[] array = { "1", "2", "3", "4", "5" };
            int[] expectedResult = { 1, 2, 3, 4, 5 };

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.DeleteArrayElement(array, position);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DeleteArrayElement_WhenInputArrayIsEmpty_ReturnsEmptyArray()
        {
            string position = "3";
            string[] array = { };
            int[] expectedResult = { };

            var arrayManipulationService = new ArrayManipulationService();
            var result = arrayManipulationService.DeleteArrayElement(array, position);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DeleteArrayElement_WhenElementIsNotNumber_ThrowsException()
        {
            var position = "3";
            string[] array = { "1", "InvalidValue", "3", "4", "5" };
            int[] result = null;
            var errorMessage = "";

            try
            {
                var arrayManipulationService = new ArrayManipulationService();
                result = arrayManipulationService.DeleteArrayElement(array, position);
            }
            catch (Exception error)
            {
                errorMessage = error.Message;
            }

            Assert.Null(result);
            Assert.Equal("NaN", errorMessage);
        }

        [Fact]
        public void DeleteArrayElement_WhenPositionIsNotNumber_ThrowsException()
        {
            var position = "X";
            string[] array = { "1", "2", "3", "4", "5" };
            int[] result = null;
            var errorMessage = "";

            try
            {
                var arrayManipulationService = new ArrayManipulationService();
                result = arrayManipulationService.DeleteArrayElement(array, position);
            }
            catch (Exception error)
            {
                errorMessage = error.Message;
            }

            Assert.Null(result);
            Assert.Equal("NaN", errorMessage);
        }
    }
}