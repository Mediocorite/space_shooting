using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missleShooting : MonoBehaviour
{
    // Getting our missle prefab
    public GameObject misslePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Shooting Script - Makes an instance of bullet
        if (Input.GetKeyDown("space"))
        {
            GameObject missleObject = Instantiate(misslePrefab);
            // This makes the spawn position relative to parent
            missleObject.transform.position = this.transform.position - this.transform.right;

        }
    }
}
