using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo1 : HerancaInimigoMata
{
   [SerializeField] protected float velocidadeVertical;
    Vector3 posicaoInicial;
    Vector3 posicao;

    private void Start()
    {
        posicaoInicial = transform.position;
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        posicao = posicaoInicial + Vector3.right * Mathf.Sin(Time.time);
        velocidadeVertical -= 14 * Time.deltaTime;

        if (velocidadeVertical < 0)
            velocidadeVertical = 0;

        posicao.y = velocidadeVertical + posicao.y;
        transform.position = posicao;
    }

}
