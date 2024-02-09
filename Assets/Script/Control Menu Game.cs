using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuGame : MonoBehaviour
{
    [SerializeField] Transform[] _iconVida;
    [SerializeField] Transform _TelaGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CheckIconVida(int vida)
    {
        if (vida == 0)
        {
            _iconVida[0].DOScale(0, 0.5f);
            _TelaGameOver.DOScale(0.15f, 0.5f);
            //chamar tela "GAME-OVER"
        }
        else if (vida == 1)
        {
            _iconVida[1].DOScale(0, 0.5f);
        }
        else if (vida == 2)
        {
            _iconVida[2].DOScale(0, 0.5f);
        }
        else if (vida == 3)
        {
            _iconVida[3].DOScale(0, 0.5f);
        }
        else if (vida == 4)
        {
            _iconVida[4].DOScale(0, 0.5f);
        }
        else if (vida == 5)
        {
            _iconVida[5].DOScale(0, 0.5f);
        }
    }
}
