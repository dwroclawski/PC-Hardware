export const base = [
  { name: 'name', label: 'Name', type: 'text', visible: true },
  { name: 'minPrice', label: 'Min Price', type: 'number', visible: true },
  { name: 'maxPrice', label: 'Max Price', type: 'number', visible: true },
  { name: 'producer', label: 'Producer', type: 'enum', visible: true }
]

export const dimensions = [
  { name: 'minLength', label: 'Min Length', type: 'number', visible: false },
  { name: 'maxLength', label: 'Max Length', type: 'number', visible: false },
  { name: 'minWidth', label: 'Min Width', type: 'number', visible: false },
  { name: 'maxWidth', label: 'Max Width', type: 'number', visible: false },
  { name: 'minHeight', label: 'Min Height', type: 'number', visible: false },
  { name: 'maxHeight', label: 'Max Height', type: 'number', visible: false }
]

export const fans = [
  { name: 'fans', label: 'Fans', type: 'enum', visible: true },
  { name: 'fanSpeed', label: 'Fan Speed', type: 'enum', visible: true },
  { name: 'connector', label: 'Connector', type: 'enum', visible: true },
  { name: 'fanBearing', label: 'Fan Bearing', type: 'enum', visible: false },
  { name: 'mtbf', label: 'MTBF', type: 'enum', visible: false },
  { name: 'minFanAirflow', label: 'Min Fan Airflow', type: 'number', visible: false },
  { name: 'maxFanAirflow', label: 'Max Fan Airflow', type: 'number', visible: false },
  { name: 'minFanNoiseLevel', label: 'Min Fan Noise Level', type: 'number', visible: false },
  { name: 'maxFanNoiseLevel', label: 'Max Fan Noise Level', type: 'number', visible: false }
]

export const storage = [
  { name: 'capacity', label: 'Capacity', type: 'enum', visible: true },
  { name: 'interFace', label: 'Interface', type: 'enum', visible: true },
  { name: 'formFactor', label: 'Form Factor', type: 'enum', visible: true },
  { name: 'cache', label: 'Cache', type: 'enum', visible: true }
]

export const caseComputer = [
  ...base,
  { name: 'type', label: 'Type', type: 'enum', visible: true },
  { name: 'formFactor', label: 'Form Factor', type: 'enum', visible: true },
  { name: 'psuMount', label: 'PSU Mount', type: 'enum', visible: true },
  { name: 'material', label: 'Material', type: 'enum', visible: true },
  { name: 'sidePanelMaterial', label: 'Side Panel Material', type: 'enum', visible: true },
  { name: 'color', label: 'Color', type: 'enum', visible: true },
  { name: 'buttons', label: 'Buttons', type: 'enum', visible: true },
  { name: 'driveBay', label: 'Drive Bay', type: 'enum', visible: true },
  { name: 'installedFans', label: 'Installed Fans', type: 'enum', visible: true },
  { name: 'ports', label: 'Ports', type: 'enum', visible: true },
  { name: 'fanBays', label: 'Fan Bays', type: 'enum', visible: false },
  { name: 'waterCoolingSlots', label: 'Water Cooling Slots', type: 'enum', visible: false },
  { name: 'minMaxFanCount', label: 'Min Max Fan Count', type: 'number', visible: false },
  { name: 'maxMaxFanCount', label: 'Max Max Fan Count', type: 'number', visible: false },
  {
    name: 'minInstalledFanCount',
    label: 'Min Installed Fan Count',
    type: 'number',
    visible: false
  },
  {
    name: 'maxInstalledFanCount',
    label: 'Max Installed Fan Count',
    type: 'number',
    visible: false
  },
  { name: 'minExpansionSlots', label: 'Min Expansion Slots', type: 'number', visible: false },
  { name: 'maxExpansionSlots', label: 'Max Expansion Slots', type: 'number', visible: false },
  { name: 'minMaxGPULength', label: 'Min Max GPU Length', type: 'number', visible: false },
  { name: 'maxMaxGPULength', label: 'Max Max GPU Length', type: 'number', visible: false },
  {
    name: 'minMaxCPUCoolerHeight',
    label: 'Min Max CPU Cooler Height',
    type: 'number',
    visible: false
  },
  {
    name: 'maxMaxCPUCoolerHeight',
    label: 'Max Max CPU Cooler Height',
    type: 'number',
    visible: false
  },
  ...dimensions
]

