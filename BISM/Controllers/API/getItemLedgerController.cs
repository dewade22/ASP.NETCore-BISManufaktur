using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BISM.Models.BalimoonBML;

namespace BISM.Controllers.API
{
    [Route("api/StockFGItemLedgerEntry")]
    [ApiController]
    public class getItemLedgerController : ControllerBase
    {
        private readonly BalimoonBMLContext _dataContext;

        public getItemLedgerController(BalimoonBMLContext context)
        {
            _dataContext = context;
        }
        [HttpGet]
        public IActionResult getStockFG()
        {
            var omrach700 = (from a in _dataContext.ItemLedgerEntry
                             where a.LocationCode == "WHFG"
                             group a by a.ItemNo into g
                             select new { itemno = g.Key, total = g.Sum(g => g.Quantity) }).ToList();

            /* var omrach250 = (from a in _dataContext.ItemLedgerEntry
                              where a.ItemNo == "700225" && a.LocationCode == "WHFG"
                              group a by a.Description into g
                              select new { itemname = g.Key, total = g.Sum(g => g.Quantity) }).ToList();


             return new JsonResult(new {
             result = "OK",
             omrach7=omrach700,
             omrach2=omrach250});
             */
            return new JsonResult(new { result = "OK", data = omrach700 });
        }
    }
}