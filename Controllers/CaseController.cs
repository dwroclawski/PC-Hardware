using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using VueBase.Data;
using VueBase.Models;
using System.Text;
using System;
using Newtonsoft.Json;
using System.Runtime.Intrinsics.X86;

namespace VueBase.Controllers
{
    public class CaseController : BaseController
    {
        private readonly PCContext context = new();


       

        [HttpGet("Case/Get")]
        public IActionResult GetAll()
        {
            var result = GetAsList();
            return Ok(result);
        }
        public IEnumerable<object> GetAsList()
        {
            var result = context.Case
                 .Select(c => new
                 {
                     c.Name,
                     c.Price,
                     Producer = context.Enum_Producers
                             .Where(em => em.Id == c.ProducerId)
                             .Select(em => em.Name)
                             .FirstOrDefault(),
                     Type = context.Enum_CaseType
                             .Where(em => em.Id == c.TypeId)
                             .Select(em => em.Name)
                             .FirstOrDefault(),
                     c.Length,
                     c.Width,
                     c.Height,
                     c.MaxFanCount,
                     c.InstalledFanCount,
                     c.ExpansionSlots,
                     c.MaxGPULength,
                     c.MaxCPUCoolerHeight,
                     SidePanelMaterial = context.Enum_Material
                             .Where(em => em.Id == c.SidePanelMaterialId)
                             .Select(em => em.Name)
                             .FirstOrDefault(),
                     Material = c.Material.Select(m => new { m.Name }),
                     Ports = c.Ports.Select(p => new { p.Name }),
                     FormFactor = c.FormFactor.Select(f => new { f.Name }),
                     PSUMount = c.PSUMount.Select(p => new { p.Name }),
                     Buttons = c.Buttons.Select(b => new { b.Name }),
                     DriveBay = c.DriveBay.Select(d => new { d.Name }),
                     Color = c.Color.Select(c => new { c.Name }),
                     InstalledFans = c.InstalledFans.Select(i => new { i.Name }),
                     FanBays = c.FanBays.Select(c => new { c.Name }),
                     WaterCoolingSlots = c.WaterCoolingSlots.Select(w => new { w.Name })
                 });
            return result;
        }

     
            [HttpGet("Case/Filter")]
#nullable enable
        public IEnumerable<object> Filter(
     string? name = null,
     int? minPrice = null, int? maxPrice = null, int? exactPrice = null,
     int? minLength = null, int? maxLength = null, int? exactLength = null,
     int? minWidth = null, int? maxWidth = null, int? exactWidth = null,
     int? minHeight = null, int? maxHeight = null, int? exactHeight = null,
     IEnumerable<string>? producer = null,
     int? minMaxFanCount = null, int? maxMaxFanCount = null, int? exactMaxFanCount = null,
    int? minInstalledFanCount = null, int? maxInstalledFanCount = null, int? exactInstalledFanCount = null,
    int? minExpansionSlots = null, int? maxExpansionSlots = null, int? exactExpansionSlots = null,
    decimal? minMaxGPULength = null, decimal? maxMaxGPULength = null, decimal? exactMaxGPULength = null,
    decimal? minMaxCPUCoolerHeight = null, decimal? maxMaxCPUCoolerHeight = null, decimal? exactMaxCPUCoolerHeight = null,
IEnumerable<string>? type = null,
    IEnumerable<string>? sidePanelMaterial = null,
       IEnumerable<string>? material = null,
    IEnumerable<string>? ports = null,
    IEnumerable<string>? formFactor = null,
    IEnumerable<string>? psuMount = null,
    IEnumerable<string>? buttons = null,
    IEnumerable<string>? driveBay = null,
    IEnumerable<string>? color = null,
    IEnumerable<string>? installedFans = null,
    IEnumerable<string>? fanBays = null,
    IEnumerable<string>? waterCoolingSlots = null)

