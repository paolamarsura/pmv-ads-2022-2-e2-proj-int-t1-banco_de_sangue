using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BancoDeSangue.Data;
using BancoDeSangue.Models;

namespace BancoDeSangue.Controllers
{
    public class LoginSController : Controller
    {
        private readonly BancoContext _context;

        public LoginSController(BancoContext context)
        {
            _context = context;
        }

        // GET: LoginS
        //public async Task<IActionResult> Index()
        //{
        //    var teste =await _context.Usuarios.ToListAsync();
        //    return View("ListaDeUsuarios", teste);
        //}

        // GET: LoginS/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.email == id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // GET: LoginS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("email,senha")] UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioModel);
        }

        // GET: LoginS/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.Usuarios.FindAsync(id);
            if (usuarioModel == null)
            {
                return NotFound();
            }
            return View(usuarioModel);
        }

        // POST: LoginS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("email,senha")] UsuarioModel usuarioModel)
        {
            if (id != usuarioModel.email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioModelExists(usuarioModel.email))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioModel);
        }

        // GET: LoginS/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.email == id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // POST: LoginS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var usuarioModel = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuarioModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioModelExists(string id)
        {
            return _context.Usuarios.Any(e => e.email == id);
        }
    }
}
