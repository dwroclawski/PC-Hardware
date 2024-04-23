using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using VueBase.Data;
using VueBase.Models;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;

namespace VueBase.Controllers
{
    public class CPUController : BaseController
    {
        private readonly PCContext context = new();


        [HttpGet("CPU/Get")]
        public IActionResult GetAll()
        {

            var result = GetAsList();
            return Ok(result);
        }

        public IEnumerable<object> GetAsList()
        {
            var result = context.CPU
          .Select(c => new
          {
              c.Name,
              c.Price,
              Producer = context.Enum_Producers
                      .Where(em => em.Id == c.ProducerId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              Cores = context.Enum_CPUCores
                      .Where(em => em.Id == c.CoresId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              Threads = context.Enum_CPUThreads
                      .Where(em => em.Id == c.ThreadsId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              c.BaseClock,
              c.BoostClock,
              UnlockedMultiplier = context.Enum_UnlockedMultiplier
                      .Where(em => em.Id == c.UnlockedMultiplierId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              c.Wattage,
              c.MaxWattage,
              MaxMemory = context.Enum_Capacity
                      .Where(em => em.Id == c.MaxMemoryId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              CPUSocket = context.Enum_CPUSocket
                      .Where(em => em.Id == c.CPUSocketId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              DataWidth = context.Enum_DataWidth
                      .Where(em => em.Id == c.DataWidthId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              CacheL1 = context.Enum_Cache
                      .Where(em => em.Id == c.CacheL1Id)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              CacheL2 = context.Enum_Cache
                      .Where(em => em.Id == c.CacheL2Id)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              CacheL3 = context.Enum_Cache
                      .Where(em => em.Id == c.CacheL3Id)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              Lithography = context.Enum_Lithography
                      .Where(em => em.Id == c.LithographyId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              MemoryChannel = context.Enum_MemoryChannel
                      .Where(em => em.Id == c.MemoryChannelId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              Microarchitecture = context.Enum_Microarchitecture
                      .Where(em => em.Id == c.MicroarchitectureId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              InternalGPU = context.Enum_InternalGPU
                      .Where(em => em.Id == c.InternalGPUId)
                      .Select(em => em.Name)
                      .FirstOrDefault(),
              MemoryTypes = c.MemoryTypes.Select(c => new { c.Name }),
              MotherboardChipsetCompatibility = c.MotherboardChipsetCompatibility.Select(c => new { c.Name }),

          });
            return result;
        }
        [HttpGet("CPU/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
        string? name = null,
        int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
        decimal? minBaseClock = null, decimal? maxBaseClock = null, decimal? exactBaseClock = null,
        decimal? minBoostClock = null, decimal? maxBoostClock = null, decimal? exactBoostClock = null,
        decimal? minWattage = null, decimal? maxWattage = null, decimal? exactWattage = null,
        decimal? minMaxWattage = null, decimal? maxMaxWattage = null, decimal? exactMaxWattage = null,
        IEnumerable<string>? producer = null,
        IEnumerable<string>? maxMemory = null,
        IEnumerable<string>? cpuSocket = null,
        IEnumerable<string>? cores = null,
        IEnumerable<string>? threads = null,
        IEnumerable<string>? unlockedMultiplier = null,
        IEnumerable<string>? dataWidth = null,
        IEnumerable<string>? cacheL1 = null,
        IEnumerable<string>? cacheL2 = null,
        IEnumerable<string>? cacheL3 = null,
        IEnumerable<string>? lithography = null,
        IEnumerable<string>? memoryChannel = null,
        IEnumerable<string>? microarchitecture = null,
        IEnumerable<string>? internalGPU = null,
        IEnumerable<string>? memoryTypes = null,
        IEnumerable<string>? motherboardChipsetCompatibility = null
     )

        {
#nullable disable

            IEnumerable<object> result = GetAsList();
            result = FilterBase(result, name, minPrice, maxPrice, exactPrice,  producer);

            if (maxMemory != null && maxMemory.Any())
            {
                result = result.Where(item => maxMemory.Contains(item.GetType().GetProperty("MaxMemory").GetValue(item).ToString()));
            }

            if (cpuSocket != null && cpuSocket.Any())
            {
                result = result.Where(item => cpuSocket.Contains(item.GetType().GetProperty("CPUSocket").GetValue(item).ToString()));
            }

            if (dataWidth != null && dataWidth.Any())
            {
                result = result.Where(item => dataWidth.Contains(item.GetType().GetProperty("DataWidth").GetValue(item).ToString()));
            }

            if (cores != null && cores.Any())
            {
                result = result.Where(item => cores.Contains(item.GetType().GetProperty("Cores").GetValue(item).ToString()));
            }
            if (unlockedMultiplier != null && unlockedMultiplier.Any())
            {
                result = result.Where(item => unlockedMultiplier.Contains(item.GetType().GetProperty("UnlockedMultiplier").GetValue(item).ToString()));
            }


            if (cacheL1 != null && cacheL1.Any())
            {
                result = result.Where(item => cacheL1.Contains(item.GetType().GetProperty("CacheL1").GetValue(item).ToString()));
            }

            if (cacheL2 != null && cacheL2.Any())
            {
                result = result.Where(item => cacheL2.Contains(item.GetType().GetProperty("CacheL2").GetValue(item).ToString()));
            }

            if (cacheL3 != null && cacheL3.Any())
            {
                result = result.Where(item => cacheL3.Contains(item.GetType().GetProperty("CacheL3").GetValue(item).ToString()));
            }

            if (lithography != null && lithography.Any())
            {
                result = result.Where(item => lithography.Contains(item.GetType().GetProperty("Lithography").GetValue(item).ToString()));
            }

            if (memoryChannel != null && memoryChannel.Any())
            {
                result = result.Where(item => memoryChannel.Contains(item.GetType().GetProperty("MemoryChannel").GetValue(item).ToString()));
            }

            if (microarchitecture != null && microarchitecture.Any())
            {
                result = result.Where(item => microarchitecture.Contains(item.GetType().GetProperty("Microarchitecture").GetValue(item).ToString()));
            }

            if (internalGPU != null && internalGPU.Any())
            {
                result = result.Where(item => internalGPU.Contains(item.GetType().GetProperty("InternalGPU").GetValue(item).ToString()));
            }

            if (threads != null && threads.Any())
            {
                result = result.Where(item => threads.Contains(item.GetType().GetProperty("Threads").GetValue(item).ToString()));
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

            if (minMaxWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxWattage").GetValue(item)) >= minMaxWattage);
            }
            if (maxMaxWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxWattage").GetValue(item)) <= maxMaxWattage);
            }
            if (exactMaxWattage != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxWattage").GetValue(item)) == exactMaxWattage);
            }


            if (memoryTypes != null && memoryTypes.Any())
            {
                result = result.Where(item => {
                    var itemMemoryTypes = item.GetType().GetProperty("MemoryTypes").GetValue(item) as IEnumerable<object>;
                    if (itemMemoryTypes != null)
                    {
                        foreach (var memoryTypeItem in itemMemoryTypes)
                        {
                            var memoryTypeName = memoryTypeItem?.GetType().GetProperty("Name").GetValue(memoryTypeItem)?.ToString();
                            if (memoryTypeName != null && memoryTypes.Contains(memoryTypeName))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                });
            }

            if (motherboardChipsetCompatibility != null && motherboardChipsetCompatibility.Any())
            {
                result = result.Where(item => {
                    var itemChipsetCompability = item.GetType().GetProperty("MotherboardChipsetCompatibility").GetValue(item) as IEnumerable<object>;
                    if (itemChipsetCompability != null)
                    {
                        foreach (var chipsetCompabilityItem in itemChipsetCompability)
                        {
                            var chipsetCompabilityName = chipsetCompabilityItem?.GetType().GetProperty("Name").GetValue(chipsetCompabilityItem)?.ToString();
                            if (chipsetCompabilityName != null && motherboardChipsetCompatibility.Contains(chipsetCompabilityName))
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


        [HttpGet("CPU/Compability/RAM")]
        public string RAMCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();


                    //memory -> exact/bigger
                    string memory = data.maxMemory;
                    int memoryId = context.Enum_Capacity
                     .Where(em => em.Name == memory)
                     .Select(em => em.Id)
                     .FirstOrDefault();
                    var memoryNames = context.Enum_Capacity
                     .Where(em => em.Id <= memoryId).Where(em => em.Id > 1)
                     .Select(em => em.Name)
                     .ToList();
                    foreach (var name in memoryNames)
                    {
                        string result = name.Replace(" ", "%20");
                        urlBuilder.Append($"memory={result}&");
                    }


                    //memoryType -> CPU contains the type 
                    // memoryFrequency -> ram equal or smaller
                    var memoryType = data["memoryTypes"].ToObject<List<dynamic>>();
                    var memoryTypeEnum = context.Enum_MemoryType
                           .Select(em => em.Name)
                           .ToList();
                    var memoryFrequencyEnum = context.Enum_MemoryFrequency
                           .Select(em => em.Name)
                           .ToList();
                    string pattern = @"\d+";

                    foreach (var mtf in memoryType) // compares every list item
                    {
                        foreach (var type in memoryTypeEnum) // compares every memory type
                            {
                            if (mtf.ToString().Contains(type.ToString()))
                            {

                                string resultType = type.Replace(" ", "%20");
                                urlBuilder.Append($"memoryType={resultType}&");
                                foreach (var freq in memoryFrequencyEnum) // compares every frequency
                                {
                                    // frequency value
                                    string remFreq = "MHz";
                                    var freqless = freq;

                                    int index = freqless.IndexOf(remFreq);
                                    freqless = (index < 0)
                                    ? freqless
                                        : freqless.Remove(index, remFreq.Length);

                                    // gets frequency of mtf 
                                    index = mtf.ToString().IndexOf(type.ToString());
                                    var typeless = mtf.ToString();
                                    typeless = (index < 0)
                                        ? typeless
                                        : typeless.Remove(index, type.ToString().Length);
                                    Match match = Regex.Match(typeless, pattern); //searches for the pattern 
                                    Match matchFreq = Regex.Match(freqless, pattern); //searches for the pattern 

                                    if (match.Success)
                                    {
                                        if (matchFreq.Success)
                                        {
                                            int ram = int.Parse(freqless.ToString());
                                            int cpu = int.Parse(match.Value);

                                            //checks if ram frequency >= cppu frequency
                                            if (ram <= cpu && !urlBuilder.ToString().Contains(freq.Replace(" ", "%20")))
                                            {

                                                string resultFreq = freq.Replace(" ", "%20");
                                                urlBuilder.Append($"memoryFrequency={resultFreq}&");

                                            }
                                        }
                                    }
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

        [HttpGet("CPU/Compability/Motherboard")]
        public string CPUCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    //iGPU -> filter only when exists
                    string iGPU = data.internalGPU;

                    if (!(iGPU == "None"))
                    {
                        urlBuilder.Append($"internalGPU=Yes&");
                    }

                    // cpu socket
                    string cpuSocket = data.cpuSocket;
                    cpuSocket = cpuSocket.Replace(" ", "%20");
                    urlBuilder.Append($"cpuSocket={cpuSocket}&");

                    // cpu family
                    string cpuFamily = data.producer;
                    cpuFamily = cpuFamily.Replace(" ", "%20");
                    urlBuilder.Append($"cpuFamily={cpuFamily}&");

                    //chipset
                    var motherboardChipset = data["motherboardChipsetCompatibility"].ToObject<List<dynamic>>();
                    foreach(var chip in motherboardChipset)
                    {
                        var chipset = chip["name"].ToString().Replace(" ", "%20");
                        urlBuilder.Append($"chipset={chipset}&");
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
        [HttpGet("CPU/Compability/CPUCooler")]
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





        [HttpGet("CPU/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetId<CPU>(id);
            return Ok(result);
        }

        [HttpGet("CPU/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<CPU>();
            return Ok(result);
        }

        [HttpPost("CPU/Add")]
        public IActionResult Add([FromBody] CPU newItem)
        {
            if (Add<CPU>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid CPU data");
        }

        [HttpDelete("CPU/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<CPU>(id);
        }

        [HttpPut("CPU/Update")]
        public IActionResult Update(int id, [FromBody] CPU newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}
