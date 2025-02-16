using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5;
    private Transform _myTransform;
    // Start is called before the first frame update
    void Start()
    {
        // store the reference of the GameObjectís transform
        _myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // increment the _myTransform position vector by _moveSpeed and Time.deltaTime
        _myTransform.position += _myTransform.forward * (Time.deltaTime * _moveSpeed);
    }
}
