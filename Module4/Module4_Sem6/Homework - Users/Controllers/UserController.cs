using System.Collections.Generic;
using System.Linq;
using Homework___Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework___Users.Controllers
{
    public class UserController : Controller
    {
        private static List<UserInfo> _users = new ();

        [HttpPost("create-user")]
        public IActionResult CreateUser([FromBody] CreateUserRequest user)
        {
            if (ModelState.IsValid)
            {
                var id = _users.Count == 0 ? 1 : _users.Last().Id + 1;
                var newUser = new UserInfo(user.UserName, user.Email, id);
                _users.Add(newUser);
                return Ok(newUser);
            }

            return BadRequest("User has wrong parameters.");
        }

        [HttpGet("get-user-by-id")]
        public IActionResult GetUserInfoById(int id)
        {
            if (!_users.Exists(x => x.Id == id))
                return BadRequest("User with this id does not exist.");
            return Ok(_users.Find(x => x.Id == id));
        }

        [HttpGet("get-all")]
        public IActionResult GetAllUsers() => _users.Count == 0?BadRequest
        ("No users have been added") : Ok(_users);
    }
}