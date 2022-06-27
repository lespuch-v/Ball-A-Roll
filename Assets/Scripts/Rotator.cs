using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int randomNumber;
    private void Start()
    {
        randomNumber = Random.Range(0, 100);
    }
    void Update()
    {
        transform.Rotate(new Vector3(randomNumber, randomNumber, randomNumber) * Time.deltaTime);
    }
}
