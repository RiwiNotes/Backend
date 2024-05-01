using Microsoft.EntityFrameworkCore;

using Backend.Models;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers{
    public class NotasController : Controller{
        public readonly DataBaseContext _context;
        public NotasController (DataBaseContext context){
            _context = context;
        }

        
    }
}