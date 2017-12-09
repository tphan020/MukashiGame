using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;


public class PlayerCmd : NetworkBehaviour
{
    public GameObject sharing;
    public SharedVar senddata;
    public NetworkIdentity personalid;
    public GameObject Menuob;
    [SyncVar]
    public int poopynose;
    [SyncVar]
    int playertest = 0;
    [SyncVar]
    public int tester1 = 0;
    [SyncVar]
    public int tester2 = 0;
    private int firsttime=0;

    [Command]
    public void CmdCharInit(int x)
    {
            sharing.GetComponent<NetworkIdentity>().AssignClientAuthority(personalid.connectionToClient);
            senddata.setchoose(x);
            sharing.GetComponent<NetworkIdentity>().RemoveClientAuthority(personalid.connectionToClient);
    }



    void Start()
    {
        personalid = this.GetComponent<NetworkIdentity>();
        sharing = GameObject.Find("SharedValues");
        senddata = sharing.GetComponent<SharedVar>();
        Menuob = GameObject.Find("NetworkManager");

        Time.timeScale = 1.0f;

    }
    
    void Update()
    {
        if ((isLocalPlayer) && (firsttime==0))
        {
            CmdCharInit(senddata.personalnum);
            firsttime++;
        }
    }

    [ClientRpc]
    public void Rpcsend()
    {
        playertest = 10;
        tester1 = 22;
        tester2 = 33;
        poopynose = 99;
        Debug.Log("client got fucked");

    }

    [Command]
    public void Cmdchangenum()
    {
        sharing.GetComponent<NetworkIdentity>().AssignClientAuthority(personalid.connectionToClient);
        senddata.charchange(0, 0);
        sharing.GetComponent<NetworkIdentity>().RemoveClientAuthority(personalid.connectionToClient);

    }

    void OnGUI()
    {


    }



}
