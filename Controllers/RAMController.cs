using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.RegularExpressions;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class RAMController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("RAM/Get")]
        public IActionResult GetAll()
        {

            var result = GetAsList();

            return Ok(result);
        }
        public IEnumerable<object> GetAsList()
        {
            var result = context.RAM
               .Select(c => new
               {
                   c.Name,
                   c.Price,
                   Producer = context.Enum_Producers
                           .Where(em => em.Id == c.ProducerId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   Modules = context.Enum_MemorySlots
                           .Where(em => em.Id == c.ModulesId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   CoolingType = context.Enum_CoolingType
                           .Where(em => em.Id == c.CoolingTypeId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   MemoryFrequency = context.Enum_MemoryFrequency
                           .Where(em => em.Id == c.MemoryFrequencyId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   Voltage = context.Enum_Voltage
                           .Where(em => em.Id == c.VoltageId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   Memory = context.Enum_Capacity
                           .Where(em => em.Id == c.MemoryId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   MemoryType = context.Enum_MemoryType
                           .Where(em => em.Id == c.MemoryTypeId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   ConnectorType = context.Enum_MemoryConnectorType
                           .Where(em => em.Id == c.ConnectorTypeId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   CycleLatency = context.Enum_CycleLatency
                           .Where(em => em.Id == c.CycleLatencyId)
                           .Select(em => em.Name)
                           .FirstOrDefault(),
                   Color = c.Color.Select(c => new { c.Name }),
                   Overclocking = c.Overclocking.Select(c => new { c.Name }),

               });
            return result;
        }


        [HttpGet("RAM/Compability/CPU")]
        public string CPUCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

              
                    //memory -> exact/bigger
                    string memory = data.memory;
                    int memoryId = context.Enum_Capacity
                     .Where(em => em.Name == memory)
                     .Select(em => em.Id)
                     .FirstOrDefault();
                    var memoryNames = context.Enum_Capacity
                     .Where(em => em.Id >= memoryId)
                     .Select(em => em.Name)
                     .ToList();
                    foreach (var name in memoryNames)
                    {
                        string result = name.Replace(" ", "%20");
                        urlBuilder.Append($"maxMemory={result}&");
                    }


                    //memoryType -> CPU contains the type
                    // memoryFrequency -> equal or smaller
                    var memoryType = data.memoryType;
                    var memoryFrequency = data.memoryFrequency;
                    string rem = "MHz";
                    memoryFrequency = memoryFrequency.ToString();
                    int index = memoryFrequency.IndexOf(rem);
                    memoryFrequency = (index < 0)
                        ? memoryFrequency
                        : memoryFrequency.Remove(index, rem.Length);

                    var memoryTypeEnum = context.Enum_MemoryTypeFrequency
                           .Select(em => em.Name)
                           .ToList();
                    string pattern = @"\d+";


                    foreach (var type in memoryTypeEnum) {
                        if (type.Contains(memoryType.ToString()) )
                        {
                            rem = memoryType.ToString();
                            var typeless = type;
                            index = type.IndexOf(rem);
                            typeless = (index < 0)
                                ? typeless
                                : typeless.Remove(index, rem.Length);
                            Match match = Regex.Match(typeless, pattern); //searches for the pattern 
                            if (match.Success)
                            {
                                int ram = int.Parse(memoryFrequency);
                                int mtf = int.Parse(match.Value);

                                if (ram <= mtf)
                                {
                                    string result = type.Replace(" ", "%20");
                                    urlBuilder.Append($"memoryTypes={result}&");
                                }
                            }

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


        [HttpGet("RAM/Compability/Motherboard")]
        public string MotherboardCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    // connector type -> exact
                    string ConnectorType = data.connectorType;
                    ConnectorType = ConnectorType.Replace(" ", "%20");
                    urlBuilder.Append($"memoryConnectorType={ConnectorType}&");

                    //modules -> exact/bigger
                    string modules = data.modules;
                    int modulesId = context.Enum_MemorySlots
                     .Where(em => em.Name == modules)
                     .Select(em => em.Id)
                     .FirstOrDefault();
                    var modulesNames = context.Enum_MemorySlots
                     .Where(em => em.Id >= modulesId)
                     .Select(em => em.Name)
                     .ToList();
                    foreach (var name in modulesNames)
                    {
                        string result = name.Replace(" ", "%20");
                        urlBuilder.Append($"memorySlots={result}&");
                    }

                    //memory -> exact/bigger
                    string memory = data.memory;
                    int memoryId = context.Enum_Capacity
                     .Where(em => em.Name == memory)
                     .Select(em => em.Id)
                     .FirstOrDefault();
                    var memoryNames = context.Enum_Capacity
                     .Where(em => em.Id >= memoryId)
                     .Select(em => em.Name)
                     .ToList();
                    foreach (var name in memoryNames)
                    {
                        string result = name.Replace(" ", "%20");
                        urlBuilder.Append($"maxMemory={result}&");
                    }

                    // memory type -> exact
                    string memoryType = data.memoryType;
                    memoryType = memoryType.Replace(" ", "%20");
                    urlBuilder.Append($"memoryType={memoryType}&");

                    // frequency
                    string memoryFrequency = data.memoryFrequency;
                    memoryFrequency = memoryFrequency.Replace(" ", "%20");
                    urlBuilder.Append($"memoryFrequencies={memoryFrequency}&");


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


        [HttpGet("RAM/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        IEnumerable<string>? coolingType = null,
        IEnumerable<string>? memoryFrequency = null,
        IEnumerable<string>? voltage = null,
        IEnumerable<string>? memory = null,
        IEnumerable<string>? memoryType = null,
        IEnumerable<string>? connectorType = null,
        IEnumerable<string>? producer = null,
        IEnumerable<string>? color = null,
        IEnumerable<string>? cycleLatency = null,
        IEnumerable<string>? modules = null,
        IEnumerable<string>? overclocking = null

     )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();

            result = FilterBase(result, name, minPrice, maxPrice, exactPrice, producer);

            if (modules != null && modules.Any())
            {
                result = result.Where(item => modules.Contains(item.GetType().GetProperty("Modules").GetValue(item).ToString()));
            }


            if (coolingType != null && coolingType.Any())
            {
                result = result.Where(item => coolingType.Contains(item.GetType().GetProperty("CoolingType").GetValue(item).ToString()));
            }

            if (memoryFrequency != null && memoryFrequency.Any())
            {
                result = result.Where(item => memoryFrequency.Contains(item.GetType().GetProperty("MemoryFrequency").GetValue(item).ToString()));
            }

            if (voltage != null && voltage.Any())
            {
                result = result.Where(item => voltage.Contains(item.GetType().GetProperty("Voltage").GetValue(item).ToString()));
            }

            if (memory != null && memory.Any())
            {
                result = result.Where(item => memory.Contains(item.GetType().GetProperty("Memory").GetValue(item).ToString()));
            }

            if (memoryType != null && memoryType.Any())
            {
                result = result.Where(item => memoryType.Contains(item.GetType().GetProperty("MemoryType").GetValue(item).ToString()));
            }

            if (connectorType != null && connectorType.Any())
            {
                result = result.Where(item => connectorType.Contains(item.GetType().GetProperty("ConnectorType").GetValue(item).ToString()));
            }

            if (cycleLatency != null && cycleLatency.Any())
            {
                result = result.Where(item => cycleLatency.Contains(item.GetType().GetProperty("CycleLatency").GetValue(item).ToString()));
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
            if (overclocking != null && overclocking.Any())
            {
                result = result.Where(item => {
                    var itemOverclockings = item.GetType().GetProperty("Overclocking").GetValue(item) as IEnumerable<object>;
                    if (itemOverclockings != null)
                    {
                        foreach (var overclockingItem in itemOverclockings)
                        {
                            var overclockingName = overclockingItem.GetType().GetProperty("Name").GetValue(overclockingItem)?.ToString();
                            if (overclockingName != null && overclocking.Contains(overclockingName))
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

        [HttpGet("RAM/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<RAM>(id);
            return Ok(result);
        }

        [HttpGet("RAM/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<RAM>();
            return Ok(result);
        }

        [HttpPost("RAM/Add")]
        public IActionResult Add([FromBody] RAM newItem)
        {
            if (Add<RAM>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid RAM data");
        }

        [HttpDelete("RAM/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<RAM>(id);
        }

        [HttpPut("RAM/Update")]
        public IActionResult Update(int id, [FromBody] RAM newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}