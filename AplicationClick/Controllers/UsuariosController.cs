using System.Threading.Tasks;
using AplicationClick.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AplicationClick.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Usuarios.ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.DataCadastro = DateTime.Now;
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = _context.Usuarios.Find(id);
            if (dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = _context.Usuarios.Find(id);
            if (dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = _context.Usuarios.Find(id);
            if (dados == null)
            {
                return NotFound();
            }
            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dados = _context.Usuarios.Find(id);
            if (dados == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");


        }
    }
}
    