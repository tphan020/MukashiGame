using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Menu : NetworkManager
{

    public string IP = "192.168.86.141";
    public int Port = 5001;


    public string username = "";

    public Button initgame;

    public int holder = 0;
    public int clientnum=0;

    public int playercount = 0;
    public SharedVar shareval;
    void Start()
    {
        Time.timeScale = 1.0f;
    }



    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        clientnum = shareval.playersync;
    }


    void TaskOnClick()
    {
            shareval.Rpcinvissprite();
            shareval.invissprite();
            GameObject.Find("StartLobby").GetComponentInChildren<Text>().text = "Start Battle";
            shareval.RpcLobby();
            shareval.Lobby();
            if (NetworkServer.active)
            {
                if (shareval.getplayer() == 0)
                {
                    shareval.Rpcimgoff();
                    shareval.imgoff();
                }
                if (shareval.getplayer() == 1)
                {
                    shareval.Rpcimg1on();
                    shareval.img1on();
                }
                if (shareval.playersync == 2)
                {
                    shareval.Rpcimg2on();
                    shareval.img2on();
                }
                if (shareval.playersync == 3)
                {
                    shareval.Rpcimg3on();
                    shareval.img3on();
                }
                if (shareval.playersync == 4)
                {
                    shareval.Rpcimg4on();
                    shareval.img4on();
                }
            }

        holder = 1;
    }

    void TaskOnClick1()
    {
        holder=2;
        shareval.Scene = 1;
        shareval.RpcDestroyAllGameObjects();
        ServerChangeScene("Battle1");
    }


    void Update()
    {
        if (holder != 2)
        {
            if (NetworkServer.active)
            {
                shareval.playersync = numPlayers;
                Button btn = initgame.GetComponent<Button>();
                if (holder == 0)
                {
                    btn.onClick.AddListener(TaskOnClick);
                }
                else
                {
                    btn.onClick.AddListener(TaskOnClick1);
                }
            }
        }
    }
    void OnGUI()
    {






        


       }


}