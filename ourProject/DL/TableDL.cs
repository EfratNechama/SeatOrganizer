﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class TableDL : ITableDL
    {
        SeatOrgenizerContext _myDB;
       
        public TableDL(SeatOrgenizerContext SeatOrgenizerContext)
        {
            _myDB = SeatOrgenizerContext;
            
        }
        public async Task PostDL(Table t)
        {   if(t!=null)
            { 
            
            await _myDB.Tables.AddAsync(t); 
            await _myDB.SaveChangesAsync();
            }
        }

        //placement
        public async Task<List<Table>> GetTabelByEventId(int eventId)
            {
            List<Table> listTabel= await _myDB.Tables.Where(t => t.EventId.Equals(eventId) ).ToListAsync();

            return listTabel;

        }


    }
}
