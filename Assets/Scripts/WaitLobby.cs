using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class WaitLobby : MonoBehaviour
{
    public Image imgchar1;
    public Image imgchar2;
    public SharedVar shareval;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        if (shareval.getplayer() == 0)
        {
            imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
            imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        }
        if (shareval.getplayer() == 1)
        {
            imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        }
        if (shareval.playersync == 2)
        {
            imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        }
    }
}
