using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBar : MonoBehaviour
{
    public float _health = 1;
    
    
    public void TakeDamage(float amount)
    {
        _health -= amount;
        if (_health <= 0f)
        {
            ObjectsManager.Instance._muzzleflash.Play();
            Destroy(gameObject);
            ObjectsManager.Instance._launchButton.SetActive(true);
        }
    }

    private void OnDisable()
    {
        ObjectsManager.Instance._launchButton.SetActive(true);
        ObjectsManager.Instance._muzzleflash.Play();
    }
}
