using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class InimigoSegue : HerancaAnimacao
{
    protected float velocidade;
    protected private Transform target;
    protected void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, velocidade * Time.deltaTime);
    }

   
}
