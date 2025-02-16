using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent OnShoot;
    [SerializeField] private float _fireRate = 0.3f;

    private bool _canShoot = true;
    private bool _shoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _shoot = Input.GetMouseButtonDown(0);

        if (_shoot && _canShoot)
        {
            OnShoot?.Invoke();
            _canShoot = false;
            StartCoroutine(EnableShooting());
        }
    }

    IEnumerator EnableShooting()
    {
        yield return new WaitForSeconds(_fireRate);
        _canShoot = true;
    }
}
