using BlogNoticias.Data.Dtos;
using BlogNoticias.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogNoticias.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EditorController : ControllerBase
    {
        private readonly ILogger<EditorController> _logger;
        private readonly IEditorService _service;
        private readonly HttpClient _httpClient;


        public EditorController(ILogger<EditorController> logger, IEditorService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario(CreateEditorDto dto)
        {
            await _service.Cadastra(dto);
            return Ok("Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginEditorDto dto)
        {
            var token = await _service.Login(dto);
            return Ok(token);
        }

        internal Task<OkObjectResult> Get(CreateEditorDto cadastraEditorDto)
        {
            throw new NotImplementedException();
        }
    }
}
