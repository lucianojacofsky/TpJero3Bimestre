using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  void Start()
    {
        // Pongo el tiempo en 0 asi no empieza a correr al principio

        Time.timeScale = 0f;
    }

    // En este void "Jugar Juego" cambio y activo la escena a la del juego, la 1, y pongo el tiempo en 1 así empieza a correr

   public void JugarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    // Este void "Salir" no funciona en Unity ya que no se puede salir pero avisa por la consola que hay que salir del juego

    public void Salir()
    {
        Debug.Log("salir");
        Application.Quit();
        
    }
}
