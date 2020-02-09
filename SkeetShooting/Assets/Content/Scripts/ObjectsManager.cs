using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    public static ObjectsManager Instance;

    [SerializeField] public GameObject _camera;
    [SerializeField] public GameObject _progressBar;
    [SerializeField] public ParticleSystem _muzzleflash;
    [SerializeField] public GameObject _launchButton;
    
    
    private void Awake()
    {
        Instance = this;
    }
}
