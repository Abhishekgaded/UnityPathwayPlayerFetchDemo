using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval;

    // Update is called once per frame
    void Update()
    {
        timeInterval = Random.Range(3, 5);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
