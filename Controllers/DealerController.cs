using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlackjackAPI.Models;

namespace BlackjackAPI.Controllers
{

  [Route("api/[controller]")]
  [ApiVersion("1.0")]
  [ApiController]
  public class DealerController : ControllerBase
  {
    private readonly BlackjackAPIContext _db;
    
    public DealerController(BlackjackAPIContext db)
    {
      _db = db;
    }

    // GET api/dealers/[int]
    [HttpGet("{id}")]
    public ActionResult<Dealer> Get(int id)
    {
      var dealer = _db.Dealers.FirstOrDefault(entry => entry.DealerId == id);
      return dealer;
    }
  }
}


//     // GET api/stateparks
//     [HttpGet]
//     public ActionResult<IEnumerable<Dealer>> Get()
//     {
//       var query = _db.Dealers.AsQueryable();
//       return query.ToList();
//     }



//     // POST api/stateparks
//     [HttpPost]
//     public void Post([FromBody] StatePark statePark)
//     {
//       _db.StateParks.Add(statePark);
//       _db.SaveChanges();
//     }

//     // PUT api/stateparks/[int]
//     [HttpPut("{id}")]
//     public void Put(int id, [FromBody] StatePark statePark)
//     {
//       statePark.StateParkId = id;
//       _db.Entry(statePark).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//       _db.SaveChanges();
//     }

//     // DELETE api/stateparks/[int]
//     [HttpDelete("{id}")]
//     public void Delete(int id)
//     {
//       var statePark = _db.StateParks.FirstOrDefault(entry => entry.StateParkId ==  id);
//       _db.Remove(statePark);
//       _db.SaveChanges();
//     }
//   }

//   [ApiController]
//   [ApiVersion("2.0")]
//   [Route("api/[controller]")]

//     public class StateParksV2Controller : ControllerBase
//     {
//     private readonly ParksContext _db;
    
//     public StateParksV2Controller(ParksContext db)
//     {
//       _db = db;
//     }

//     // SEARCH api/stateparks?search=[string]
//     [HttpGet("search")]
//     public ActionResult<IEnumerable<StatePark>> Search(string name, string location, string description)
//     {
//       var query = _db.StateParks.AsQueryable();
//       if (name != null)
//       {
//         query = query.Where(entry => entry.Name.Contains(name));
//       }
//       if (location != null)
//       {
//         query = query.Where(entry => entry.Location.Contains(location));
//       }
//       if (description != null)
//       {
//         query = query.Where(entry => entry.Description.Contains(description));
//       }

//       return query.ToList();
//     }
//   }
// }