        {
#nullable disable

            IEnumerable<object> result = GetAsList();
            result = FilterDimensions(result, name, minPrice, maxPrice, exactPrice, minLength, maxLength, exactLength, minWidth, maxWidth, exactWidth, minHeight, maxHeight, exactHeight, producer);
            if (type != null && type.Any())
            {
                result = result.Where(item => type.Contains(item.GetType().GetProperty("Type").GetValue(item).ToString()));
            }

            if (sidePanelMaterial != null && sidePanelMaterial.Any())
            {
                result = result.Where(item => sidePanelMaterial.Contains(item.GetType().GetProperty("SidePanelMaterial").GetValue(item).ToString()));
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

            if (formFactor != null && formFactor.Any())
            {
                result = result.Where(item => {
                    var itemFormFactors = item.GetType().GetProperty("FormFactor").GetValue(item) as IEnumerable<object>;
                    if (itemFormFactors != null)
                    {
                        foreach (var formFactorItem in itemFormFactors)
                        {
                            var formFactorName = formFactorItem.GetType().GetProperty("Name").GetValue(formFactorItem)?.ToString();
                            if (formFactorName != null && formFactor.Contains(formFactorName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (psuMount != null && psuMount.Any())
            {
                result = result.Where(item => {
                    var itemPSUMounts = item.GetType().GetProperty("PSUMount").GetValue(item) as IEnumerable<object>;
                    if (itemPSUMounts != null)
                    {
                        foreach (var psuMountItem in itemPSUMounts)
                        {
                            var psuMountName = psuMountItem.GetType().GetProperty("Name").GetValue(psuMountItem)?.ToString();
                            if (psuMountName != null && psuMount.Contains(psuMountName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (buttons != null && buttons.Any())
            {
                result = result.Where(item => {
                    var itemButtons = item.GetType().GetProperty("Buttons").GetValue(item) as IEnumerable<object>;
                    if (itemButtons != null)
                    {
                        foreach (var buttonItem in itemButtons)
                        {
                            var buttonName = buttonItem.GetType().GetProperty("Name").GetValue(buttonItem)?.ToString();
                            if (buttonName != null && buttons.Contains(buttonName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (driveBay != null && driveBay.Any())
            {
                result = result.Where(item => {
                    var itemDriveBays = item.GetType().GetProperty("DriveBay").GetValue(item) as IEnumerable<object>;
                    if (itemDriveBays != null)
                    {
                        foreach (var driveBayItem in itemDriveBays)
                        {
                            var driveBayName = driveBayItem.GetType().GetProperty("Name").GetValue(driveBayItem)?.ToString();
                            if (driveBayName != null && driveBay.Contains(driveBayName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false;
                });
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

            if (installedFans != null && installedFans.Any())
            {
                result = result.Where(item => {
                    var itemInstalledFans = item.GetType().GetProperty("InstalledFans").GetValue(item) as IEnumerable<object>;
                    if (itemInstalledFans != null)
                    {
                        foreach (var installedFanItem in itemInstalledFans)
                        {
                            var installedFanName = installedFanItem.GetType().GetProperty("Name").GetValue(installedFanItem)?.ToString();
                            if (installedFanName != null && installedFans.Contains(installedFanName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (fanBays != null && fanBays.Any())
            {
                result = result.Where(item => {
                    var itemFanBays = item.GetType().GetProperty("FanBays").GetValue(item) as IEnumerable<object>;
                    if (itemFanBays != null)
                    {
                        foreach (var fanBayItem in itemFanBays)
                        {
                            var fanBayName = fanBayItem.GetType().GetProperty("Name").GetValue(fanBayItem)?.ToString();
                            if (fanBayName != null && fanBays.Contains(fanBayName))
                            {
                                return true;
                            }
                        }
                    }
                    return false; 
                });
            }
            if (waterCoolingSlots != null && waterCoolingSlots.Any())
            {
                result = result.Where(item => {
                    var itemWaterCoolingSlots = item.GetType().GetProperty("WaterCoolingSlots").GetValue(item) as IEnumerable<object>;
                    if (itemWaterCoolingSlots != null)
                    {
                        foreach (var waterCoolingSlotItem in itemWaterCoolingSlots)
                        {
                            var waterCoolingSlotName = waterCoolingSlotItem.GetType().GetProperty("Name").GetValue(waterCoolingSlotItem)?.ToString();
                            if (waterCoolingSlotName != null && waterCoolingSlots.Contains(waterCoolingSlotName))
                            {
                                return true; 
                            }
                        }
                    }
                    return false; 
                });
            }

            if (minMaxFanCount != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("MaxFanCount").GetValue(item)) >= minMaxFanCount);
            }
            if (maxMaxFanCount != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("MaxFanCount").GetValue(item)) <= maxMaxFanCount);
            }
            if (exactMaxFanCount != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("MaxFanCount").GetValue(item)) == exactMaxFanCount);
            }

            if (minInstalledFanCount != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("InstalledFanCount").GetValue(item)) >= minInstalledFanCount);
            }
            if (maxInstalledFanCount != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("InstalledFanCount").GetValue(item)) <= maxInstalledFanCount);
            }
            if (exactInstalledFanCount != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("InstalledFanCount").GetValue(item)) == exactInstalledFanCount);
            }

            if (minExpansionSlots != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("ExpansionSlots").GetValue(item)) >= minExpansionSlots);
            }
            if (maxExpansionSlots != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("ExpansionSlots").GetValue(item)) <= maxExpansionSlots);
            }
            if (exactExpansionSlots != null)
            {
                result = result.Where(item => Convert.ToInt32(item.GetType().GetProperty("ExpansionSlots").GetValue(item)) == exactExpansionSlots);
            }

            if (minMaxGPULength != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxGPULength").GetValue(item)) >= minMaxGPULength);
            }
            if (maxMaxGPULength != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxGPULength").GetValue(item)) <= maxMaxGPULength);
            }
            if (exactMaxGPULength != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxGPULength").GetValue(item)) == exactMaxGPULength);
            }

            if (minMaxCPUCoolerHeight != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxCPUCoolerHeight").GetValue(item)) >= minMaxCPUCoolerHeight);
            }
            if (maxMaxCPUCoolerHeight != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxCPUCoolerHeight").GetValue(item)) <= maxMaxCPUCoolerHeight);
            }
            if (exactMaxCPUCoolerHeight != null)
            {
                result = result.Where(item => Convert.ToDecimal(item.GetType().GetProperty("MaxCPUCoolerHeight").GetValue(item)) == exactMaxCPUCoolerHeight);
            }

         



            return result;
        }

        [HttpGet("Case/Compability/HDD")]
        public string HDDCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    var drivebay = data["driveBay"].ToObject<List<dynamic>>();


                    foreach (var db in drivebay)
                    {
                        if (db.name.ToString().Contains("2.5\"") && !urlBuilder.ToString().Contains("2.5\""))
                        {
                            urlBuilder.Append($"formFactor=2.5\"&");
                        }
                        if (db.name.ToString().Contains("3.5\"") && !urlBuilder.ToString().Contains("3.5\""))
                        {
                            urlBuilder.Append($"formFactor=3.5\"&");
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


       

        [HttpGet("Case/Compability/PSU")]
        public string CaseCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

                    var psuMounts = data["psuMount"].ToObject<List<dynamic>>();

                    var urlBuilder = new StringBuilder();

                    foreach (var psuMount in psuMounts)
                    {
                        string formattedMount = psuMount.name.ToString().Replace(" ", "%20");
                        urlBuilder.Append($"formFactor={formattedMount}&");
                        if (formattedMount == "ATX" && !urlBuilder.ToString().Contains("ATX%203.0"))
                        {
                            urlBuilder.Append($"formFactor=ATX%203.0&");
                        }
                        if (formattedMount == "ATX%203.0" && !urlBuilder.ToString().Contains("ATX"))
                        {
                            urlBuilder.Append($"formFactor=ATX&");
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

        [HttpGet("Case/Compability/Motherboard")]
        public string MotherboardCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

                    var formFactors = data["formFactor"].ToObject<List<dynamic>>();

                    var urlBuilder = new StringBuilder();

                    foreach (var formFactor in formFactors)
                    {
                        string form = formFactor.name.ToString().Replace(" ", "%20");
                        urlBuilder.Append($"formFactor={form}&");
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

        [HttpGet("Case/Compability/CPUCooler")]
        public string CPUCoolerCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    string item = data.maxCPUCoolerHeight;
                    urlBuilder.Append($"maxHeight={item}&");


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

        [HttpGet("Case/Compability/GPU")]
        public string GPUCompability(string jsonData)
        {
            if (jsonData != null)
            {
                try
                {
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
                    var urlBuilder = new StringBuilder();

                    string item = data.maxGPULength;
                    urlBuilder.Append($"maxLength={item}&");


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

        [HttpGet("Case/Get-By-ID")]
        public IActionResult GetId(int id)
        {
            var result = GetAll();
            return Ok(result);
        }

        [HttpGet("Case/Get-Properties")]
        public IActionResult GetProperties()
        {
            var result = GetProperties<Case>();
            return Ok(result);
        }

        [HttpPost("Case/Add")]
        public IActionResult Add([FromBody] Case newItem)
        {
            if (Add<Case>(newItem)) { return Ok(newItem); }
            return BadRequest("Invalid Case data");
        }

        [HttpDelete("Case/Delete")]
        public IActionResult Delete(int id)
        {
            return Delete<Case>(id);
        }

        [HttpPut("Case/Update")]
        public IActionResult Update(int id, [FromBody] Case newItem)
        {
            return Update(id, newItem, item => item.Id);
        }


    }
}

