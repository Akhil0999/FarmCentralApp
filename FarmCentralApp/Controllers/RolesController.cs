using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Drawing.Text;

namespace FarmCentralApp.Controllers
{
    
    public class RolesController : Controller
    {      
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        //List of all roles created by user
        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }
        //methods
        [HttpGet] 
        public IActionResult Create()
        {
            return View();
        }
        //To avoid duplicate Roles
        [HttpPost]
        public async Task <ActionResult> Create(IdentityRole model)
        {
            if(!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }
            
            return RedirectToAction("Index");
        }


    }
}
