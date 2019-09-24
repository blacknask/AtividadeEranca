using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Player : HerancaAnimacao

{
    public float velocidade = 4f;

    void Update()
    {
        dt = Time.deltaTime;
        inputH = Input.GetAxisRaw("Horizontal");
        inputV = Input.GetAxisRaw("Vertical");
        incremento = CalculaPosicao(inputH, inputV, dt);

        transform.position += incremento;

        UpdateAnimation(incremento);

    }

    private Vector3 CalculaPosicao(float h, float v, float deltatime)
    {
        float dirH = h * velocidade * deltatime;
        float dirV = v * velocidade * deltatime;

        return new Vector3(dirH, dirV, 0);
    }

    protected override void UpdateAnimation(Vector3 dir)
    {
        base.UpdateAnimation(dir);
    }
}
