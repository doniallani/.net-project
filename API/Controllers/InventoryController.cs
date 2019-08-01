using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        private readonly InventoryService _service;
        [HttpPost]
        [Route ("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = _service.AddInventoryItems(items);

            if (inventoryItems == null)
            {
                return NotFound();
            }
            return inventoryItems;
        }
            [HttpGet]
            [Route ("GetInventoryItems")]
            public ActionResult <Dictionary<string, InventoryItems>> GetInventoryItems()
        {
            var inventoryItems = _service.GetInventoryItems();
            if (inventoryItems.Count == 0)
                return NotFound();
            return inventoryItems;
        }
        }
    }
