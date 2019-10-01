using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    [SerializeField] float VelocidadeProjetil;
    Vector3 Alvo;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Alvo, VelocidadeProjetil * Time.deltaTime);
    }
    public void setTarget(Vector3 target)
    {
        this.Alvo = (target - transform.position) * 100f;
    }

    private void OnBecameVisible()
    {
        //Destroy(gameObject);
    }
}
