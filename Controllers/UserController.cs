using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shift_Picker_Api.Models;
using Shift_Picker_Api.Services;

namespace ShiftPicker.Data.Controller
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Get all employees. To get all all employees type /user/eployees in the end of URL. 
        /// </summary>
        /// <returns></returns>
        [HttpGet("employees")]
        public async Task<ActionResult<List<UserModel>>> GetAllEmployees()
        {
            return await _userService.GetAllEmployees();
        }

        /// <summary>
        /// Get all supervisors. To get all all supervisors type /user/supervisors in the end of URL. 
        /// </summary>
        /// <returns></returns>
        [HttpGet("supervisors")]
        public async Task<ActionResult<List<UserModel>>> GetAllSupervisors()
        {
            return await _userService.GetAllSupervisors();
        }

        /// <summary>
        /// Get all managers. To get all all managers type /user/managers in the end of URL.
        /// </summary>
        /// <returns></returns>
        [HttpGet("managers")]
        public async Task<ActionResult<List<UserModel>>> GetAllManagers()
        {
            return await _userService.GetAllManagers();
        }
    }
}