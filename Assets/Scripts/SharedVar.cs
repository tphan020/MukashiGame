using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;


public class SharedVar : NetworkBehaviour
{
    [SyncVar]
    public int playersync = 0;
    public Image imgchar1;
    public Image imgchar2;
    public Image imgchar3;
    public Image imgchar4;
    public Image background;
    public Image curbackground;
    [SyncVar]
    public int player1char = 1;
    [SyncVar]
    public int player2char = 1;
    [SyncVar]
    public int player3char = 1;
    [SyncVar]
    public int player4char = 1;
    [SyncVar]
    public int Scene = 0;

    public int personalnum = 1;
    public Sprite Shiro;
    public Sprite Mingxi;
    public Sprite Musashi;
    public Sprite Orie;
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    private GameObject sprite1_shad;
    private GameObject sprite2_shad;
    private GameObject sprite3_shad;
    private GameObject sprite4_shad;
    public bool once = true;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void character_select(){
        if (player1char == 1)
            imgchar1.sprite = Orie;
        else if (player1char == 2)
            imgchar1.sprite = Musashi;
        else if (player1char == 3)
            imgchar1.sprite = Mingxi;
        else if (player1char == 4)
            imgchar1.sprite = Shiro;

        if (player2char == 1)
            imgchar2.sprite = Orie;
        else if (player2char == 2)
            imgchar2.sprite = Musashi;
        else if (player2char == 3)
            imgchar2.sprite = Mingxi;
        else if (player2char == 4)
            imgchar2.sprite = Shiro;

        if (player3char == 1)
            imgchar3.sprite = Orie;
        else if (player3char == 2)
            imgchar3.sprite = Musashi;
        else if (player3char == 3)
            imgchar3.sprite = Mingxi;
        else if (player3char == 4)
            imgchar3.sprite = Shiro;

        if (player4char == 1)
            imgchar4.sprite = Orie;
        else if (player4char == 2)
            imgchar4.sprite = Musashi;
        else if (player4char == 3)
            imgchar4.sprite = Mingxi;
        else if (player4char == 4)
            imgchar4.sprite = Shiro;
    }

    public void character_sprite()
    {
        if (player1char == 1)
        {
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player1char == 2)
        {
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player1char == 3)
        {
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player1char == 4)
        {
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }

        if (player2char == 1)
        {
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player2char == 2)
        {
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player2char == 3)
        {
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player2char == 4)
        {
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }

        if (player3char == 1)
        {
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player3char == 2)
        {
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player3char == 3)
        {
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player3char == 4)
        {
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }

        if (player4char == 1)
        {
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player4char == 2)
        {
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player4char == 3)
        {
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player4char == 4)
        {
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }
    }
    [ClientRpc]
    public void Rpccharacter_sprite()
    {
        if (player1char == 1)
        {
            sprite1.transform.localPosition = new Vector3(3.28f, -4.34f, -.4f);
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player1char == 2)
        {
            sprite1.transform.localPosition = new Vector3(3.4f, -2, -.4f);
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player1char == 3)
        {
            sprite1.transform.localPosition = new Vector3(2.3f, -2f, -.4f);
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player1char == 4)
        {
            sprite1.transform.localPosition = new Vector3(2.75f, -1.4f, -.4f);
            sprite1.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite1.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }

        if (player2char == 1)
        {
            sprite2.transform.localPosition = new Vector3(2.50f, -2.3f, -.3f);
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player2char == 2)
        {
            sprite2.transform.localPosition = new Vector3(2.75f, .3f, -.3f);
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player2char == 3)
        {
            sprite2.transform.localPosition = new Vector3(1.35f, .1f, -.3f);
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player2char == 4)
        {
            sprite2.transform.localPosition = new Vector3(2.1f, .75f, -.3f);
            sprite2.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite2.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }

        if (player3char == 1)
        {
            sprite3.transform.localPosition = new Vector3(5.4f, -1.9f, -.3f);
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player3char == 2)
        {
            sprite3.transform.localPosition = new Vector3(5.7f, .65f, -.1f);
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player3char == 3)
        {
            sprite3.transform.localPosition = new Vector3(4.2f, .45f, -.3f);
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player3char == 4)
        {
            sprite3.transform.localPosition = new Vector3(4.7f, 1f, -.3f);
            sprite3.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite3.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }

        if (player4char == 1)
        {
            sprite4.transform.localPosition = new Vector3(7.3f, -3.90f, -.35f);
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_idle", typeof(Sprite)) as Sprite;
        }
        else if (player4char == 2)
        {
            sprite4.transform.localPosition = new Vector3(7.5f, -1.40f, -.35f);
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player4char == 3)
        {
            sprite4.transform.localPosition = new Vector3(6.15f, -1.5f, -.35f);
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle", typeof(Sprite)) as Sprite;
        }
        else if (player4char == 4)
        {
            sprite4.transform.localPosition = new Vector3(6.7f, -.95f, -.35f);
            sprite4.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite4.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle", typeof(Sprite)) as Sprite;
        }
    }

