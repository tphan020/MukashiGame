using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;


public class SyncStats : NetworkBehaviour
{

    [SyncVar]
    public int HP1;
    [SyncVar]
    public int HP2;
    [SyncVar]
    public int HP3;
    [SyncVar]
    public int HP4;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
