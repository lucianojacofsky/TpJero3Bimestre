using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Colliders : MonoBehaviour
{
    AudioSource source;
    public AudioClip Muerte;
    public bool Isplaying;
    
    void Start()
    {
        Isplaying = false;
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
 

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tuberia")
        {
            source.clip = Muerte;
            source.Play();
            Debug.Log("choca");
            Isplaying = true;

        }
        if(Isplaying == true)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            SceneManager.LoadScene("FinalLose");
        }
    }
}

   

