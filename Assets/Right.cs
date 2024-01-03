using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Right : MonoBehaviour
{

    bool ispressed = false;
    public GameObject player;
    public float force = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ispressed)
        {
            player.transform.Translate(force * Time.deltaTime, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
        Debug.Log("zombala");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

}
