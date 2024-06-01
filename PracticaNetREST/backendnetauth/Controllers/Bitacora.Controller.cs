using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendnet.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Administrador")]
public class BitacoraController(IdentityContext context) : Controller
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bitacora>>> GetBitacoras(){
        return await context.Bitacora.AsNoTracking().ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Bitacora>> GetBitacoras(int id){
        var bitacora = await context.Bitacora.FindAsync(id);
        if(bitacora == null) return NotFound();

        return bitacora;    
    } 
}

