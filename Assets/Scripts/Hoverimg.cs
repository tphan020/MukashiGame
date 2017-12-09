using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hoverimg : MonoBehaviour {

    public Image background_main;
    public Image background1;
    public Image background2;
    public Image background3;
    public Button Char_button;
    public int characterval;
    public SharedVar charshare;
    public GameObject sprite_main;


    // Use this for initialization
    void Start () {
        Button btn = Char_button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }
	
    void adjust_sprite()
    {
        if (characterval == 1)
        {
            //sprite_main.transform.localPosition = new Vector3(281, -135, -10);
            sprite_main.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Orie_Idle_0")) as RuntimeAnimatorController;
            sprite_main.GetComponent<SpriteRenderer>().sprite = Resources.Load("Orie_Idle_0", typeof(Sprite)) as Sprite;
        }
        else if(characterval == 2)
        {
            //sprite_main.transform.localPosition = new Vector3(290, -70, -10);
            sprite_main.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Musashi_Idle_0")) as RuntimeAnimatorController;
            sprite_main.GetComponent<SpriteRenderer>().sprite = Resources.Load("Musashi_Idle_0", typeof(Sprite)) as Sprite;
        }
        else if (characterval == 3)
        {
            //sprite_main.transform.localPosition = new Vector3(260, -75, -10);
            sprite_main.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Ming_Idle_0")) as RuntimeAnimatorController;
            sprite_main.GetComponent<SpriteRenderer>().sprite = Resources.Load("Ming_Idle_0", typeof(Sprite)) as Sprite;
        }
        else if (characterval == 4)
        {
            //sprite_main.transform.localPosition = new Vector3(270, -60, -10);
            sprite_main.GetComponent<Animator>().runtimeAnimatorController = Instantiate(Resources.Load("Shirou_Idle_0")) as RuntimeAnimatorController;
            sprite_main.GetComponent<SpriteRenderer>().sprite = Resources.Load("Shirou_Idle_0", typeof(Sprite)) as Sprite;
        }
    }

	// Update is called once per frame
	void Update () {
    }
    void OnGUI()
    {
    }
    void TaskOnClick()
    {
        charshare.personalnum=characterval;
        StartCoroutine(FadeImage(true));
        background1.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        background2.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        background3.GetComponent<Image>().color = new Color32(255, 255, 225, 0);
        adjust_sprite();
    }
    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                background_main.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }


}
