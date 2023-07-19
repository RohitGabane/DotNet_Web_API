using Microsoft.AspNetCore.Mvc;
using WebAppAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMembers member;
        public MemberController(IMembers mem)
        {
            member = mem;
        }

        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<Members> Get()
        {
            return member.GetAllMember();

        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public Members Get(int id)
        {
            return member.GetMember(id);
        }

        // POST api/<MemberController>
        [HttpPost]
        public void Post([FromBody] Members obj)
        {
            member.Add(obj);
        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Members obj)
        {
            member.Update(id, obj);

        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            member.Delete(id);
        }
    }
}
