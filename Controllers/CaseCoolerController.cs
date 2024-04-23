using Microsoft.AspNetCore.Mvc;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class CaseCoolerController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("CaseCooler/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();
            return Ok(result);
        }
        public IEnumerable<object> GetAsList()
        {
            var result = context.CaseCooler
                .Select(c => new
                {
                    c.Name,
                    c.Price,
                    Producer = context.Enum_Producers
                            .Where(em => em.Id == c.ProducerId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    c.Length,
                    c.Width,
                    c.Height,
                    c.FanAirflow,
                    c.FanNoiseLevel,
                    Fans = context.Enum_Fans
                            .Where(em => em.Id == c.FansId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    MTBF = context.Enum_MTBF
                            .Where(em => em.Id == c.MTBFId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    Connector = context.Enum_Connectors
                            .Where(em => em.Id == c.ConnectorId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    FanBearing = context.Enum_FanBearing
                            .Where(em => em.Id == c.FanBearingId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    FanSpeed = context.Enum_FanSpeed
                            .Where(em => em.Id == c.FanSpeedId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    Color = c.Color.Select(c => new { c.Name }),
                });
            return result;
        }
        [HttpGet("CaseCooler/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
     string? name = null,
     int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
     int? minLength = null, int? maxLength = null, int? exactLength = null,
     int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
     int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
      decimal? minFanAirflow = null, decimal? maxFanAirflow = null, decimal? exactFanAirflow = null,
    decimal? minFanNoiseLevel = null, decimal? maxFanNoiseLevel = null, decimal? exactFanNoiseLevel = null,
     IEnumerable<string>? fans = null,
    IEnumerable<string>? mtbf = null,
    IEnumerable<string>? connector = null,
    IEnumerable<string>? fanBearing = null,
    IEnumerable<string>? fanSpeed = null,
     IEnumerable<string>? producer = null,
             IEnumerable<string>? color = null

     )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();

            result = FilterDimensions(result, name, minPrice, maxPrice, exactPrice, minLength, maxLength, exactLength, minWidth, maxWidth, exactWidth, minHeight, maxHeight, exactHeight, producer);

            if (minFanAirflow != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("FanAirflow").GetValue(item)) >= minFanAirflow);
            }
            if (maxFanAirflow != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("FanAirflow").GetValue(item)) <= maxFanAirflow);
            }
            if (exactFanAirflow != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("FanAirflow").GetValue(item)) == exactFanAirflow);
            }

            if (minFanNoiseLevel != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("FanNoiseLevel").GetValue(item)) >= minFanNoiseLevel);
            }
            if (maxFanNoiseLevel != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("FanNoiseLevel").GetValue(item)) <= maxFanNoiseLevel);
            }
            if (exactFanNoiseLevel != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("FanNoiseLevel").GetValue(item)) == exactFanNoiseLevel);
            }
            if (mtbf != null && mtbf.Any())
            {
                result = result.Where(item => mtbf.Contains(item.GetType().GetProperty("MTBF").GetValue(item).ToString()));
            }
            if (fans != null && fans.Any())
            {
                result = result.Where(item => fans.Contains(item.GetType().GetProperty("Fans").GetValue(item).ToString()));
            }
            if (connector != null && connector.Any())
            {
                result = result.Where(item => connector.Contains(item.GetType().GetProperty("Connector").GetValue(item).ToString()));
            }

            if (fanBearing != null && fanBearing.Any())
            {
                result = result.Where(item => fanBearing.Contains(item.GetType().GetProperty("FanBearing").GetValue(item).ToString()));
            }

            if (fanSpeed != null && fanSpeed.Any())
            {
                result = result.Where(item => fanSpeed.Contains(item.GetType().GetProperty("FanSpeed").GetValue(item).ToString()));
            }
            if (color != null && color.Any())
            {
                result = result.Where(item => {
                    var itemColors = item.GetType().GetProperty("Color").GetValue(item) as IEnumerable<object>;
                    if (itemColors != null)
                    {
                        foreach (var colorItem in itemColors)
                        {
                            var colorName = colorItem.GetType().GetProperty("Name").GetValue(colorItem)?.ToString();
                            if (colorName != null && color.Contains(colorName))
                            {
                                return true;
                            }
                        }
                    }
                    return false; 
                });
            }

            return result;
        }


        [HttpGet("CaseCooler/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<CaseCooler>(id);
            return Ok(result);
        }

        [HttpGet("CaseCooler/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<CaseCooler>();
            return Ok(result);
        }

        [HttpPost("CaseCooler/Add")]
        public IActionResult Add([FromBody] CaseCooler newItem)
        {
            if (Add<CaseCooler>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid CaseCooler data");
        }

        [HttpDelete("CaseCooler/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<CaseCooler>(id);
        }

        [HttpPut("CaseCooler/Update")]
        public IActionResult Update(int id, [FromBody] CaseCooler newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}
