import { expect, it, describe } from 'vitest'
import { createPinia } from 'pinia'
import { usePartsStore } from '@/stores/parts'

describe('Parts Store', () => {
  it('should set and remove a selected part', () => {
    // Create a new Pinia instance
    const pinia = createPinia()

    // Use the Pinia instance to access the store
    const store = usePartsStore(pinia)
    const cpu = { name: 'testcpu', wattage: 100, price: 50.5 }
    const gpu = { name: 'testgpu', wattage: 200, price: 100.5 }

    // Test setSelectedPart
    store.setSelectedPart('cpu', cpu)
    store.setSelectedPart('gpu', gpu)
    expect(store.selectedParts['cpu']).toEqual(cpu)
    expect(store.selectedParts['gpu']).toEqual(gpu)

    // Test getPartName
    expect(store.getPartName('cpu')).toBe('testcpu')
    expect(store.getPartName('gpu')).toBe('testgpu')

    // Test totalPrice
    expect(store.getTotalPrice).toBe(151)

    // Test totalPowerRequirement
    expect(store.getTotalPowerRequirement).toBe(300 * 1.2)

    // Test removeSelectedPart
    store.removeSelectedPart('cpu')
    expect(store.selectedParts['cpu']).toBeUndefined()
    expect(store.selectedParts['gpu']).toEqual(gpu)
    store.removeSelectedPart('gpu')
    expect(store.selectedParts['gpu']).toBeUndefined()
  })
})
