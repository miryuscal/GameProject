using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpingSpeed = 10;
    public float movementSpeed = 5f; // Kullan�c�dan al�nan girdi ile x ekseninde hareket h�z�

    void Start()
    {
        transform.rotation = Quaternion.Euler(-90, 0, 174);
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Kullan�c�dan al�nan girdi ile x ekseninde hareket et
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0, 0);
        rb.velocity = new Vector3(movement.x * movementSpeed, rb.velocity.y, 0);

        // Yatay ekseninde hareket i�in bir giri� tu�u tan�mlay�n, mesela "Horizontal" (sa�/sol ok tu�lar�)
        // Raw input almak istiyorsan�z Input.GetAxisRaw("Horizontal") kullanabilirsiniz.

        // Di�er gerekli i�lemleri buraya ekleyebilirsiniz.
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
