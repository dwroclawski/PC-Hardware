using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using VueBase.Data;
using VueBase.Models;

namespace VueBase.Controllers
{
    public class MotherboardController : BaseController
    {
        private readonly PCContext context = new();

        [HttpGet("Motherboard/Get")]
        public IActionResult GetAll()
        {

            var result = GetAsList();
            return Ok(result);

        }

        public IEnumerable<object> GetAsList()
        {
            var result = context.Motherboard
          .Select(c => new
          {

              c.Name,
                 c.Price,
                 Producer = context.Enum_Producers
                         .Where(em => em.Id == c.ProducerId)
                         .Select(em => em.Name)
                         .FirstOrDefault(),
                 MemorySlots = context.Enum_MemorySlots
                              .Where(em => em.Id == c.MemorySlotsId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 FormFactor = context.Enum_FormFactor
                              .Where(em => em.Id == c.FormFactorId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 CPUSocket = context.Enum_CPUSocket
                              .Where(em => em.Id == c.CPUSocketId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 Chipset = context.Enum_MotherboardChipset
                              .Where(em => em.Id == c.ChipsetId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 CPUFamily = context.Enum_CPUFamily
                              .Where(em => em.Id == c.CPUFamilyId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 MaxMemory = context.Enum_Capacity
                              .Where(em => em.Id == c.MaxMemoryId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 MemoryChannel = context.Enum_MemoryChannel
                              .Where(em => em.Id == c.MemoryChannelId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 InternalGPUSupport = context.Enum_InternalGPUSupport
                              .Where(em => em.Id == c.InternalGPUSupportId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 MemoryConnectorType = context.Enum_MemoryConnectorType
                              .Where(em => em.Id == c.MemoryConnectorTypeId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 MemoryType = context.Enum_MemoryType
                              .Where(em => em.Id == c.MemoryTypeId)
                              .Select(em => em.Name)
                              .FirstOrDefault(),
                 InternalConnectors = c.InternalConnectors.Select(c => new { c.Name }),
                 ExternalConnectors = c.ExternalConnectors.Select(c => new { c.Name }),
                 MemoryFrequencies = c.MemoryFrequencies.Select(c => new { c.Name }),
                 WirelessTechnologies = c.WirelessTechnologies.Select(c => new { c.Name }),
                 RAID = c.RAID.Select(c => new { c.Name })


             });
            return result;
        }

        [HttpGet("Motherboard/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        IEnumerable<string>? memorySlots = null,
        IEnumerable<string>? raid = null,
        IEnumerable<string>? wirelessTechnologies = null,
        IEnumerable<string>? memoryFrequencies = null,
        IEnumerable<string>? externalConnectors = null,
        IEnumerable<string>? internalConnectors = null,
        IEnumerable<string>? formFactor = null,
        IEnumerable<string>? cpuSocket = null,
        IEnumerable<string>? chipset = null,
        IEnumerable<string>? cpuFamily = null,
        IEnumerable<string>? maxMemory = null,
        IEnumerable<string>? memoryChannel = null,
        IEnumerable<string>? internalGPUSupport = null,
        IEnumerable<string>? memoryConnectorType = null,
        IEnumerable<string>? memoryType = null,
        IEnumerable<string>? producer = null
     )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();
            result = FilterBase(result, name, minPrice, maxPrice, exactPrice, producer);

            if (raid != null && raid.Any())
            {
                result = result.Where(item => {
                    var itemRaids = item.GetType().GetProperty("RAID").GetValue(item) as IEnumerable<object>;
                    if (itemRaids != null)
                    {
                        foreach (var raidItem in itemRaids)
                        {
                            var raidName = raidItem.GetType().GetProperty("Name").GetValue(raidItem)?.ToString();
                            if (raidName != null && raid.Contains(raidName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (wirelessTechnologies != null && wirelessTechnologies.Any())
            {
                result = result.Where(item => {
                    var itemWirelessTechnologies = item.GetType().GetProperty("WirelessTechnologies").GetValue(item) as IEnumerable<object>;
                    if (itemWirelessTechnologies != null)
                    {
                        foreach (var wirelessTechnologyItem in itemWirelessTechnologies)
                        {
                            var wirelessTechnologyName = wirelessTechnologyItem.GetType().GetProperty("Name").GetValue(wirelessTechnologyItem)?.ToString();
                            if (wirelessTechnologyName != null && wirelessTechnologies.Contains(wirelessTechnologyName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (memoryFrequencies != null && memoryFrequencies.Any())
            {
                result = result.Where(item => {
                    var itemMemoryFrequencies = item.GetType().GetProperty("MemoryFrequencies").GetValue(item) as IEnumerable<object>;
                    if (itemMemoryFrequencies != null)
                    {
                        foreach (var memoryFrequencyItem in itemMemoryFrequencies)
                        {
                            var memoryFrequencyName = memoryFrequencyItem.GetType().GetProperty("Name").GetValue(memoryFrequencyItem)?.ToString();
                            if (memoryFrequencyName != null && memoryFrequencies.Contains(memoryFrequencyName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (externalConnectors != null && externalConnectors.Any())
            {
                result = result.Where(item => {
                    var itemExternalConnectors = item.GetType().GetProperty("ExternalConnectors").GetValue(item) as IEnumerable<object>;
                    if (itemExternalConnectors != null)
                    {
                        foreach (var externalConnectorItem in itemExternalConnectors)
                        {
                            var externalConnectorName = externalConnectorItem.GetType().GetProperty("Name").GetValue(externalConnectorItem)?.ToString();
                            if (externalConnectorName != null && externalConnectors.Contains(externalConnectorName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (internalConnectors != null && internalConnectors.Any())
            {
                result = result.Where(item => {
                    var itemInternalConnectors = item.GetType().GetProperty("InternalConnectors").GetValue(item) as IEnumerable<object>;
                    if (itemInternalConnectors != null)
                    {
                        foreach (var internalConnectorItem in itemInternalConnectors)
                        {
                            var internalConnectorName = internalConnectorItem.GetType().GetProperty("Name").GetValue(internalConnectorItem)?.ToString();
                            if (internalConnectorName != null && internalConnectors.Contains(internalConnectorName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (memorySlots != null && memorySlots.Any())
            {
                result = result.Where(item => memorySlots.Contains(item.GetType().GetProperty("MemorySlots").GetValue(item).ToString()));
            }

            if (formFactor != null && formFactor.Any())
            {
                result = result.Where(item => formFactor.Contains(item.GetType().GetProperty("FormFactor").GetValue(item).ToString()));
            }

            if (cpuSocket != null && cpuSocket.Any())
            {
                result = result.Where(item => cpuSocket.Contains(item.GetType().GetProperty("CPUSocket").GetValue(item).ToString()));
            }

            if (chipset != null && chipset.Any())
            {
                result = result.Where(item => chipset.Contains(item.GetType().GetProperty("Chipset").GetValue(item).ToString()));
            }

            if (cpuFamily != null && cpuFamily.Any())
            {
                result = result.Where(item => cpuFamily.Contains(item.GetType().GetProperty("CPUFamily").GetValue(item).ToString()));
            }

            if (maxMemory != null && maxMemory.Any())
            {
                result = result.Where(item => maxMemory.Contains(item.GetType().GetProperty("MaxMemory").GetValue(item).ToString()));
            }

            if (memoryChannel != null && memoryChannel.Any())
            {
                result = result.Where(item => memoryChannel.Contains(item.GetType().GetProperty("MemoryChannel").GetValue(item).ToString()));
            }

            if (internalGPUSupport != null && internalGPUSupport.Any())
            {
                result = result.Where(item => internalGPUSupport.Contains(item.GetType().GetProperty("InternalGPUSupport").GetValue(item).ToString()));
            }

            if (memoryConnectorType != null && memoryConnectorType.Any())
            {
                result = result.Where(item => memoryConnectorType.Contains(item.GetType().GetProperty("MemoryConnectorType").GetValue(item).ToString()));
            }

            if (memoryType != null && memoryType.Any())
            {
                result = result.Where(item => memoryType.Contains(item.GetType().GetProperty("MemoryType").GetValue(item).ToString()));
            }
            return result;
        }



        [HttpGet("Motherboard/Compability/CPU")]
        public string CPUCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();
                    //iGPU -> filter only when no
                    string iGPU = data.internalGPUSupport;

                    if (iGPU == "No")
                    {
                        iGPU = iGPU.Replace(" ", "%20");

                        urlBuilder.Append($"internalGPU={iGPU}&");
                    }

                    // cpu socket
                    string cpuSocket = data.cpuSocket;
                    cpuSocket = cpuSocket.Replace(" ", "%20");
                    urlBuilder.Append($"cpuSocket={cpuSocket}&");

                    // cpu family
                    string cpuFamily = data.cpuFamily;
                    cpuFamily = cpuFamily.Replace(" ", "%20");
                    urlBuilder.Append($"producer={cpuFamily}&");

                    //chipset
                    string chipset = data.chipset;
                    chipset = chipset.Replace(" ", "%20");
                    urlBuilder.Append($"motherboardChipsetCompatibility={chipset}&");

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
        [HttpGet("Motherboard/Compability/CPUCooler")]
        public string CPUCoolerCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();
                    

                    // cpu socket
                    string cpuSocket = data.cpuSocket;
                    cpuSocket = cpuSocket.Replace(" ", "%20");
                    urlBuilder.Append($"cpuSocket={cpuSocket}&");


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

        [HttpGet("Motherboard/Compability/GPU")]
        public string GPUCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

                    var itemList = data["internalConnectors"].ToObject<List<dynamic>>();
                    var urlBuilder = new StringBuilder();

                    // check if there is any PCIe 4.0 in the internal connectors
                    foreach (var item in itemList)
                    {
                        if (item.ToString().Contains("PCIe"))
                        {
                            // if yes, then add all the PCIe 4.0 from the ConnectorEnum to the list
                            var pcie4s = context.Enum_Connectors
                            .Where(em => em.Name.Contains("PCIe"))
                            .Select(em => em.Name)
                            .ToList();

                            foreach (var name in pcie4s)
                            {
                                string result = name.ToString().Replace(" ", "%20");
                                urlBuilder.Append($"interFace={result}&");
                            }
                            break;
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

        [HttpGet("Motherboard/Compability/HDD")]

        public string HDDCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    var itemList = data["internalConnectors"].ToObject<List<dynamic>>();
                    foreach (var item in itemList)
                    {
                        if (item.ToString().Contains("SATA"))
                        {
                            var pcie4s = context.Enum_Connectors
                            .Where(em => em.Name.Contains("SATA"))
                            .Select(em => em.Name)
                            .ToList();

                            foreach (var name in pcie4s)
                            {
                                string result = name.ToString().Replace(" ", "%20");
                                urlBuilder.Append($"interFace={result}&");
                            }
                            break;
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

        [HttpGet("Motherboard/Compability/Case")]

        public string CaseCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

                    var formFactor = data["formFactor"];

                    var urlBuilder = new StringBuilder();

                        string form = formFactor.ToString().Replace(" ", "%20");
                        urlBuilder.Append($"formFactor={form}&");
                    


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

        [HttpGet("Motherboard/Compability/RAM")]
        public string RAMCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

                    // memory frequencies -> list
                    var mFrequencies = data["memoryFrequencies"].ToObject<List<dynamic>>();
                    var urlBuilder = new StringBuilder();
                    foreach (var item in mFrequencies)
                    {
                        string result = item.name.ToString().Replace(" ", "%20");
                        urlBuilder.Append($"memoryFrequency={result}&");
                    }

                    // connector type -> exact
                    string memoryConnectorType = data.memoryConnectorType;
                    memoryConnectorType = memoryConnectorType.Replace(" ", "%20");
                    urlBuilder.Append($"connectorType={memoryConnectorType}&");

                    //modules -> exact/smaller
                    string memorySlots = data.memorySlots;
                    int memorySlotsId = context.Enum_MemorySlots
                     .Where(em => em.Name == memorySlots)
                     .Select(em => em.Id)
                     .FirstOrDefault();
                    var memorySlotNames = context.Enum_MemorySlots
                     .Where(em => em.Id <= memorySlotsId)
                     .Select(em => em.Name)
                     .ToList();
                    foreach (var name in memorySlotNames)
                    {
                        string result = name.Replace(" ", "%20");
                        urlBuilder.Append($"modules={result}&");
                    }

                    //memory -> exact/smaller
                    string memory = data.maxMemory;
                    int memoryId = context.Enum_Capacity
                     .Where(em => em.Name == memory)
                     .Select(em => em.Id)
                     .FirstOrDefault();
                    var memoryNames = context.Enum_Capacity
                     .Where(em => em.Id <= memoryId)
                     .Select(em => em.Name)
                     .ToList();
                    foreach (var name in memoryNames)
                    {
                        string result = name.Replace(" ", "%20");
                        urlBuilder.Append($"memory={result}&");
                    }

                    // memory type -> exact
                    string memoryType = data.memoryType;
                    memoryType = memoryType.Replace(" ", "%20");
                    urlBuilder.Append($"memoryType={memoryType}&");


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

        [HttpGet("Motherboard/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<Motherboard>(id);
            return Ok(result);
        }

        [HttpGet("Motherboard/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<Motherboard>();
            return Ok(result);
        }

        [HttpPost("Motherboard/Add")]
        public IActionResult Add([FromBody] Motherboard newItem)
        {
            if (Add<Motherboard>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid Motherboard data");
        }

        [HttpDelete("Motherboard/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<Motherboard>(id);
        }

        [HttpPut("Motherboard/Update")]
        public IActionResult Update(int id, [FromBody] Motherboard newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}