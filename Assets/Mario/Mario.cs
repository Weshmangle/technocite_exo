using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private int _positionXAnimParam = Animator.StringToHash("PositionX");
    [SerializeField] private int _positionYAnimParam = Animator.StringToHash("PositionY");
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat(_positionXAnimParam, Input.GetAxis("Horizontal"));
        _animator.SetFloat(_positionYAnimParam, Input.GetAxis("Vertical"));
        new MeshFilter();
    }
}
