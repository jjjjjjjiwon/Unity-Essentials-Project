using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colllectible : MonoBehaviour
{
    public float rotationSpeed;

    public GameObject OnCollectEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the collectible;
            Destroy(gameObject);
            // Instantiate particle effect
            Instantiate(OnCollectEffect, transform.position, transform.rotation);
        }
    }
}
