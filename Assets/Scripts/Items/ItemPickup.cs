﻿using UnityEngine;

public class ItemPickup : Interactable {

    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name + ".");
        bool pickedUp = Inventory.instance.Add(item);
        if (pickedUp)
        {
            Destroy(gameObject);
        }      

    }
}
