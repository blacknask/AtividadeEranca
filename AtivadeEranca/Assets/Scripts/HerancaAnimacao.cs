using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class HerancaAnimacao : MonoBehaviour
{
    protected private Animator anim;
    protected private float UltimoX, UltimoY;
    protected private float inputH, inputV;
    protected private float dt;
    protected private Vector3 incremento;
    protected Vector3 posInicial;

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    protected virtual void UpdateAnimation(Vector3 dir)
    {
        if (dir.x == 0f && dir.y == 0f)
        {
            anim.SetFloat("UltimoX", UltimoX);
            anim.SetFloat("UltimoY", UltimoY);
            anim.SetBool("Andando", false);
        }
        else
        {
            UltimoX = dir.x;
            UltimoY = dir.y;
            anim.SetBool("Andando", true);
        }
        anim.SetFloat("DirecaoX", dir.x);
        anim.SetFloat("DirecaoY", dir.y);
    }
}
