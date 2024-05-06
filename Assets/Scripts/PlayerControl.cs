using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{   
    [SerializeField] public float speed;
    private Rigidbody rb;
    public static int _numRoom = 1;
    public bool isGrounded;
    void OnCollisionEnter()
    {
        isGrounded = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector3(0, 2000, 0));
        }
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));    
        rb.AddForce(moveInput * speed * Time.deltaTime);
    }
}