export const cpu = [
  ...base,
  { name: 'cpuSocket', label: 'Socket', type: 'enum', visible: true },
  {
    name: 'motherboardChipsetCompatibility',
    label: 'Chipset Compatibility',
    type: 'enum',
    visible: true
  },
  { name: 'cores', label: 'Cores', type: 'enum', visible: true },
  { name: 'threads', label: 'Threads', type: 'enum', visible: true },
  { name: 'minBaseClock', label: 'Min Base Clock', type: 'number', visible: true },
  { name: 'maxBaseClock', label: 'Max Base Clock', type: 'number', visible: true },
  { name: 'minBoostClock', label: 'Min Boost Clock', type: 'number', visible: true },
  { name: 'maxBoostClock', label: 'Max Boost Clock', type: 'number', visible: true },
  { name: 'unlockedMultiplier', label: 'Unlocked Multiplier', type: 'enum', visible: true },
  { name: 'minWattage', label: 'Min TDP', type: 'number', visible: true },
  { name: 'maxWattage', label: 'Max TDP', type: 'number', visible: true },
  { name: 'minMaxWattage', label: 'Min MTP', type: 'number', visible: true },
  { name: 'maxMaxWattage', label: 'Max MTP', type: 'number', visible: true },
  { name: 'cacheL1', label: 'L1 Cache', type: 'enum', visible: true },
  { name: 'cacheL2', label: 'L2 Cache', type: 'enum', visible: true },
  { name: 'cacheL3', label: 'L3 Cache', type: 'enum', visible: true },
  { name: 'internalGPU', label: 'Internal GPU', type: 'enum', visible: true },
  { name: 'maxMemory', label: 'Max Memory', type: 'enum', visible: true },
  { name: 'memoryChannel', label: 'Memory Channel', type: 'enum', visible: true },
  { name: 'memoryTypes', label: 'Memory Types', type: 'enum', visible: true },
  { name: 'microarchitecture', label: 'Microarchitecture', type: 'enum', visible: false },
  { name: 'lithography', label: 'Lithography', type: 'enum', visible: false },
  { name: 'dataWidth', label: 'Data Width', type: 'enum', visible: false }
]

