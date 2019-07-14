using System;
using System.Collections.Generic;
using ArrayCalcAPI.Services;
using Microsoft.AspNetCore.Mvc;


namespace ArrayCalcAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController: ControllerBase
    {
        private readonly IArrayManipulationService _arrayManipulationService;

        public ArrayCalcController(IArrayManipulationService arrayManipulationService)
        {
            _arrayManipulationService = arrayManipulationService;
        }

        [HttpGet("reverse")]
        public IActionResult Reverse([FromQuery]string[] productIds)
        {
            try
            {
                if (productIds == null || productIds.Length == 0)
                    return BadRequest("No product ids are passed");
                var result = _arrayManipulationService.ReverseArray(productIds);
                return Ok(result);
            } 
            catch (Exception e)
            {
                return BadRequest("Error while reversing array: " + e.Message);
            }
        }

        
        // GET api/ArrayCalc/DeletePart
        [HttpGet("deletepart")]
        public IActionResult DeletePart([FromQuery]string position, [FromQuery]string[] productIds)
        {
            try
            {
                var result = _arrayManipulationService.DeleteArrayElement(productIds, position);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest("Error while deleteng element: " + e.Message);
            }
        }
    }
}