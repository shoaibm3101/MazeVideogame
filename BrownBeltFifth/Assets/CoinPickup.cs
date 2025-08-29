using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    
    // Start is called before the first frame updatef
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("touched");
        GameObject door = GameObject.FindGameObjectWithTag("exit");

        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            Destroy(door);
            
        }
    }
}
