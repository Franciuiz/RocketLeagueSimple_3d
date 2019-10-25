using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    Rigidbody rb;

    public float moveSpeed = 10;
    public float turnSpeed = 15;

    public string eixoHorizontal;
    public string eixoVertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis(eixoHorizontal);
        float v = Input.GetAxis(eixoVertical);

        
        Mover(v);
        Turn(h);

        //MoverFrenteTraz(v);
        //MoverEsquerdaDireita(h);
    }

    void MoverFrenteTraz(float input){
        var vel = rb.velocity;
        vel.x = input * moveSpeed;
        rb.velocity = vel;
    }

    void MoverEsquerdaDireita(float input){
        var vel = rb.velocity;
        vel.z = input * moveSpeed;
        rb.velocity = vel;
    }


    void Mover(float input)
    {
        var vel = rb.velocity;//pega velocidade global
        var rotation = rb.rotation;//pega rotação

        //converte velocidade de global pra local
        var localVelocity = Quaternion.Inverse(rotation) * vel;
        localVelocity.z = input * moveSpeed;//muda o z(frente) local
        localVelocity.x = 0;//remove inercia lateral

        //converte de local pra global
        var globalVelocity = rotation * localVelocity;

        //aplica velocidade global
        rb.velocity = globalVelocity;
    }

    void Turn(float input)
    {
        var vel = rb.angularVelocity;
        vel.y = input * turnSpeed;
        rb.angularVelocity = vel;
    }
}
