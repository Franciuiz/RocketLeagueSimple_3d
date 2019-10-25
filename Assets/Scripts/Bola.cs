using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour
{

    public Text placarValorA;
    public float placarA = 0F;

    public Text placarValorB;
    public float placarB = 0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        placarValorA.text = placarA.ToString();
        placarValorB.text = placarB.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GolA")
        {
            placarB += 1;
        }
         if(other.gameObject.tag == "GolB")
        {
            placarA += 1;
        }
    }
}
