using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HinweisManager : MonoBehaviour
{
    public int hinweisGefunden = 0;
    public GameObject button1;


    public void CountUp()
    {
        hinweisGefunden++;
    }

    private void Update()
    {
        if (hinweisGefunden > 7)
        {
            button1.active = true;
        }
    }
}
