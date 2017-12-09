using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musashi : Fighter
{

    // Use this for initialization
    void Start()
    {
        HP = 15;
        Attk = 7;
        Def = 4;
        Spd = 8;

    }

    void onLevel()
    {
        int HpR = Random.Range(1, 100);
        if (HpR < 70) HP += 1;

        int AttkR = Random.Range(1, 100);
        if (AttkR < 80) Attk += 1;

        int DefR = Random.Range(1, 100);
        if (DefR < 45)  Def += 1;

        int SpdR = Random.Range(1, 100);
        if (SpdR < 75) Spd += 1;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
