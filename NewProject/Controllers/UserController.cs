using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;
using NewProject.Reponsitories;

namespace NewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository repo)
        {
            _userRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            try
            {
                return Ok(await _userRepo.GetAllUserAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{userID}")]
        public async Task<IActionResult> GetUserByID(int userID)
        {
            var user = await _userRepo.GetUserAsync(userID);
            return user == null ? NotFound() : Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewUser(RequestUserModel model)
        {
            var newUserId = await _userRepo.AddUserAsync(model);
            var user = await _userRepo.GetUserAsync(newUserId);
            return user == null ? BadRequest() : Ok(user);

        }
        [HttpPut("{userID}")]
        public async Task<IActionResult> UpdateSport(int userID, [FromBody] UserModel model)
        {
            if (userID != model.UserID)
            {
                return NotFound();
            }
            await _userRepo.UpdateUserAsync(userID, model);
            return Ok();
        }
        [HttpDelete("{userID}")]
        public async Task<IActionResult> DeleteSport(int userID)
        {
            var user = await _userRepo.GetUserAsync(userID);
            if (user == null)
                return NotFound();
            await _userRepo.DeleteUserAsync(userID);
            return Ok();
        }
    }
}
