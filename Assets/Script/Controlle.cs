using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlle : MonoBehaviour
{
    [SerializeField] GameObject _obj;
    [SerializeField] GameObject[] _pos;
    [SerializeField] float _tamInim;

    private void Start()
    {
        _tamInim = _obj.transform.localScale.x;
        StartCoroutine(TimeMove());
    }

    IEnumerator TimeMove()
    {
        _obj.transform.DOMove(_pos[1].transform.position, 1);
        _obj.transform.DOLocalJump(_pos[0].transform.position, 20, 4, 2, false);
        _obj.transform.DOShakeScale(2, 10, 6, 8, false, ShakeRandomnessMode.Full);
        yield return new WaitForSeconds(2.5f);
        _obj.transform.DOScale(_tamInim+35, 0.5f);
        yield return new WaitForSeconds(0.25f);
        _obj.transform.DOScale(_tamInim, 0.5f);
    }
}
