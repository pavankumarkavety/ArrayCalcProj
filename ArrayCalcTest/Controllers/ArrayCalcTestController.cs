using ArrayCalcAPI.Controllers;
using ArrayCalcAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ArrayCalcTest.Controllers
{
    public class ArrayCalcTestController
    {
        ArrayCalcController _controller;

        IArrayManipulationService _service;

        public ArrayCalcTestController()
        {
            _service = new ArrayManipulationService();
            _controller = new ArrayCalcController(_service);
        }

        [Fact]
        public void GetReversed_ReturnsOkResult()
        {
            string[] array = { "1", "2", "3", "4", "5" };
            
            var result = _controller.Reverse(array);
            
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetReversed_WhenElementNotANumber_ReturnsBadRequest()
        {
            string[] array = { "1", "InvalidValue", "3", "4", "5" };

            var result = _controller.Reverse(array);
            
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetDeleted_ReturnsOkResult()
        {
            var position = "3";
            string[] array = { "1", "2", "3", "4", "5" };

            var result = _controller.DeletePart(position, array);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetDeleted_WhenElementNotANumber_ReturnsBadRequest()
        {
            var position = "3";
            string[] array = { "1", "2", "3", "InvalidValue", "5" };

            var result = _controller.DeletePart(position, array);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetDeleted_WhenPositionNotANumber_ReturnsBadRequest()
        {
            var position = "XY";
            string[] array = { "1", "2", "3", "4", "5" };

            var result = _controller.DeletePart(position, array);

            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}