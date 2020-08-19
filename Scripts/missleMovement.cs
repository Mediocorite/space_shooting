using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missleMovement : MonoBehaviour
{
    // Creating the missile speed
    public float speed = 8f;
    // Creating the bullet lifetime 
    public float lifeDuration = 2f;
    private float lifeTimer;
    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = lifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        // Bullet Movement Script :- Prophells the bullet to the right
        transform.position -= transform.right * speed * Time.deltaTime;
        // Destroying the missle when its time is up
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
