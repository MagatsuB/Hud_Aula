using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ControlMenuGame _controlMenuGame;
    [SerializeField] int _quantidadeVida;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hit")
        {
            _quantidadeVida--;
            _controlMenuGame.CheckIconVida(_quantidadeVida);
        }


    }
}
