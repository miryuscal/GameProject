using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpingSpeed = 10;
    public float movementSpeed = 5f; // Kullanýcýdan alýnan girdi ile x ekseninde hareket hýzý

    void Start()
    {
        transform.rotation = Quaternion.Euler(-90, 0, 174);
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Kullanýcýdan alýnan girdi ile x ekseninde hareket et
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0, 0);
        rb.velocity = new Vector3(movement.x * movementSpeed, rb.velocity.y, 0);

        // Yatay ekseninde hareket için bir giriþ tuþu tanýmlayýn, mesela "Horizontal" (sað/sol ok tuþlarý)
        // Raw input almak istiyorsanýz Input.GetAxisRaw("Horizontal") kullanabilirsiniz.

        // Diðer gerekli iþlemleri buraya ekleyebilirsiniz.
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Do something else here");
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector3(0, jumpingSpeed, 0);
    }
}
