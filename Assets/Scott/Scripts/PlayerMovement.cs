using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float moveSpeed;
    public GameObject child;

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

        child.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, (-0.2f * horizontalInput), 1);
    }
}
