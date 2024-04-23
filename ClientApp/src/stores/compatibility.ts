import { usePartsStore } from '@/stores/parts'

export async function getCompatibilityFilters(partType: string) {
  const parts = usePartsStore().getSelectedParts
  console.log(JSON.stringify(parts[partType]))

  const partTypeMapping: Record<string, string[]> = {
    psu: ['case'],
    case: ['psu', 'motherboard', 'hdd'],
    hdd: ['case', 'motherboard'],
    gpu: ['motherboard', 'case'],
    cpu: ['motherboard', 'ram', 'cpucooler'],
    ram: ['motherboard', 'cpu'],
    cpucooler: ['case', 'motherboard', 'cpu'],
    motherboard: ['ram', 'cpu', 'gpu', 'case', 'hdd', 'cpucooler']
  }

  const mappings = partTypeMapping[partType] || []
  const responses = []

  for (const mapping of mappings) {
    if (parts[mapping]) {
      const response = await fetch(
        `${process.env.API_URL}${mapping.charAt(0).toUpperCase() + mapping.slice(1)}/Compability/${
          partType.charAt(0).toUpperCase() + partType.slice(1)
        }?jsonData=${JSON.stringify(parts[mapping])}`
      )
      responses.push(await response.text())
    }
  }

  return responses.join('&')
}
