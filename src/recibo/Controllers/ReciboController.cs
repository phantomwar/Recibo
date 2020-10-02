using Microsoft.AspNetCore.Mvc;
using recibo.Data;
using Microsoft.AspNetCore.Http;
using recibo.Models;
using System.Threading.Tasks;

namespace recibo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciboController: Controller
    {
        public IRepository _repo { get; }
        public ReciboController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllRecibosAsync();

                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }

        [HttpGet("{ReciboId}")]
        public async Task<IActionResult> GetByReciboId(int ReciboId)
        {
            try
            {
                var result = await _repo.GetAllRecibosAsyncbyId(ReciboId);

                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }
        }
          
       [HttpPost]
        public async Task<IActionResult> post(Recibo model)
        {
            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Created($"/api/{model.Id}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }

            return BadRequest();
        }

        [HttpPut("{ReciboId}")]
        public async Task<IActionResult> put(int ReciboId, Recibo model)
        {
            try
            {
                var reciboo = await _repo.GetAllRecibosAsyncbyId(ReciboId);
                if (reciboo == null) return NotFound();

                _repo.Update(model);

                if(await _repo.SaveChangesAsync())
                {
                    reciboo = await _repo.GetAllRecibosAsyncbyId(ReciboId);
                    return Created($"/api/recibo/{model.Id}", reciboo);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }

            return BadRequest();
        }

        [HttpDelete("{ReciboId}")]
        public async Task<IActionResult> delete(int ReciboId)
        {
            try
            {
                var reciboo = await _repo.GetAllRecibosAsyncbyId(ReciboId);
                if (reciboo == null) return NotFound();
                
                _repo.Delete(reciboo);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok();
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }

            return BadRequest();
        }
    }
}