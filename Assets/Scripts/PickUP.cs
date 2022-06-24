using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUP : MonoBehaviour
{
    private int count;
    [SerializeField] TextMeshProUGUI score;
    private void Start()
    {
        count = 0;
        Debug.Log("Initial count-" + count);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            count++;
            score.text = count.ToString();
            Destroy(other.gameObject);

        }
    }
}
