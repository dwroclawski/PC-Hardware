using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml.Linq;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class GPUController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("GPU/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();
            return Ok(result);
        }
        public IEnumerable<object> GetAsList()
        {
            var result = context.GPU
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
                 c.Wattage,
                 c.RecommendedPSUWattage,
                 c.StreamProcessors,
                 MaxMonitors = context.Enum_MaxMonitors
                         .Where(em => em.Id == c.MaxMonitorsId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 c.MemoryBandwidth,
                 c.MemoryFrequency,
                 c.BaseClock,
                 c.BoostClock,
                 ChipsetProducer = context.Enum_Producers
                         .Where(em => em.Id == c.ChipsetProducerId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 InterFace = context.Enum_Connectors
                         .Where(em => em.Id == c.InterFaceId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 Memory = context.Enum_Capacity
                         .Where(em => em.Id == c.MemoryId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 MemoryBus = context.Enum_MemoryBus
                         .Where(em => em.Id == c.MemoryBusId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 MemoryType = context.Enum_MemoryType
                         .Where(em => em.Id == c.MemoryTypeId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 PowerConnector = context.Enum_Connectors
                         .Where(em => em.Id == c.PowerConnectorID)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 Chipset = context.Enum_Chipset
                         .Where(em => em.Id == c.ChipsetID)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 Resolution = context.Enum_Resolution
                         .Where(em => em.Id == c.ResolutionID)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 Ports = c.Ports.Select(p => new { p.Name }),

             });
            return result;
        }

        [HttpGet("GPU/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        int? minLength = null, int? maxLength = null, int? exactLength = null,
        int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
        int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
        IEnumerable<string>? producer = null,
        decimal? minRecommendedPSUWattage = null, decimal? maxRecommendedPSUWattage = null, decimal? exactRecommendedPSUWattage = null,
        decimal? minWattage = null, decimal? maxWattage = null, decimal? exactWattage = null,
        int? minStreamProcessors = null, int? maxStreamProcessors = null, int? exactStreamProcessors = null,
        decimal? minMemoryBandwith = null, decimal? maxMemoryBandwith = null, decimal? exactMemoryBandwith = null,
        decimal? minMemoryFrequency = null, decimal? maxMemoryFrequency = null, decimal? exactMemoryFrequency = null,
        decimal? minBaseClock = null, decimal? maxBaseClock = null, decimal? exactBaseClock = null,
        decimal? minBoostClock = null, decimal? maxBoostClock = null, decimal? exactBoostClock = null,
        IEnumerable<string>? ports = null,
        IEnumerable<string>? chipsetProducer = null,
        IEnumerable<string>? interFace = null,
        IEnumerable<string>? memory = null,
        IEnumerable<string>? memoryBus = null,
        IEnumerable<string>? memoryType = null,
        IEnumerable<string>? powerConnector = null,
        IEnumerable<string>? chipset = null,
        IEnumerable<string>? resolution = null,
        IEnumerable<string>? maxMonitors = null

     )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();
            result = FilterDimensions(result, name, minPrice, maxPrice, exactPrice, minLength, maxLength, exactLength, minWidth, maxWidth, exactWidth, minHeight, maxHeight, exactHeight, producer);

            if(chipsetProducer != null && chipsetProducer.Any())
    {
                result = result.Where(item => chipsetProducer.Contains(item.GetType().GetProperty("ChipsetProducer").GetValue(item).ToString()));
            }

            if (interFace != null && interFace.Any())
            {
                result = result.Where(item => interFace
                .Contains(item.GetType().GetProperty("InterFace").GetValue(item).ToString()));
            }

            if (memory != null && memory.Any())
            {
                result = result.Where(item => memory.Contains(item.GetType().GetProperty("Memory").GetValue(item).ToString()));
            }

            if (memoryBus != null && memoryBus.Any())
            {
                result = result.Where(item => memoryBus.Contains(item.GetType().GetProperty("MemoryBus").GetValue(item).ToString()));
            }
            if (maxMonitors != null && maxMonitors.Any())
            {
                result = result.Where(item => maxMonitors.Contains(item.GetType().GetProperty("MaxMonitors").GetValue(item).ToString()));
            }


            if (memoryType != null && memoryType.Any())
            {
                result = result.Where(item => memoryType.Contains(item.GetType().GetProperty("MemoryType").GetValue(item).ToString()));
            }

            if (powerConnector != null && powerConnector.Any())
            {
                result = result.Where(item => powerConnector.Contains(item.GetType().GetProperty("PowerConnector").GetValue(item).ToString()));
            }

            if (chipset != null && chipset.Any())
            {
                result = result.Where(item => chipset.Contains(item.GetType().GetProperty("Chipset").GetValue(item).ToString()));
            }

            if (resolution != null && resolution.Any())
            {
                result = result.Where(item => resolution.Contains(item.GetType().GetProperty("Resolution").GetValue(item).ToString()));
            }


            if (minRecommendedPSUWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RecommendedPSUWattage").GetValue(item)) >= minRecommendedPSUWattage);
            }
            if (maxRecommendedPSUWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RecommendedPSUWattage").GetValue(item)) <= maxRecommendedPSUWattage);
            }
            if (exactRecommendedPSUWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("RecommendedPSUWattage").GetValue(item)) == exactRecommendedPSUWattage);
            }

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

            if (minStreamProcessors != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("StreamProcessors").GetValue(item)) >= minStreamProcessors);
            }
            if (maxStreamProcessors != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("StreamProcessors").GetValue(item)) <= maxStreamProcessors);
            }
            if (exactStreamProcessors != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("StreamProcessors").GetValue(item)) == exactStreamProcessors);
            }

            if (minMemoryBandwith != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MemoryBandwidth").GetValue(item)) >= minMemoryBandwith);
            }
            if (maxMemoryBandwith != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MemoryBandwith").GetValue(item)) <= maxMemoryBandwith);
            }
            if (exactMemoryBandwith != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MemoryBandwith").GetValue(item)) == exactMemoryBandwith);
            }

            if (minMemoryFrequency != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MemoryFrequency").GetValue(item)) >= minMemoryFrequency);
            }
            if (maxMemoryFrequency != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MemoryFrequency").GetValue(item)) <= maxMemoryFrequency);
            }
            if (exactMemoryFrequency != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MemoryFrequency").GetValue(item)) == exactMemoryFrequency);
            }

            if (minBaseClock != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("BaseClock").GetValue(item)) >= minBaseClock);
            }
            if (maxBaseClock != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("BaseClock").GetValue(item)) <= maxBaseClock);
            }
            if (exactBaseClock != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("BaseClock").GetValue(item)) == exactBaseClock);
            }

            if (minBoostClock != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("BoostClock").GetValue(item)) >= minBoostClock);
            }
            if (maxBoostClock != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("BoostClock").GetValue(item)) <= maxBoostClock);
            }
            if (exactBoostClock != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("BoostClock").GetValue(item)) == exactBoostClock);
            }

            if (ports != null && ports.Any())
            {
                result = result.Where(item => {
                    var itemPorts = item.GetType().GetProperty("Ports").GetValue(item) as IEnumerable<object>;
                    if (itemPorts != null)
                    {
                        foreach (var portItem in itemPorts)
                        {
                            var portName = portItem.GetType().GetProperty("Name").GetValue(portItem)?.ToString();
                            if (portName != null && ports.Contains(portName))
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

        [HttpGet("GPU/Compability/Motherboard")]
        public string MotherboardCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    // connector type -> exact
                    string item = data.interFace; 
                    if (item.Contains("PCIe"))
                    {
                        // if yes, then add all the PCIe 4.0 from the ConnectorEnum to the list
                        var pcie4s = context.Enum_Connectors
                        .Where(em => em.Name.Contains("PCIe"))
                        .Select(em => em.Name)
                        .ToList();

                        foreach (var name in pcie4s)
                        {
                            string result = name.ToString().Replace(" ", "%20");
                            urlBuilder.Append($"internalConnectors={result}&");
                        }
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
        [HttpGet("GPU/Compability/Case")]
        public string CaseCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    string item = data.length;
                    urlBuilder.Append($"minMaxGPULength={item}&");


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

        [HttpGet("GPU/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<GPU>(id);
            return Ok(result);
        }

        [HttpGet("GPU/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<GPU>();
            return Ok(result);
        }

        [HttpPost("GPU/Add")]
        public IActionResult Add([FromBody] GPU newItem)
        {
            if (Add<GPU>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid GPU data");
        }

        [HttpDelete("GPU/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<GPU>(id);
        }

        [HttpPut("GPU/Update")]
        public IActionResult Update(int id, [FromBody] GPU newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}
