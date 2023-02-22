using Login.Entities.Entities.Productos;
using Login.UI.Controllers.Usuarios.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Login.UI.Controllers.Usuarios
{
    [Route("api/Usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Post(LoginUserModel loginUserModel)
        {
            try
            {
                return null;
                var usuario = _mapper.Map<Producto>(productoDto);

                //producto.FechaCreacion = DateTime.Now;
                //producto = await _productoRepository.AddProducto(producto);

                //productoDto = _mapper.Map<ProductoDTO>(producto);

                //return CreatedAtAction("Get", new { id = productoDto.id }, productoDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
