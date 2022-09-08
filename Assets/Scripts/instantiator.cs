using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtCloneAmount;
    public void CloneObject()
    {
        cloneAmount = int.Parse(txtCloneAmount.text);
        int contador = 0;
        while (contador < cloneAmount)
        {
            Instantiate(objectToClone);
            contador++;
        }
    }
}
