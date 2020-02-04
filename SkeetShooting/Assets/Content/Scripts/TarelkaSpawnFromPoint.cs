﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TarelkaSpawnFromPoint : MonoBehaviour
{
    [SerializeField]
    public GameObject[] _spawnPoints;
    [SerializeField] 
    private GameObject _tarelkaObject = null;

    public int _startBoost = 0;

    public void Shoot()
    {

            int spawn = Random.Range(0, _spawnPoints.Length);
            var newTarelka = Instantiate(_tarelkaObject, _spawnPoints[spawn].transform.position, Quaternion.identity);
            newTarelka.transform.parent = _spawnPoints[spawn].transform;


        
    }
}