using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HinweisManager : MonoBehaviour
{
    public int hinweisGefunden = 0;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;


    public void CountUp()
    {
        hinweisGefunden++;
    }

    private void Update()
    {
        if (hinweisGefunden > 7)
        {
            button1.active = true;
            button2.active = true;
            button3.active = true;
            button4.active = true;
            button5.active = true;
        }
    }
}
