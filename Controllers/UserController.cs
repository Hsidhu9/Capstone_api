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

        [HttpGet("employees")]
        public async Task<ActionResult<List<UserModel>>> GetAllEmployees()
        {
            return await _userService.GetAllEmployees();
        }

        [HttpGet("supervisors")]
        public async Task<ActionResult<List<UserModel>>> GetAllSupervisors()
        {
            return await _userService.GetAllSupervisors();
        }

        [HttpGet("managers")]
        public async Task<ActionResult<List<UserModel>>> GetAllManagers()
        {
            return await _userService.GetAllManagers();
        }
    }
}