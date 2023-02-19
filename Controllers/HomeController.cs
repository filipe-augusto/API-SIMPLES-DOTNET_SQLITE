using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers;

   [ApiController]//controller de uma api - só vai retornar json

    public class HomeController : ControllerBase{//herdar sempre de controller base

        [HttpGet("/")]
        // [Route("/")]
        public List<TodoModel> Get([FromServices]AppDbContext context){ //metodos dentro de um controller são actions
            return context.Todos.ToList();
        }
           
     [HttpGet("/{id:int}")]
        // [Route("/")]
        public TodoModel GetById([FromRoute] int id
            ,[FromServices]AppDbContext context){

            return context.Todos.FirstOrDefault(x => x.Id == id);
        }


        [HttpPost("/")]
        public TodoModel Post([FromBody]TodoModel todo,
            [FromServices] AppDbContext context){
                context.Todos.Add(todo);
                context.SaveChanges();
                return todo;
        }

             [HttpPut("/{id:int}")]
        public TodoModel Put(
            [FromRoute] int id,
            [FromBody]TodoModel todo,
            [FromServices] AppDbContext context){
                var model = context.Todos.FirstOrDefault(x => x.Id == id);
                if(model == null )
                    return todo;
               
                model.Title = todo.Title;
                model.Done = todo.Done;
                context.Todos.Update(model);
                context.SaveChanges();
                return todo;
        }
        [HttpDelete("/{id:int}")]
        public TodoModel Delete(
            [FromRoute] int id,
            [FromServices] AppDbContext context){
                var model = context.Todos.FirstOrDefault(x => x.Id == id);

                context.Todos.Remove(model);
                context.SaveChanges();
                return model;
        }

        





    }
