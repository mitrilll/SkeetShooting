using System;
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
    
    

    public void Launch()
    {

            int spawn = Random.Range(0, _spawnPoints.Length);
            var newTarelka = Instantiate(_tarelkaObject, _spawnPoints[spawn].transform.position, Quaternion.identity);
            newTarelka.transform.parent = _spawnPoints[spawn].transform;
            
            Destroy(newTarelka, 5f);
            ObjectsManager.Instance._launchButton.SetActive(false);
    }

}
