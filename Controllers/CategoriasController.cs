using Microsoft.EntityFrameworkCore;

using Backend.Models;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers{
    public class CategoriasController : Controller{
        public readonly DataBaseContext _context;
        public CategoriasController (DataBaseContext context){
            _context = context;
        }

        
    }
}