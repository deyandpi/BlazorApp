using DbData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerTest1.Data
{
    public class EventsService
    {
        public Task<List<EventDb>> GetEvents(LocalDBContext context)
        {
            //LocalDBContext context = new LocalDBContext();
            return Task.FromResult(context.Events.Select(s => new EventDb { Name = s.Name, Date = s.Date }).ToList());
        }

        public bool Save(EventDb context)
        {
            //LocalDBContext context = new LocalDBContext();
            return true;
        }
    }

    public class EventDb
    {
        public string Name { get; set; }

        public DateTime Date{ get; set; }
    }
}
