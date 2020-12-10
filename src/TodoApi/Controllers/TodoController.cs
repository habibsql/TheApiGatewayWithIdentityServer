namespace TodoApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {      
        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return new[]
            {
                new Todo{Id = "1",Title = "Todo-1"},
                new Todo{Id = "2",Title = "Todo-2"},
                new Todo{Id = "3",Title = "Todo-3"}
            };
            
        }

        [HttpGet("idname/{id}/{name}")]
        public string GetByIdAndName([FromRoute(Name = "id")] string X, [FromRoute(Name ="name")] string Y)
        {
            return $"Todo-{X}-{Y}";
        }

        [HttpGet("best")]
        public IEnumerable<Todo> GetBestTodos()
        {
            return new[]
            {
                new Todo{Id = "4",Title = "Todo-4"},
                new Todo{Id = "5",Title = "Todo-5"},
            };

        }
    }
}
