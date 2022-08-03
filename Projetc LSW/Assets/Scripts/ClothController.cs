using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClothController : MonoBehaviour {

    public Sprite[] sprites;
    public float[] prices;
    public int[] types; // 1 - Shirt / 2 - Pants
    public bool[] sell;
    public static Hashtable clothData = new Hashtable();

    void Start() {
        clothData.Add("Sprite", sprites[0]);
        clothData.Add("Prices", prices[0]);
        clothData.Add("Types", types[0]);
        clothData.Add("Sell", sell[0]);

        Debug.Log(clothData["Prices"]);
    }
}