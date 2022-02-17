﻿using System.Collections.Generic;
using KeepMovinAPI.DAOs;
using KeepMovinAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KeepMovinAPI.Controllers
{
    public class PriceController : ControllerBase
    {
        private readonly ILogger<PriceController> _logger;
        private IPriceDao _daoPrice;

        public PriceController(ILogger<PriceController> logger, IPriceDao daoPrice)
        {
            _logger = logger;
            _daoPrice = daoPrice;
        }
        
        [HttpGet]
        [Route("api/prices")]
        public IEnumerable<Price> GetAll()
        {
            var listOfPrices = _daoPrice.GetAll();
            return listOfPrices;
        }
        
    }
}