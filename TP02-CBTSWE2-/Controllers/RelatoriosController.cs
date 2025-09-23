using GerenciadorBLContainer;
using GerenciadorBLContainer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

// Bruno Souza (CB3025411)
// Gabriela Wandenkolk (CB3026108)
public class RelatoriosController : Controller
{
    private readonly GerenciadorBLContext _context;

    public RelatoriosController(GerenciadorBLContext context)
    {
        _context = context;
    }

    // GET: Relatorios
    public async Task<IActionResult> Index()
    {
        var blsComContainers = await _context.BLs
            .Include(b => b.Containers)
            .ToListAsync();

        return View(blsComContainers);
    }
}