using System.Linq.Expressions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magier : MonoBehaviour
{
    public string NameOfCharacter;
    public int AgeOfCharacter;
    public float HeightOfCharacter;
    public bool IsBad;

    public Rigidbody rb;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {

    NameOfCharacter = "Manifesto";
    AgeOfCharacter = 102;
    HeightOfCharacter = 1.72f;
    IsBad = true;

    rb.useGravity = false;
    rb.mass = 80;
    
    txt.text = "Wilfried Gruber";
    txt.fontSize = 23;

    }
}
