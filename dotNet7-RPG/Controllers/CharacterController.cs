
using Microsoft.AspNetCore.Mvc;

namespace dotNet7_RPG.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class CharacterController : ControllerBase //since its just an API we use ControllerBase but if we were using a view we derive from controller
   {
      private static Character knight = new Character();
   }
}
