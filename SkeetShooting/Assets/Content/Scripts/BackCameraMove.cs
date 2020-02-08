using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCameraMove : MonoBehaviour
{
    public Transform _target;
    public float _moveSpeed;
    public float _rotationSpeed;
   
    private Quaternion _startRotation;
    private Vector3 _offset;
    

    private void Awake()
    {
        _offset = transform.position - _target.position;
        _startRotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + _target.rotation * _offset, _moveSpeed * Time.fixedDeltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, _target.rotation * _startRotation, _rotationSpeed * Time.fixedDeltaTime);
        
    }
}
