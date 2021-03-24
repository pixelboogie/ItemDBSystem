using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDatabase = new List<Item>();

    public void AddItem(int itemID, MyPlayer player)
    {
        // check if item matches something in our db
        foreach(var item in itemDatabase)
        {
            // check for match
            if(item.id == itemID)
            {
                Debug.Log("Add item");
                // check for available inventory slots would be added here
                player.inventory[0] = item;
                return;
            }
        }
    }

    public void RemoveItem(int itemID, MyPlayer player)
    {
         foreach(var item in itemDatabase)
         {
             if(item.id == itemID)
             {
                 player.inventory[0] = null;
                 Debug.Log("Remove item");
             }
         }
    }
}


