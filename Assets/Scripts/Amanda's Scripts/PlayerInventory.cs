
/*
public class PlayerInventory : MonoBehaviour
{
    public int inventorySize = 10; // Number of slots in the inventory
    public GameObject inventorySlotPrefab; // Prefab for the inventory slot UI element
    public Transform inventoryUIParent; // Parent transform for the inventory UI slots
    public Text itemInfoText; // UI Text element to display item information
        
    private List<Item> items = new List<Item>(); // List to store items in the inventory

    private void Start()
    {
        // Initialize inventory UI
        for (int i = 0; i < inventorySize; i++)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, inventoryUIParent);
            slot.GetComponent<InventorySlot>().SetSlotIndex(i);
        }
    }

    // Add an item to the inventory
    public void AddItem(Item newItem)
    {
        if (items.Count < inventorySize)
        {
            items.Add(newItem);
            UpdateInventoryUI();
        }
        else
        {
            Debug.LogWarning("Inventory is full!");
        }
    }

    // Remove an item from the inventory
    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
            UpdateInventoryUI();
        }
    }

    // Update the inventory UI to reflect the current items
    private void UpdateInventoryUI()
    {
        InventorySlot[] slots = inventoryUIParent.GetComponentsInChildren<InventorySlot>();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < items.Count)
            {
                slots[i].SetItem(items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    // Display item information
    public void DisplayItemInfo(string info)
    {
        itemInfoText.text = info;
    }
}

public class InventorySlot : MonoBehaviour
{
    public Image iconImage; // UI Image element to display the item icon

    private int slotIndex; // Index of this slot in the inventory

    public void SetSlotIndex(int index)
    {
        slotIndex = index;
    }

    public void SetItem(Item item)
    {
        iconImage.sprite = item.icon;
        iconImage.enabled = true;
    }

    public void ClearSlot()
    {
        iconImage.sprite = null;
        iconImage.enabled = false;
    }

    public void OnSlotClick()
    {
        // Implement actions when the slot is clicked
        // For example, you could display item information
        // or trigger an item use/interact action.
        // You can use the slotIndex to identify the clicked slot.
    }
}

[System.Serializable]
public class Item
{
    public string itemName;
    public Sprite icon;
    // Add more properties as needed
}*/
       