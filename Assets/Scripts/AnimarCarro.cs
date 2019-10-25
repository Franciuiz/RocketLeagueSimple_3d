using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarCarro : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool cima = Input.GetKey(KeyCode.W);
        animator.SetBool("Movimentando", cima);

        //bool baixo = Input.GetKey(KeyCode.S);
        //animator.SetBool("Movimentando", baixo);
    }
}
