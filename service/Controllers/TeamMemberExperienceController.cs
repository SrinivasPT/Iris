using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace service.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class TeamMemberExperienceController : ControllerBase
  {

    [HttpGet("GetByParentID/{id}")]
    public dynamic GetByParentID(int id)
    {
      var nodes = (
                new[] {
                  new {Id = 1000, Experience = new[] {
                    new { Id = 1000, TeamMemberID=1000, CompanyName = "Cognizant",  FromDate = DateTime.Now.AddMonths(-32),ToDate = DateTime.Now.AddMonths(-12), City = "Hyderabad", Country = "India", Status = "ACTIVE"},
                    new { Id = 1001, TeamMemberID=1000, CompanyName = "Infosys",  FromDate = DateTime.Now.AddMonths(-64),ToDate = DateTime.Now.AddMonths(-32), City="Hyderabad", Country = "India", Status = "ACTIVE"},
                    new { Id = 1002, TeamMemberID=1000, CompanyName = "eGain",  FromDate = DateTime.Now.AddMonths(-68),ToDate = DateTime.Now.AddMonths(-64), City="Hyderabad", Country = "India", Status = "ACTIVE"},
                    new { Id = 1003, TeamMemberID=1000, CompanyName = "FES",  FromDate = DateTime.Now.AddMonths(-90),ToDate = DateTime.Now.AddMonths(-68), City="Hyderabad", Country = "India", Status = "ACTIVE"},
                }}}).ToList();
      return nodes.Find(node => node.Id == id);
    }

    [HttpGet("{id}")]
    public dynamic Get(int id)
    {
      var nodes = (new[] {
                    new { Id = 1000, TeamMemberID=1000, CompanyName = "Cognizant",  FromDate = DateTime.Now.AddMonths(-32),ToDate = DateTime.Now.AddMonths(-12), City = "Hyderabad", Country = "India", Status = "ACTIVE"},
                    new { Id = 1001, TeamMemberID=1000, CompanyName = "Infosys",  FromDate = DateTime.Now.AddMonths(-64),ToDate = DateTime.Now.AddMonths(-32), City="Hyderabad", Country = "India", Status = "ACTIVE"},
                    new { Id = 1002, TeamMemberID=1000, CompanyName = "eGain",  FromDate = DateTime.Now.AddMonths(-68),ToDate = DateTime.Now.AddMonths(-64), City="Hyderabad", Country = "India", Status = "ACTIVE"},
                    new { Id = 1003, TeamMemberID=1000, CompanyName = "FES",  FromDate = DateTime.Now.AddMonths(-90),ToDate = DateTime.Now.AddMonths(-68), City="Hyderabad", Country = "India", Status = "ACTIVE"},
                }).ToList();
      return nodes.Find(node => node.Id == id);
    }


    // POST api/Person
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Person/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Person/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
