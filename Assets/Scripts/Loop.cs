using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // En este float defino la velocidad de las tuberías

    private float velocidad = 10;


    // En este void ejecuto el void "loop"
    void Update()
    {
        loop();
    }

    // En este void "loop" hago que las tuberias vayan a la velocidad que definí antes y que si llegan a -30 vuelvan a 60
   

    private void loop()
    {
     
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        if (transform.position.x<-30)
        {
            transform.Translate(Vector3.right * 60);
        }

    }
}
