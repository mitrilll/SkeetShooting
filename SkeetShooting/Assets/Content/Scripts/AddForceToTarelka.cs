using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToTarelka : MonoBehaviour
{
    
    public int _startBoost = 85;
    private void Update()
    {
        transform.rotation = transform.parent.rotation;
        var rb = transform.GetComponent<Rigidbody>();
        rb.AddForce(transform.up * _startBoost);
        if (_startBoost > 0)
        {
            _startBoost = _startBoost - 3;
        }
    }
}
