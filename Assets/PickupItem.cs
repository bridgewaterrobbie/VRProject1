﻿using UnityEngine;
using System.Collections;

public class PickupItem : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            ItemsCollected++;
        }
    }
}