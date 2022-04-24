using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

    Inventory inventory;

    public GameObject InventoryPanel;
    bool ActiveInventory = false;

    public Slot[] slots;
    public Transform slothHolder;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = Inventory.instance;
        slots = slothHolder.GetComponentsInChildren<Slot>();
        inventory.onSlothCountChange += SlotChange;
        inventory.onChangeItem += RedrawSlotUI;
        InventoryPanel.SetActive(ActiveInventory); 
    }

    private void SlotChange(int val)
    {
         for(int i =0; i<slots.Length; i++)
        {
            slots[i].slotnum = i;
            if(i < inventory.SlotCnt)

                slots[i].GetComponent<Button>().interactable = true;

            else
                slots[i].GetComponent<Button>().interactable = false;

        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ActiveInventory = !ActiveInventory;
            InventoryPanel.SetActive(ActiveInventory);
        }
    }

    void RedrawSlotUI()
    {
        for(int i =0; i < slots.Length; i++)
        {
            slots[i].RemoveSlot();
        }
        for(int i = 0; i < inventory.items.Count; i++)
        {
            slots[i].item = inventory.items[i];
            slots[i].UpdateSlotUI();
        }
    }
}
