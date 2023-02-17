using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers;

   [ApiController]//controller de uma api - só vai retornar json
    public class HomeController : ControllerBase{//herdar sempre de controller base

        [HttpGet]
        public string Get(){ //metodos dentro de um controller são actions
            return "Heloo Word";
        }


    }
