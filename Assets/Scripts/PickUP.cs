using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TEST");
        if (other.gameObject.CompareTag("Coin"))
        {

            Debug.Log("Coin Collecter");
            Destroy(other.gameObject);
        }
    }
}
