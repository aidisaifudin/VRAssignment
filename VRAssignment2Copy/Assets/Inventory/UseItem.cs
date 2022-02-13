using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    [HideInInspector]
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    public void Use()
    {
        Debug.Log("Success");
        Inventory.Instance.UseItem(item);
        
    }
}
