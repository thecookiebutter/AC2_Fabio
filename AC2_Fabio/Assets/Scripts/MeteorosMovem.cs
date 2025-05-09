using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direcao { direita, cima, baixo, esqueda }
public class MeteorosMovem : MonoBehaviour
{

    public Direcao direcaometeoro;
    public float speed;


    private void Start()
    {

    }

    private void Update()
    {
        Movimentacao(direcaometeoro);
    }

    public void Movimentacao(Direcao direcao)
    {
        switch (direcao)
        {
            case Direcao.direita:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;

            case Direcao.cima:
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                break;
            case Direcao.baixo:
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                break;
            case Direcao.esqueda:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
        }

    }


}
