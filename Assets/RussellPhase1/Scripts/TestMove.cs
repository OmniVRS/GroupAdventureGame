using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * horizontalInput * moveSpeed * Time.deltaTime);
        transform.Translate(Vector2.up * verticalInput * moveSpeed * Time.deltaTime);
    }
}
