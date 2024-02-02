using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hud_Controller : MonoBehaviour
{
    [SerializeField] List<Menu_Control> _menucontrol;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _menucontrol.Count; i++)
        {
            _menucontrol[i].transform.localScale = Vector3.zero;
            _menucontrol[i].gameObject.SetActive(false);
        }

        _menucontrol[0].gameObject.SetActive(true);
        _menucontrol[0].ItensOFF();
        _menucontrol[0].transform.DOScale(1, .25f);
        _menucontrol[0].ChamarMenu();

    }


    public void ChamarMenuControl(int value)
    {
        for (int i = 0; i < _menucontrol.Count; i++)
        {
            _menucontrol[i].transform.localScale = Vector3.zero;
            _menucontrol[i].ItensOFF();
            _menucontrol[i].gameObject.SetActive(false);
        }

        _menucontrol[value].gameObject.SetActive(true);
        _menucontrol[value].transform.DOScale(1, .25f);
        _menucontrol[value].ChamarMenu();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
