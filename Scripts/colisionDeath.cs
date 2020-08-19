using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colisionDeath : MonoBehaviour
{
    public bool fatal;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Detected");
        // Destroys the astroid on collision
        Destroy(other.gameObject);
        
        if (fatal)
        {
            StartCoroutine(gameOver());

        } else
        {
            scoreScript.scoreValue += 1;
            // Destroys the missle
            this.gameObject.SetActive(false);
        }
      
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(0);
        SceneManager.LoadScene("gameover");
    }
}
