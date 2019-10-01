using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class HerancaInimigoMata : HerancaAnimacao
{
    [SerializeField] protected GameObject firePrefab;
    [SerializeField] protected float VelocidadeProjetil;


    protected void Fire()
    {
        GameObject fire = (GameObject)Instantiate(firePrefab, transform.position, Quaternion.identity);
        fire.GetComponent<Tiro>().setTarget(GameController.instancia.getPlayer().position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Fire();
        }
    }
}
