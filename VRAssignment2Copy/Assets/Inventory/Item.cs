using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item: MonoBehaviour
{
    public enum ItemType
    {
        ScrewDriver,
        DuctTape,
        PenKnife,
        Remote,
        Battery,
        Key
    }

    public int numberOfUse = 1;
    public ItemType itemType;

    [HideInInspector]
    public GameObject UI_Item;

}
