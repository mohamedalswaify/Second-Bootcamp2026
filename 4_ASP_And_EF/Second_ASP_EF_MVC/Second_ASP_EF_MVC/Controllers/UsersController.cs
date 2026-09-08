using Microsoft.AspNetCore.Mvc;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _db;

        public UsersController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<User> users = _db.Users.ToList();
            return View(users);
        }

        // =========================
        // Create
        // =========================
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);
                _db.Users.Add(user);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // =========================
        // Edit
        // =========================
        [HttpPost]
        public IActionResult Edit(User user)
        {
            var oldUser = _db.Users.Find(user.Id);

            if (oldUser == null)
            {
                return NotFound();
            }

            oldUser.Name = user.Name;
            oldUser.Email = user.Email;
            oldUser.Username = user.Username;

            // Change password only if user entered a new password
            if (!string.IsNullOrEmpty(user.Password))
            {
                oldUser.PasswordHash =
                    BCrypt.Net.BCrypt.HashPassword(user.Password);
            }

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // =========================
        // Delete
        // =========================
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var user = _db.Users.Find(id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
