export const base = [
  { key: 'name', label: 'Name' },
  { key: 'price', label: 'Price' },
  { key: 'producer', label: 'Producer' }
]

export const dimensions = [
  { key: 'length', label: 'Length' },
  { key: 'width', label: 'Width' },
  { key: 'height', label: 'Height' }
]

export const caseComputer = [
  { key: 'type', label: 'Type' },
  { key: 'maxGPULength', label: 'Max GPU Length' },
  { key: 'maxCPUCoolerHeight', label: 'Max CPU Cooler Height' },
  { key: 'expansionSlots', label: 'Expansion Slots' },
  { key: 'formFactor', label: 'Motherboard Form Factor' },
  { key: 'psuMount', label: 'PSU Mount' },
  { key: 'buttons', label: 'Buttons' },
  { key: 'driveBay', label: 'Drive Bays' },
  { key: 'maxFanCount', label: 'Max Fans' },
  { key: 'installedFanCount', label: 'Installed Fans Count' },
  { key: 'installedFans', label: 'Installed Fans' },
  //{ key: 'fanBays', label: 'Fan Bays' },
  //{ key: 'waterCoolingSlots', label: 'Water Cooling Slots' },
  { key: 'ports', label: 'Ports' },
  { key: 'sidePanelMaterial', label: 'Side Panel' },
  { key: 'material', label: 'Material' },
  { key: 'color', label: 'Color' }
]

export const caseCooler = [
  { key: 'fanAirflow', label: 'Fan Airflow' },
  { key: 'fanNoiseLevel', label: 'Fan Noise Level' },
  { key: 'fans', label: 'Fans' },
  { key: 'mtbf', label: 'MTBF' },
  { key: 'connector', label: 'Connector' },
  { key: 'fanBearing', label: 'Fan Bearing' },
  { key: 'fanSpeed', label: 'Fan Speed' },
  { key: 'color', label: 'Color' }
]

export const cpuCooler = [
  { key: 'coolingType', label: 'Cooling Type' },
  { key: 'mount', label: 'Mount' },
  { key: 'heatPipes', label: 'Heat Pipes' },
  { key: 'tdp', label: 'TDP' },
  { key: 'material', label: 'Material' },
  { key: 'cpuSocket', label: 'CPU Socket' }
]

export const cpu = [
  { key: 'cores', label: 'Cores' },
  { key: 'threads', label: 'Threads' },
  { key: 'baseClock', label: 'Base Clock' },
  { key: 'boostClock', label: 'Boost Clock' },
  { key: 'unlockedMultiplier', label: 'Unlocked Multiplier' },
  { key: 'wattage', label: 'TDP' },
  { key: 'maxWattage', label: 'MTP' },
  { key: 'maxMemory', label: 'Max Memory' },
  { key: 'cpuSocket', label: 'Socket' },
  { key: 'dataWidth', label: 'Data Width' },
  { key: 'cacheL1', label: 'L1 Cache' },
  { key: 'cacheL2', label: 'L2 Cache' },
  { key: 'cacheL3', label: 'L3 Cache' },
  { key: 'lithography', label: 'Lithography' },
  { key: 'memoryChannel', label: 'Memory Channel' },
  { key: 'microarchitecture', label: 'Microarchitecture' },
  { key: 'internalGPU', label: 'Internal GPU' },
  { key: 'memoryTypes', label: 'Memory Types' },
  { key: 'motherboardChipsetCompatibility', label: 'Chipset Compatibility' }
]