    public void switch_sprite()
    {
        sprite1 = GameObject.Find("Player1");
        sprite2 = GameObject.Find("Player2");
        sprite3 = GameObject.Find("Player3");
        sprite4 = GameObject.Find("Player4");
        sprite1_shad = GameObject.Find("P1_shade");
        sprite2_shad = GameObject.Find("P2_shade");
        sprite3_shad = GameObject.Find("P3_shade");
        sprite4_shad = GameObject.Find("P4_shade");
        if (isServer)
        {
            character_sprite();
            Rpccharacter_sprite();
            once = false;
         
        }
        if (playersync == 1)
        {
            sprite1on();
            Rpcsprite1on();
        }
        else if (playersync == 2)
        {
            sprite2on();
            Rpcsprite2on();
        }
        else if (playersync == 3)
        {
            sprite3on();
            Rpcsprite3on();
        }
        else if (playersync == 4)
        {
            sprite4on();
            Rpcsprite4on();
        }
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        switch_sprite();
    }

    void Update()
    {
        if (Scene == 0)
        {         
            character_select();
        }
        if (Scene == 1)
        {            
        }

    }

    [Command]
    public void Cmdcharacternum(int x, int y)
    {
        player1char = 105;
        personalnum = 66;

    }

    public void charchange(int x, int y)
    {
        player1char++;
        personalnum++;
    }
    [ClientRpc]
    public void RpcDestroyAllGameObjects()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < GameObjects.Length; i++)
        {
            if (GameObjects[i].name != "NetworkManager" && GameObjects[i].name != "SharedValues")
            {
                Destroy(GameObjects[i]);
            }
        }
    }

    public void DestroyAllGameObjects()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < GameObjects.Length; i++)
        {
            if (GameObjects[i].name != "NetworkManager" || GameObjects[i].name != "SharedValues")
            {
                Destroy(GameObjects[i]);
            }
        }
    }

    public void setchoose(int x)
    {
        if (playersync==1)
        {
            player1char = x;
        }
        else if (playersync == 2)
        {
            player2char = x;
        }
        else if (playersync == 3)
        {
            player3char = x;
        }
        else if (playersync == 4)
        {
            player4char = x;
        }


    }
    [ClientCallback]
    public void runcharacternum()
    {
        if (isLocalPlayer)
        {
            Cmdcharacternum(3, 1);
        }
    }

    void OnGUI()
    {


    }
    [ClientRpc]
    public void Rpcinvissprite()
    {
        sprite1.SetActive(false);

    }

    public void invissprite()
    {
        sprite1.SetActive(false);

    }

    [ClientRpc]
    public void RpcLobby()
    {
        background.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        curbackground.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    public void Lobby()
    {
        background.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        curbackground.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    [ClientRpc]
    public void Rpcimgoff()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    public void imgoff()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    [ClientRpc]
    public void Rpcimg1on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    public void img1on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    [ClientRpc]
    public void Rpcimg2on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    public void img2on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    [ClientRpc]
    public void Rpcimg3on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    public void img3on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
    }

    [ClientRpc]
    public void Rpcimg4on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
    }

    public void img4on()
    {
        imgchar1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar3.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        imgchar4.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
    }
    [ClientRpc]
    public void Rpcsprite1on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(false);
        sprite3.SetActive(false);
        sprite4.SetActive(false);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(false);
        sprite3_shad.SetActive(false);
        sprite4_shad.SetActive(false);
    }
    public void sprite1on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(false);
        sprite3.SetActive(false);
        sprite4.SetActive(false);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(false);
        sprite3_shad.SetActive(false);
        sprite4_shad.SetActive(false);
    }

    [ClientRpc]
    public void Rpcsprite2on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(true);
        sprite3.SetActive(false);
        sprite4.SetActive(false);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(true);
        sprite3_shad.SetActive(false);
        sprite4_shad.SetActive(false);
    }
    public void sprite2on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(true);
        sprite3.SetActive(false);
        sprite4.SetActive(false);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(true);
        sprite3_shad.SetActive(false);
        sprite4_shad.SetActive(false);
    }
    [ClientRpc]
    public void Rpcsprite3on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(true);
        sprite3.SetActive(true);
        sprite4.SetActive(false);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(true);
        sprite3_shad.SetActive(true);
        sprite4_shad.SetActive(false);
    }
    public void sprite3on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(true);
        sprite3.SetActive(true);
        sprite4.SetActive(false);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(true);
        sprite3_shad.SetActive(true);
        sprite4_shad.SetActive(false);
    }
    [ClientRpc]
    public void Rpcsprite4on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(true);
        sprite3.SetActive(true);
        sprite4.SetActive(true);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(true);
        sprite3_shad.SetActive(true);
        sprite4_shad.SetActive(true);
    }
    public void sprite4on()
    {
        sprite1.SetActive(true);
        sprite2.SetActive(true);
        sprite3.SetActive(true);
        sprite4.SetActive(true);
        sprite1_shad.SetActive(true);
        sprite2_shad.SetActive(true);
        sprite3_shad.SetActive(true);
        sprite4_shad.SetActive(true);
    }

    public void playerinc()
    {

        playersync++;
    }

    public void playerdec()
    {
        playersync--;
    }

    public int getplayer()
    {
        return playersync;
    }
    public void setpersonalval(int x)
    {
        personalnum = x;
    }





}
