using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Acá defino que por default, el juego no está pausado

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    
    void Update()
    {
        // Acá creo un if el cual ejecute una acción al tocar la letra "P", la P de pausa

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Si Game is paused, ejecutar la función continuar y sino ejecutar la función pausar
            if (GameIsPaused)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
        }
    }

    // En este void "Continuar" cierro el menú de pausa, vuelvo el tiempo de vuelta a 1 para que continue y aviso que el juego no está pausado

    public void Continuar()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // En este void "Pausar" abro el menú de pausa, pongo el tiempo en 0 para que no siga corriendo y aviso que el juego está pausado

    public void Pausar()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // En este void "LoadMenu" cambio a la escena "Menu" y pongo el tiempo en 1 para que continue
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    
}
