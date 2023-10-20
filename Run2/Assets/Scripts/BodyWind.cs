using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyWind : MonoBehaviour
{
    [SerializeField] float forceFactor = 200;

    List<Rigidbody> rgBalls = new List<Rigidbody>();

    Transform magnetP;

    void Start()
    {
        magnetP = GetComponent<Transform>();
        InvokeRepeating("Mirror", 2f, 2f); 
    }

    private void FixedUpdate()
    {
        foreach (Rigidbody rgBall in rgBalls)
        {
            rgBall.AddForce((magnetP.position - rgBall.position) * forceFactor * Time.fixedDeltaTime);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rgBalls.Add(other.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rgBalls.Remove(other.GetComponent<Rigidbody>());
        }
    }

    private void Mirror()
    {
        forceFactor = forceFactor * -1;
    }

}