using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;
using WebApplication1.Models;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Filter2]
    public class UsersController : Controller
    {
        public UsersController()
        {
            Console.WriteLine("UsersController Constructor");
        }

        [HttpGet]
        [Filter3]
        public IActionResult Get()
        {
            var response = new Response();

            try
            {
                IUserRepository repo = new UserRepository();
                var users = repo.GetUsers();
                response.Data = users;
                return StatusCode(200,response);                
            }
            catch (Exception ex)
            {
                response.Error = new Error() { Code = "500", Message = ex.Message };
                return StatusCode(500, response.Error);
            }
            
        }
    }
}