using System.Runtime.Serialization;
using System.Reflection;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Image img;
    public InteractableObject io;
    public Text txt;

    public void Update()
    {
        

       // if (img.sprite == io.sprite)
        {
            txt.text = "Hat geklappt";
        }
    }
}
