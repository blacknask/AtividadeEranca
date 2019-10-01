using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Inimigo2 : HerancaAnimacao
{
    [SerializeField]  float Velocidade;
    [SerializeField]  Transform[] posicao;
    [SerializeField]  float TempoEspera;

    int Randomica;
    float Tempo;

    protected void Start()
    {
        Randomica = Random.Range(0, posicao.Length);
        Tempo = TempoEspera;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, posicao[Randomica].position, Velocidade * Time.deltaTime);

        float _dist = Vector2.Distance(transform.position, posicao[Randomica].position);

        if (_dist <= 0.2f)

            if (Tempo <= 0)
            {
                Randomica = Random.Range(0, posicao.Length);
                Tempo = TempoEspera;
            }
            else
            {
                Tempo -= Time.deltaTime;
            }
    }
}
