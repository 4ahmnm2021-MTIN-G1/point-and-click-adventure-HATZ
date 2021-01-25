using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
   public float numberWithComma;
   public int number;
   public bool trueOrFalse;
   public string somethingWritten;

   public HingeJoint hjVariable;
   public SpriteRenderer srVariable;
   public GameObject goVariable;
   public AudioSource asVariable;

   public void Start()
   {
       hjVariable.massScale = numberWithComma;
       srVariable.sortingOrder = number;
       goVariable.name = somethingWritten;
       asVariable.loop = trueOrFalse;
   }
}
