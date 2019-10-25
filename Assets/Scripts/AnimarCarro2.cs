using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarCarro2 : MonoBehaviour
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
        bool cima = Input.GetKey(KeyCode.UpArrow);
        animator.SetBool("Movimentando", cima);

        //bool baixo = Input.GetKey(KeyCode.DownArrow);
        //animator.SetBool("Movimentando", baixo);
    }
}