export const gpu = [
  ...base,
  { name: 'chipsetProducer', label: 'Chipset Producer', type: 'enum', visible: true },
  { name: 'chipset', label: 'Chipset', type: 'enum', visible: true },
  { name: 'memory', label: 'Memory', type: 'enum', visible: true },
  { name: 'memoryType', label: 'Memory Type', type: 'enum', visible: true },
  { name: 'memoryBus', label: 'Memory Bus', type: 'enum', visible: false },
  { name: 'minMemoryBandwidth', label: 'Min Memory Bandwidth', type: 'number', visible: false },
  { name: 'maxMemoryBandwidth', label: 'Max Memory Bandwidth', type: 'number', visible: false },
  { name: 'minMemoryFrequency', label: 'Min Memory Frequency', type: 'number', visible: false },
  { name: 'maxMemoryFrequency', label: 'Max Memory Frequency', type: 'number', visible: false },
  { name: 'interFace', label: 'Interface', type: 'enum', visible: true },
  { name: 'ports', label: 'Ports', type: 'enum', visible: true },
  { name: 'minBaseClock', label: 'Min Base Clock', type: 'number', visible: false },
  { name: 'maxBaseClock', label: 'Max Base Clock', type: 'number', visible: false },
  { name: 'minBoostClock', label: 'Min Boost Clock', type: 'number', visible: false },
  { name: 'maxBoostClock', label: 'Max Boost Clock', type: 'number', visible: false },
  { name: 'powerConnector', label: 'Power Connector', type: 'enum', visible: false },
  { name: 'resolution', label: 'Resolution', type: 'enum', visible: false },
  {
    name: 'minRecommendedPSUWattage',
    label: 'Min Recommended PSU Wattage',
    type: 'number',
    visible: false
  },
  {
    name: 'maxRecommendedPSUWattage',
    label: 'Max Recommended PSU Wattage',
    type: 'number',
    visible: false
  },
  { name: 'minWattage', label: 'Min TDP', type: 'number', visible: false },
  { name: 'maxWattage', label: 'Max TDP', type: 'number', visible: false },
  { name: 'minStreamProcessors', label: 'Min Stream Processors', type: 'number', visible: false },
  { name: 'maxStreamProcessors', label: 'Max Stream Processors', type: 'number', visible: false },
  { name: 'maxMonitors', label: 'Max Monitors', type: 'enum', visible: false },
  { name: 'minLength', label: 'Min Length', type: 'number', visible: false },
  { name: 'maxLength', label: 'Max Length', type: 'number', visible: true },
  { name: 'minWidth', label: 'Min Width', type: 'number', visible: false },
  { name: 'maxWidth', label: 'Max Width', type: 'number', visible: false },
  { name: 'minHeight', label: 'Min Height', type: 'number', visible: false },
  { name: 'maxHeight', label: 'Max Height', type: 'number', visible: false }
]

export const ram = [
  ...base,
  { name: 'memory', label: 'Capacity', type: 'enum', visible: true },
  { name: 'modules', label: 'Modules', type: 'enum', visible: true },
  { name: 'memoryType', label: 'Memory Type', type: 'enum', visible: true },
  { name: 'memoryFrequency', label: 'Memory Frequency', type: 'enum', visible: true },
  { name: 'cycleLatency', label: 'Cycle Latency', type: 'enum', visible: true },
  { name: 'connectorType', label: 'Connector Type', type: 'enum', visible: true },
  { name: 'coolingType', label: 'Cooling Type', type: 'enum', visible: true },
  { name: 'voltage', label: 'Voltage', type: 'enum', visible: true },
  { name: 'overclocking', label: 'Overclocking', type: 'enum', visible: true },
  { name: 'color', label: 'Color', type: 'enum', visible: false }
]

export const motherboard = [
  ...base,
  { name: 'cpuFamily', label: 'CPU Family', type: 'enum', visible: true },
  { name: 'cpuSocket', label: 'CPU Socket', type: 'enum', visible: true },
  { name: 'formFactor', label: 'Form Factor', type: 'enum', visible: true },
  { name: 'memoryType', label: 'Memory Type', type: 'enum', visible: true },
  { name: 'maxMemory', label: 'Max Memory', type: 'enum', visible: true },
  { name: 'memoryConnectorType', label: 'Memory Connector', type: 'enum', visible: true },
  { name: 'memoryChannel', label: 'Memory Channel', type: 'enum', visible: true },
  { name: 'memorySlots', label: 'Memory Slots', type: 'enum', visible: true },
  { name: 'memoryFrequencies', label: 'Memory Frequencies', type: 'enum', visible: true },
  { name: 'chipset', label: 'Chipset', type: 'enum', visible: true },
  { name: 'wirelessTechnologies', label: 'Wireless Technologies', type: 'enum', visible: false },
  { name: 'externalConnectors', label: 'External Connectors', type: 'enum', visible: false },
  { name: 'internalConnectors', label: 'Internal Connectors', type: 'enum', visible: false },
  { name: 'internalGPUSupport', label: 'iGPU Support', type: 'enum', visible: false },
  { name: 'raid', label: 'RAID Support', type: 'enum', visible: false }
]

