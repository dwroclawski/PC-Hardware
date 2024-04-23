using Microsoft.AspNetCore.Mvc;
using System.Text;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class CPUCoolerController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("CPUCooler/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();

            return Ok(result);
        }

        public IEnumerable<object> GetAsList()
        {
            var result = context.CPUCooler
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
                    CoolingType = context.Enum_CoolingType
                            .Where(em => em.Id == c.CoolingTypeId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    Mount = context.Enum_Mount
                            .Where(em => em.Id == c.MountId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    HeatPipes = context.Enum_HeatPipes
                            .Where(em => em.Id == c.HeatPipesId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    TDP = context.Enum_TDP
                            .Where(em => em.Id == c.TDPId)
                            .Select(em => em.Name)
                            .FirstOrDefault(),
                    Color = c.Color.Select(c => new { c.Name }),
                    Material = c.Material.Select(c => new { c.Name }),
                    CPUSocket = c.CPUSocket.Select(c => new { c.Name }),

                });
            return result;
        }

        [HttpGet("CPUCooler/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        int? minLength = null, int? maxLength = null, int? exactLength = null,
        int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
        int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
        decimal? minWattage = null, decimal? maxWattage = null, decimal? exactWattage = null,
        decimal? minFanAirflow = null, decimal? maxFanAirflow = null, decimal? exactFanAirflow = null,
        decimal? minFanNoiseLevel = null, decimal? maxFanNoiseLevel = null, decimal? exactFanNoiseLevel = null,
        IEnumerable<string>? fans = null,
        IEnumerable<string>? mtbf = null,
        IEnumerable<string>? connector = null,
        IEnumerable<string>? fanBearing = null,
        IEnumerable<string>? fanSpeed = null,
        IEnumerable<string>? producer = null,
        IEnumerable<string>? coolingType = null,
        IEnumerable<string>? mount = null,
        IEnumerable<string>? heatPipes = null,
        IEnumerable<string>? tdp = null,
        IEnumerable<string>? material = null,
        IEnumerable<string>? cpuSocket = null,
        IEnumerable<string>? color = null

)

        {
#nullable disable

            IEnumerable<object> result = GetAsList();

            result = FilterDimensions(result, name, minPrice, maxPrice, exactPrice, minLength, maxLength, exactLength, minWidth, maxWidth, exactWidth, minHeight, maxHeight, exactHeight, producer);

            if (minWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("Wattage").GetValue(item)) >= minWattage);
            }
            if (maxWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("Wattage").GetValue(item)) <= maxWattage);
            }
            if (exactWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("Wattage").GetValue(item)) == exactWattage);
            }
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
            if (coolingType != null && coolingType.Any())
            {
                result = result.Where(item => coolingType.Contains(item.GetType().GetProperty("CoolingType").GetValue(item).ToString()));
            }

            if (mount != null && mount.Any())
            {
                result = result.Where(item => mount.Contains(item.GetType().GetProperty("Mount").GetValue(item).ToString()));
            }

            if (heatPipes != null && heatPipes.Any())
            {
                result = result.Where(item => heatPipes.Contains(item.GetType().GetProperty("HeatPipes").GetValue(item).ToString()));
            }

            if (tdp != null && tdp.Any())
            {
                result = result.Where(item => tdp.Contains(item.GetType().GetProperty("TDP").GetValue(item).ToString()));
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
            if (material != null && material.Any())
            {
                result = result.Where(item => {
                    var itemMaterials = item.GetType().GetProperty("Material").GetValue(item) as IEnumerable<object>;
                    if (itemMaterials != null)
                    {
                        foreach (var materialItem in itemMaterials)
                        {
                            var materialName = materialItem.GetType().GetProperty("Name").GetValue(materialItem)?.ToString();
                            if (materialName != null && material.Contains(materialName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (cpuSocket != null && cpuSocket.Any())
            {
                result = result.Where(item => {
                    var itemCpuSockets = item.GetType().GetProperty("CPUSocket").GetValue(item) as IEnumerable<object>;
                    if (itemCpuSockets != null)
                    {
                        foreach (var cpuSocketItem in itemCpuSockets)
                        {
                            var cpuSocketName = cpuSocketItem.GetType().GetProperty("Name").GetValue(cpuSocketItem)?.ToString();
                            if (cpuSocketName != null && cpuSocket.Contains(cpuSocketName))
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

        [HttpGet("CPUCooler/Compability/Motherboard")]
        public string CPUCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();
                   
                    // cpu socket
                    var cpuSocket = data["cpuSocket"].ToObject<List<dynamic>>();

                    foreach(var socket in cpuSocket)
                    {

                        cpuSocket = socket.name.ToString().Replace(" ", "%20");
                        urlBuilder.Append($"cpuSocket={cpuSocket}&");
                    }


                   
                    if (urlBuilder.Length > 0)
                    {
                        urlBuilder.Length--;
                    }

                    return urlBuilder.ToString();
                }
                catch (Exception)
                {
                    return string.Empty;
                }

            }
            return string.Empty;
        }

        [HttpGet("CPUCooler/Compability/CPU")]
        public string CPUCoolerCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    // cpu socket
                    var cpuSocket = data["cpuSocket"].ToObject<List<dynamic>>();

                    foreach (var socket in cpuSocket)
                    {

                        cpuSocket = socket.name.ToString().Replace(" ", "%20");
                        urlBuilder.Append($"cpuSocket={cpuSocket}&");
                    }



                    if (urlBuilder.Length > 0)
                    {
                        urlBuilder.Length--;
                    }

                    return urlBuilder.ToString();
                }
                catch (Exception)
                {
                    return string.Empty;
                }

            }
            return string.Empty;
        }
        [HttpGet("CPUCooler/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<CPUCooler>(id);
            return Ok(result);
        }

        [HttpGet("CPUCooler/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<CPUCooler>();
            return Ok(result);
        }

        [HttpPost("CPUCooler/Add")]
        public IActionResult Add([FromBody] CPUCooler newItem)
        {
            if (Add<CPUCooler>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid CPUCooler data");
        }

        [HttpDelete("CPUCooler/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<CPUCooler>(id);
        }

        [HttpPut("CPUCooler/Update")]
        public IActionResult Update(int id, [FromBody] CPUCooler newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}
