using System.Threading.Tasks;
using dotnet.Data;
using dotnet.DTOs;
using Microsoft.AspNetCore.Mvc;
using dotnet.Extensions;
using dotnet.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using dotnet.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Linq;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserRepository _userRepository;
        public ProductController(IUserRepository UserRepository, DataContext context)
        {
            _context = context;
            _userRepository = UserRepository;
        }
        [Route("create")]
        public async Task<UserDto> CreateProduct(string a)
        {
            var username = User.GetUsername();
            var user = await _userRepository.GetUserByUsernameAsync(username);
            var test = new UserDto
            {
                firstName = user.role

            };
            return test;
            
        }

    }
}