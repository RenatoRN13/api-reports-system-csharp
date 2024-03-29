using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportsSystemApi.Domain.Entities;
using ReportsSystemApi.Infra;

namespace ReportsSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly RSApiContext _context;

        public RelatorioController(RSApiContext context){
            _context = context;
        }

        // GET api/Relatorio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Relatorio>>> GetItems()
        {
            return await _context.Relatorios.ToListAsync();
        }

        // GET api/Relatorio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Relatorio>> GetItem(int id)
        {
            var item = await _context.Relatorios.FindAsync(id);

            if(item == null){
                return NotFound("Relatório não encontrado.");
            }

            return item;
        }

        // POST api/Relatorio
        [HttpPost]
        public async Task<ActionResult<Relatorio>> Post(Relatorio relatorio)
        {
            Usuario usuario = await _context.Usuarios.FindAsync(relatorio.idUsuario);
            if(usuario == null)
                return BadRequest("Não foi possível enviar relatório. É necessário informar um usuário");

            Atividade atividade = await _context.Atividades.FindAsync(relatorio.idAtividade);
            if(atividade == null)
                return BadRequest("Não foi possível enviar relatório. É necessário informar de qual atividade ele é exigido");

            _context.Relatorios.Add(relatorio);
            await _context.SaveChangesAsync();

            return Ok("Relatório enviado com sucesso!");
        }

        // // PUT api/Relatorio/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> Put(int id, Relatorio relatorio)
        // {
        //     if(id != relatorio.id){
        //         return BadRequest();
        //     }

        //     _context.Entry(relatorio).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        // // DELETE api/Relatorio/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     var relatorio = await _context.Relatorios.FindAsync(id);

        //     if(relatorio == null){
        //         return NotFound();
        //     }

        //     _context.Relatorios.Remove(relatorio);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }
    }
}
