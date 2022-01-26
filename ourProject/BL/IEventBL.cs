﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IEventBL
    {
        Task<List<Event>> getEventByUserIdBL(int id);
        Task PostBL(Event e);
        Task<Event> getEventByEventIdBL(int id);
        Task PutBL(int id, Event e);
        Task DeleteBL(int id);
    }
}