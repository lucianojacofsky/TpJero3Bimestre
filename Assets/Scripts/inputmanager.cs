using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inputmanager : MonoBehaviour
{
    public InputField ifusername;
    public Text txtusermanager;

    public void UserGreetings()
    {
        Debug.Log(int.Parse(txtusermanager.text) * 2);
    }
}
