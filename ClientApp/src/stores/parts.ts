import { defineStore } from 'pinia'
import { jsPDF } from 'jspdf'

interface Part {
  wattage?: number
  name: string
  price?: number
  fans?: string
  coolingType?: string
  modules?: number
}

interface Build {
  id: string
  name: string
}

export const usePartsStore = defineStore({
  id: 'parts',
  state: () => ({
    selectedParts: localStorage.getItem('selectedParts')
      ? JSON.parse(localStorage.getItem('selectedParts')!)
      : {},
    savedBuilds: [] as { name: string; id: string }[]
  }),
  actions: {
    setSelectedPart(partType: string, part: Part) {
      this.selectedParts = { ...this.selectedParts, [partType]: part }
      localStorage.setItem('selectedParts', JSON.stringify(this.selectedParts))
    },
    setSelectedParts(parts: { [key: string]: Part }) {
      this.selectedParts = parts
      localStorage.setItem('selectedParts', JSON.stringify(this.selectedParts))
    },
    removeSelectedPart(partType: string) {
      const newSelectedParts = { ...this.selectedParts }
      delete newSelectedParts[partType]
      this.selectedParts = newSelectedParts
      localStorage.setItem('selectedParts', JSON.stringify(this.selectedParts))
    },
    clearSelectedParts() {
      this.selectedParts = {}
      localStorage.setItem('selectedParts', JSON.stringify(this.selectedParts))
    },
    async saveBuild(userId: string, name: string) {
      const response = await fetch(`${process.env.API_URL}Build/Add`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          Id: userId,
          Name: name,
          BuildList: this.getSelectedPartsNames
        })
      })

      if (!response.ok) {
        throw new Error('Failed to save build')
      }
    },
    async removeSavedBuild(id: number) {
      const response = await fetch(`${process.env.API_URL}Build/Delete?id=${id}`, {
        method: 'DELETE',
        headers: {
          'Content-Type': 'application/json'
        }
      })

      if (!response.ok) {
        throw new Error('Failed to delete build')
      }

      this.savedBuilds = this.savedBuilds.filter((build: any) => build.id !== id)
    },
    async fetchSavedBuilds(userId: string) {
      const response = await fetch(`${process.env.API_URL}Build/Get?userId=${userId}`, {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json'
        }
      })

      if (!response.ok) {
        throw new Error('Failed to get builds')
      }

      const data = await response.json()
      console.log(data)
      this.savedBuilds = data
    },
    async fetchSavedBuildsCount(userId: string) {
      const response = await fetch(`${process.env.API_URL}Build/GetCount?userId=${userId}`, {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json'
        }
      })

      if (!response.ok) {
        throw new Error('Failed to get builds count')
      }

      const data = await response.json()
      return data as number
    },
    exportBuild(id: number, format: string) {
      const build = this.savedBuilds.find((build: Build) => Number(build.id) === id)
      if (!build) {
        throw new Error('Build not found')
      }

      let dataStr
      let exportFileDefaultName
      let mimeType
      let headers, values, text, doc

      switch (format) {
        case 'json':
          dataStr = JSON.stringify(build)
          exportFileDefaultName = `${build.name}.json`
          mimeType = 'application/json'
          break
        case 'csv':
          headers = Object.keys(build)
            .map((header) => `"${header.replace(/"/g, '""')}"`)
            .join(',')
          values = Object.values(build)
            .map((value) => {
              if (typeof value === 'object' && value !== null) {
                return `"${(value as Part).name.replace(/"/g, '""')}"`
              } else {
                return `"${value.toString().replace(/"/g, '""')}"`
              }
            })
            .join(',')
          dataStr = headers + '\n' + values
          exportFileDefaultName = `${build.name}.csv`
          mimeType = 'text/csv'
          break
        case 'xml':
          dataStr = `<?xml version="1.0" encoding="UTF-8"?>\n<build>\n`
          for (const [key, value] of Object.entries(build)) {
            if (typeof value === 'object' && value !== null) {
              dataStr += `  <${key}>${(value as Part).name}</${key}>\n`
            } else {
              dataStr += `  <${key}>${value}</${key}>\n`
            }
          }
          dataStr += '</build>'
          exportFileDefaultName = `${build.name}.xml`
          mimeType = 'application/xml'
          break
        case 'txt':
          text = ''
          for (const [key, value] of Object.entries(build)) {
            if (typeof value === 'object' && value !== null) {
              text += `${key}: ${(value as Part).name}\n`
            } else {
              text += `${key}: ${value}\n`
            }
          }
          dataStr = text
          exportFileDefaultName = `${build.name}.txt`
          mimeType = 'text/plain'
          break
        case 'pdf':
          doc = new jsPDF()
          text = ''
          for (const [key, value] of Object.entries(build)) {
            if (typeof value === 'object' && value !== null) {
              text += `${key}: ${(value as Part).name}\n`
            } else {
              text += `${key}: ${value}\n`
            }
          }
          doc.text(text, 10, 10)
          doc.save(`${build.name}.pdf`)
          break
        default:
          throw new Error('Unsupported format')
      }

      if (dataStr && exportFileDefaultName && mimeType) {
        const dataUri = `data:${mimeType};charset=utf-8,` + encodeURIComponent(dataStr)

        const linkElement = document.createElement('a')
        linkElement.setAttribute('href', dataUri)
        linkElement.setAttribute('download', exportFileDefaultName)
        linkElement.click()
      }
    }
  },
  getters: {
    getPartName: (state) => (partType: string) => {
      const part = state.selectedParts[partType] as Part
      if (typeof part === 'object' && part !== null) {
        return `${part.name}`
      }
      return ''
    },
    getPsuWattage() {
      const part = this.selectedParts['psu'] as Part
      if (!part) return 0
      return part.wattage || 0
    },
    getTotalPowerRequirement() {
      let wattage = 0
      for (const [partType, currPart] of Object.entries(this.selectedParts)) {
        const part = currPart as Part
        switch (partType) {
          case 'psu':
            break
          case 'motherboard':
            wattage += 60
            break
          case 'cpucooler':
            if (part.coolingType === 'Water') wattage += 10
            wattage += Number(part.fans?.charAt(0)) * 5 || 0
            break
          case 'casecooler':
            wattage += Number(part.fans?.charAt(0)) * 5 || 0
            break
          case 'ram':
            wattage += (part.modules || 0) * 5
            break
          case 'ssd':
            wattage += 3
            break
          case 'hdd':
            wattage += 8
            break
          default:
            wattage += part.wattage || 0
            break
        }
      }
      return wattage * 1.2
    },
    getTotalPrice() {
      let price = 0
      for (const [, part] of Object.entries(this.selectedParts)) {
        if (typeof part === 'object' && part !== null) {
          price += (part as Part).price || 0
        }
      }
      return price
    },
    getSelectedPartsNames(): { [key: string]: string } {
      const names: { [key: string]: string } = {}
      for (const partType of Object.keys(this.selectedParts)) {
        names[partType] = this.getPartName(partType)
      }
      return names
    },
    getSelectedParts(): { [key: string]: Part } {
      return this.selectedParts
    },
    getSavedBuilds(): any[] {
      return this.savedBuilds
    }
  }
})
