using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class HerancaInimigoMata : HerancaAnimacao
{
    protected Collider2D Colisao;
    protected virtual void Start()
    {
        Colisao = GetComponent<Collider2D>();
    }

    protected virtual private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
