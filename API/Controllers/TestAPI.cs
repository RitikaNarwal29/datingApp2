using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.data;
using API.entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestAPI : ControllerBase
    {
        public string Test(){
            return "API Running";
        }}}
       //  private readonly DataContext _context;

       // [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> GetUsers()
        // {
        //     var users = _context.Users.ToList();
        //     return users;
        // }
        // [HttpGet("{id}")]
        // public ActionResult<AppUser>GetUser(int id)
        // {
        //     return _context.Users.Find(id);
        // }
    

        
    
