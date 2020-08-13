using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    //private void OnCollisionStay(Collision collision)
    //{
    //    Destroy(collision.gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
