using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval;
    // Update is called once per frame




    void Update()
    {
        //timeInterval = Random.Range(3, 5);
        // On spacebar press, send dog
        InvokeRepeating("SpawnDogs", 1.5f, Random.Range(3.0f, 6.0f));
    }

    private void SpawnDogs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
