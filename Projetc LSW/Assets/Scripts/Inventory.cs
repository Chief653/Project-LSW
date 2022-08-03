using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public GameObject inventoryObject;

    void Start()
    {
        
    }

    void Update() {
        
    }

    public void ShowInventory(bool open) {
        if(open) {
            inventoryObject.SetActive(false);
        }
        else {
            inventoryObject.SetActive(true);
        }
    }
}