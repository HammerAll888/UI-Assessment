using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    //This script will despawn the glass breaking clones after 3 seconds
    void Start()
    {
        StartCoroutine(glassDespawn());
    }

    IEnumerator glassDespawn()

    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
