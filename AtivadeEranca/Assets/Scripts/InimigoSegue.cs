using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class InimigoSegue : HerancaInimigoMata
{
[SerializeField] float velocidadeInimigo;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, velocidadeInimigo * Time.deltaTime);
    }
}


















    
    