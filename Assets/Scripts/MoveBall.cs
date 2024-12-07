using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float forceFly;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fly();
        }
    }

    private void Fly()
    {
        _rigidbody2D.velocity = Vector2.up * forceFly;
        /*_rigidbody2D.AddForce(new Vector2(1,0), ForceMode2D.Force);*/
    }

    

    private void OnDestroy()
    {
        Debug.Log("MoveBall OnDestroy");
        
    }
}
