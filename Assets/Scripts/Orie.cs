using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orie : Fighter
{

	// Use this for initialization
	void Start () {
        HP = 25;
        Attk = 5;
        Def = 8;
        Spd = 3;
		
	}

    void onLevel()
    {
        int HpR = Random.Range(1, 100);
        if (HpR < 90) HP += 1;

        int AttkR = Random.Range(1, 100);
        if (AttkR < 50) Attk += 1;

        int DefR = Random.Range(1, 100);
        if (DefR < 80)  Def += 1;

        int SpdR = Random.Range(1, 100);
        if (SpdR < 45) Spd += 1;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
