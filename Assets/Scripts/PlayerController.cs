using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Acá creo las variables para el sonido del salto

    AudioSource source;
    public AudioClip Saltito;
    
   
    void Start()
    {
        //Acá hago que la variable "source" tome el sonido

        source = GetComponent<AudioSource>();
    }

  
    void Update()
    {
        // Acá hago que si el objeto se va muy para abajo se destruya y si se va muy para arriba lo freno

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
        saltar();
    }
    private void saltar()
    {
        // Acá creo un if para que se ejecute cuando toque la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();

            // Acá hago que sin importar si está cayendo o no, el salto sea siempre el mismo

            rb.velocity = Vector3.zero;

            // Acá pongo la fuerza del salto, 300

            rb.AddForce(Vector3.up * 300f);

            // Acá ingreso el audio del salto, "Saltito"

            source.clip = Saltito;
            source.Play();
        }
    }
}
