using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class InimigoSegue : HerancaInimigoMata
{
    public float velocidade;
    private Transform target;

    protected override void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, velocidade * Time.deltaTime);
    }

   
}
