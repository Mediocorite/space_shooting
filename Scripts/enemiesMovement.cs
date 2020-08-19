using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesMovement : MonoBehaviour
{
    // Variables for speed,rigidbody and time duration
    public float enemiesSpeed;
    private Rigidbody rb;
    public float lifeDuration;
    private float lifeTimer;
    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = lifeDuration;
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1*enemiesSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Destroying the enemies when its time is up
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
