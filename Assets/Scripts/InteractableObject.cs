using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public UI_Manager uiManager;
    public Text dialogFenster;
    public string inspectText;
    public SpriteRenderer sr;
    public Image img;
    public UnityEvent collectEvidence;

    public void OnMouseDown()
    {
        commandMenu.active = true;
        commandMenu.transform.position = transform.position;

        uiManager.activeIO = this;
        // dialogFenster.text = inspectText ;
    }
}
