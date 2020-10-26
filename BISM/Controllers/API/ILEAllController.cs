using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BISM.Models.BalimoonBML;

namespace BISM.Controllers.API
{
    [Route("api/StockILE")]
    [ApiController]
    public class ILEAllController : ControllerBase
    {
        private BalimoonBMLContext _dataContext;

        public ILEAllController(BalimoonBMLContext context)
        {
            _dataContext = context;
        }
        [HttpGet]
        public IActionResult getALLILE()
        {
            var hasil = (from a in _dataContext.ItemLedgerEntry
                         group a by a.ItemNo into g
                         select new { itemno = g.Key, total = g.Sum(a => a.Quantity) }).ToList();
            return new JsonResult(new { result = "OK", data = hasil });
        }
    }
}