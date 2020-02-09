using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastFromGun2 : MonoBehaviour
{

    [SerializeField] private float _currentAmount;
    [SerializeField] private float _speed = 25;
    public bool _zero;
    
    public float _range = 110;

    private void Awake()
    {
        _zero = false;
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(ObjectsManager.Instance._camera.transform.position, ObjectsManager.Instance._camera.transform.forward, out hit, _range))
        {
            AimBar target = hit.collider.transform.GetComponent<AimBar>();

            if (target != null)
            {
                _zero = true;
                _currentAmount += _speed * Time.deltaTime;
                ObjectsManager.Instance._progressBar.GetComponent<Image>().fillAmount = _currentAmount / 100;
            }

            if (ObjectsManager.Instance._progressBar.GetComponent<Image>().fillAmount == 1)
            {
                target.TakeDamage(10);
            }
        }
        else
        {
            _zero = false;
        }
        if(_zero == false && _currentAmount > 0.1f)
        {
            _zero = true;
            _currentAmount -= _speed * Time.deltaTime * 2;
            ObjectsManager.Instance._progressBar.GetComponent<Image>().fillAmount = _currentAmount / 100;
        }

    }

    private void FixedUpdate()
    {
        Debug.Log(_zero);
    }
}