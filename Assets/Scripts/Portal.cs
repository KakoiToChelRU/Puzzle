using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject _portal;
    [SerializeField] int _button;
    void Update()
    {   
        if(_button <= Door._openDoor) _portal.SetActive(true);
        else _portal.SetActive(false);
    }
}
