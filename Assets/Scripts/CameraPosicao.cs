using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosicao : MonoBehaviour
{
    public Transform target;

    public float velocidade = 25;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var newPos = Vector3.MoveTowards(this.transform.position, target.position, velocidade * Time.deltaTime);
        
        this.transform.position = newPos;
    }
}
