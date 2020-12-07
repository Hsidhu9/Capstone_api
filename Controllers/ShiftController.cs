using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shift_Picker_Api.Models;
using Shift_Picker_Api.Services;

namespace ShiftPicker.Data.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ShiftController : ControllerBase
    {
        private readonly IShiftService _shiftService;

        public ShiftController(IShiftService ShiftService)
        {
            _shiftService = ShiftService;
        }
        /// <summary>
        /// Get all shifts with shift details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ShiftModel>> Get()
        {
           return _shiftService.GetAllShifts();
        }
    }
}