export const psu = [
  ...base,
  { name: 'minWattage', label: 'Min Wattage', type: 'number', visible: true },
  { name: 'maxWattage', label: 'Max Wattage', type: 'number', visible: true },
  { name: 'formFactor', label: 'Form Factor', type: 'enum', visible: true },
  { name: 'rating', label: 'Rating', type: 'enum', visible: true },
  { name: 'modular', label: 'Modular', type: 'enum', visible: true },
  { name: 'cooling', label: 'Cooling', type: 'enum', visible: true },
  { name: 'connectors', label: 'Connectors', type: 'enum', visible: true },
  { name: 'pfc', label: 'PFC', type: 'enum', visible: false },
  { name: 'protectionFeatures', label: 'Protection Features', type: 'enum', visible: false },
  { name: 'color', label: 'Color', type: 'enum', visible: false },
  ...dimensions
]

export const hdd = [
  ...base,
  ...storage,
  { name: 'rpm', label: 'RPM', type: 'enum', visible: true },
  ...dimensions
]

export const ssd = [
  ...base,
  ...storage,
  { name: 'minReadSpeed', label: 'Min Read Speed', type: 'number', visible: true },
  { name: 'maxReadSpeed', label: 'Max Read Speed', type: 'number', visible: true },
  { name: 'minWriteSpeed', label: 'Min Write Speed', type: 'number', visible: true },
  { name: 'maxWriteSpeed', label: 'Max Write Speed', type: 'number', visible: true },
  { name: 'minRandomRead', label: 'Min Random Read', type: 'number', visible: true },
  { name: 'maxRandomRead', label: 'Max Random Read', type: 'number', visible: true },
  { name: 'minRandomWrite', label: 'Min Random Write', type: 'number', visible: true },
  { name: 'maxRandomWrite', label: 'Max Random Write', type: 'number', visible: true },
  { name: 'minTBW', label: 'Min TBW', type: 'number', visible: true },
  { name: 'maxTBW', label: 'Max TBW', type: 'number', visible: true },
  { name: 'heatsink', label: 'Heatsink', type: 'enum', visible: true },
  { name: 'mtbf', label: 'MTBF', type: 'enum', visible: false },
  { name: 'cellType', label: 'Cell Type', type: 'enum', visible: false },
  { name: 'encryption', label: 'Encryption', type: 'enum', visible: false },
  { name: 'key', label: 'Key', type: 'enum', visible: false },
  { name: 'color', label: 'Color', type: 'enum', visible: false },
  ...dimensions
]

export const caseCooler = [
  ...base,
  ...fans,
  { name: 'color', label: 'Color', type: 'enum', visible: true },
  ...dimensions
]

export const cpuCooler = [
  ...base,
  { name: 'coolingType', label: 'Cooling Type', type: 'enum', visible: true },
  { name: 'tdp', label: 'TDP', type: 'enum', visible: true },
  { name: 'cpuSocket', label: 'CPU Socket', type: 'enum', visible: true },
  ...fans,
  { name: 'mount', label: 'Mount', type: 'enum', visible: true },
  { name: 'heatPipes', label: 'Heat Pipes', type: 'enum', visible: true },
  { name: 'material', label: 'Material', type: 'enum', visible: true },
  { name: 'color', label: 'Color', type: 'enum', visible: false },
  { name: 'minLength', label: 'Min Length', type: 'number', visible: false },
  { name: 'maxLength', label: 'Max Length', type: 'number', visible: false },
  { name: 'minWidth', label: 'Min Width', type: 'number', visible: false },
  { name: 'maxWidth', label: 'Max Width', type: 'number', visible: false },
  { name: 'minHeight', label: 'Min Height', type: 'number', visible: false },
  { name: 'maxHeight', label: 'Max Height', type: 'number', visible: true }
]

export const filters = {
  caseComputer,
  cpu,
  gpu,
  ram,
  motherboard,
  psu,
  hdd,
  ssd,
  caseCooler,
  cpuCooler
}
