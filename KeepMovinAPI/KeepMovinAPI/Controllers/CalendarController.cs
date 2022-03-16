﻿using System;
using System.Collections;
using System.Collections.Generic;
using KeepMovinAPI.Authentication;
using KeepMovinAPI.Repository;
using KeepMovinAPI.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace KeepMovinAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ILogger<CalendarController> _logger;
        private IEventDao _daoEvent;
        private IValidation _validation;

        public CalendarController(ILogger<CalendarController> logger, IEventDao daoEvent,
             IValidation validation)
        {
            _logger = logger;
            _daoEvent = daoEvent;
            _validation = validation;
        }

        [HttpGet]
        public IEnumerable<Event> GetEventsByRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                var listOfEvents =
                _daoEvent.GetAllByDateRange(startDate,
                    endDate.AddDays(1)); // added one day to catch all events in calendar view
                return listOfEvents;    


            }
            catch (Exception e)
            {
                _logger.LogWarning(Convert.ToString(e));
                return null;
            }
            
                
            
        }

        // add get for user events


     
    }
}