export const gpu = [
  { key: 'wattage', label: 'TDP' },
  { key: 'recommendedPSUWattage', label: 'Recommended PSU Wattage' },
  { key: 'streamProcessors', label: 'Stream Processors' },
  { key: 'maxMonitors', label: 'Max Monitors' },
  { key: 'memoryBandwidth', label: 'Memory Bandwidth' },
  { key: 'memoryFrequency', label: 'Memory Frequency' },
  { key: 'baseClock', label: 'Base Clock' },
  { key: 'boostClock', label: 'Boost Clock' },
  { key: 'chipsetProducer', label: 'Chipset Producer' },
  { key: 'interFace', label: 'Interface' },
  { key: 'memory', label: 'Memory' },
  { key: 'memoryBus', label: 'Memory Bus' },
  { key: 'memoryType', label: 'Memory Type' },
  { key: 'powerConnector', label: 'Power Connector' },
  { key: 'chipset', label: 'Chipset' },
  { key: 'resolution', label: 'Resolution' },
  { key: 'ports', label: 'Ports' }
]

export const hdd = [
  { key: 'capacity', label: 'Capacity' },
  { key: 'interFace', label: 'Interface' },
  { key: 'formFactor', label: 'Form Factor' },
  { key: 'rpm', label: 'RPM' },
  { key: 'cache', label: 'Cache' }
]

export const motherboard = [
  { key: 'memorySlots', label: 'Memory Slots' },
  { key: 'formFactor', label: 'Form Factor' },
  { key: 'cpuSocket', label: 'CPU Socket' },
  { key: 'chipset', label: 'Chipset' },
  { key: 'cpuFamily', label: 'CPU Family' },
  { key: 'maxMemory', label: 'Max Memory' },
  { key: 'memoryChannel', label: 'Memory Channel' },
  { key: 'internalGPUSupport', label: 'iGPU Support' },
  { key: 'memoryConnectorType', label: 'Memory Connector' },
  { key: 'memoryType', label: 'Memory Type' },
  { key: 'internalConnectors', label: 'Internal Connectors' },
  { key: 'externalConnectors', label: 'External Connectors' },
  { key: 'memoryFrequencies', label: 'Memory Frequencies' },
  { key: 'wirelessTechnologies', label: 'Wireless' },
  { key: 'raid', label: 'RAID' }
]

export const psu = [
  { key: 'wattage', label: 'Wattage' },
  { key: 'formFactor', label: 'Form Factor' },
  { key: 'rating', label: 'Rating' },
  { key: 'modular', label: 'Modular' },
  { key: 'pfc', label: 'PFC' },
  { key: 'cooling', label: 'Cooling' },
  { key: 'connectors', label: 'Connectors' },
  { key: 'protectionFeatures', label: 'Protection Features' },
  { key: 'color', label: 'Color' }
]

export const ram = [
  { key: 'modules', label: 'Modules' },
  { key: 'coolingType', label: 'Cooling Type' },
  { key: 'memoryFrequency', label: 'Memory Frequency' },
  { key: 'voltage', label: 'Voltage' },
  { key: 'memory', label: 'Capacity' },
  { key: 'memoryType', label: 'Memory Type' },
  { key: 'connectorType', label: 'Connector Type' },
  { key: 'cycleLatency', label: 'Cycle Latency' },
  { key: 'color', label: 'Color' },
  { key: 'overclocking', label: 'Overclocking' }
]

export const ssd = [
  { key: 'readSpeed', label: 'Read Speed' },
  { key: 'writeSpeed', label: 'Write Speed' },
  { key: 'randomRead', label: 'Random Read' },
  { key: 'randomWrite', label: 'Random Write' },
  { key: 'tbw', label: 'TBW' },
  { key: 'mtbf', label: 'MTBF' },
  { key: 'formFactor', label: 'Form Factor' },
  { key: 'interFace', label: 'Interface' },
  { key: 'capacity', label: 'Capacity' },
  { key: 'cache', label: 'Cache' },
  { key: 'cellType', label: 'Cell Type' },
  { key: 'heatsink', label: 'Heatsink' },
  { key: 'encryption', label: 'Encryption' },
  { key: 'key', label: 'Key' },
  { key: 'color', label: 'Color' }
]

export const fields = {
  base,
  dimensions,
  caseComputer,
  caseCooler,
  cpu,
  gpu,
  hdd,
  motherboard,
  psu,
  ram,
  ssd,
  cpuCooler
}
