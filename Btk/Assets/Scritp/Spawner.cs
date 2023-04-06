using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spherePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("çaıştı");
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(spherePrefab);
    }
}
