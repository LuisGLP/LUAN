using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtom : MonoBehaviour
{
    public Canvas start;
    public Button exit;


    public void keluar()
    {
        Application.Quit();
    }
}
