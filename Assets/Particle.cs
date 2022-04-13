using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{

    [SerializeField] private Vector3 velocity;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Vector3 slow;
    
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
