using ComputerAPI.Models;

namespace ComputerAPI.Controllers
{
    public class CompController
    {
        private readonly ComputerContext computerContext;
        public CompController(ComputerContext computerContext)
        {
            this.computerContext = computerContext;
        }


    }
}
