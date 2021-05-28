using homework.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework.Controllers
{
    public class UserController : ControllerBase
    {
        private static List<UserInfo> users = new List<UserInfo>();

        [HttpPost("create-user")]
        public IActionResult CreateUser([FromBody] CreateUserRequest req)
        {
            var user = new UserInfo() { Id = users.Count + 1, Email = req.Email, UserName = req.UserName };
            users.Add(user); return Ok(user);
        }

        [HttpGet("get-user-by-id")]
        public IActionResult GetUserById([FromQuery] int id)
        {
            var result = users.Where(x => x.Id == id).ToList(); if (result.Count == 0)
                if (result.Count == 0)
                {
                    return NotFound(new
                    {
                        Message = $"Пользователь с Id = {id} не найден"
                    });
                }
            return Ok(result.First());
        }

        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers() { return Ok(users); }

    }
}
