using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public int value;
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            audioSource.Play();
            CollectCounter.instance.IncreaseCoins(value);
        }
        
    }
}
