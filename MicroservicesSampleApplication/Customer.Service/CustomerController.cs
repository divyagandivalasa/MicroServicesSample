using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Customer.Service
{
    public class CustomerController : ApiController
    {
        ICustomerRepository custRepo = new CustomerRepository();

        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Welcome to Sheepishly 1.0.0 - The Combleat Sheep Tracking Suite";
        }

        [HttpGet]
        [Route("GetId")]
        public Customer GetId(string id)
        {
            return custRepo.GetId(id);
        }
    }
}
