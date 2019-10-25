using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float tempo = 10;
    
    void Start()
    {
        Destroy(this.gameObject, tempo);
    }
    
}
