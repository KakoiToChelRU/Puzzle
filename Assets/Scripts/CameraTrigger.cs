using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{   
    [SerializeField] GameObject _Camera;
    [SerializeField] bool _forwardTriger;
    [SerializeField] int _numRoomTriger;
    [SerializeField] int _lengthRoom;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && _Camera != null)
        {
            if(_forwardTriger && PlayerControl._numRoom == _numRoomTriger)
            {
                PlayerControl._numRoom++;
                _Camera.transform.position = _Camera.transform.position + new Vector3(0,0,_lengthRoom);
            }
            else if (PlayerControl._numRoom == _numRoomTriger)
            {
                PlayerControl._numRoom--;
                _Camera.transform.position = _Camera.transform.position + new Vector3(0,0,0 - _lengthRoom);
            }
        }
    }
}
