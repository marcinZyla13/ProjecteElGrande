using System;
using System.Collections.Generic;
using System.Linq;
using KeepMovinAPI.Models;
using KeepMovinAPI.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using KeepMovinAPI.Domain;

namespace KeepMovinAPI.DAOs.Implementations
{
    public class EventDao : IEventDao
    {
        private readonly KeepMovinDbContext _context;

        public EventDao(KeepMovinDbContext context)
        {
            _context = context;
        }

        public void Add(Event eventModel)
        {
            _context.Event.Add(eventModel);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Event Get(int id)
        {
            var query = _context.Event.Find(id);
            return query;
        }

        public IEnumerable<Event> GetByInput(string input)
        {
            var query = _context.Event.Where(i => i.Name.ToLower().StartsWith(input.ToLower()));
            return query.ToList();
        }

        public IEnumerable<Event> GetAll()
        {
            return _context.Event.ToList();
        }

        public IEnumerable<Event> GetFiltered([FromQuery] Filter filter)
        {
            var query = _context.Event.Where(i => 
                i.Name.ToLower().StartsWith(filter.SearchPhrase.ToLower()) 
                && (i.Price >= filter.MinPrice && i.Price <= filter.MaxPrice)
                && (i.MaxParticipants >= filter.MinParticipants && i.MaxParticipants <= filter.MaxParticipants)
                && filter.Sports.Contains(i.Sports.SportId));
            
            return query.ToList();
        }
    }
}