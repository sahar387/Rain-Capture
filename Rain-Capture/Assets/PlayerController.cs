using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;

    private float _horizontalMovement;
    private float speed = 5f;



    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");

        if(_horizontalMovement != 0)
        {
            _rb.AddForce(new Vector2(_horizontalMovement * speed, 0f));
        }
    }
}
