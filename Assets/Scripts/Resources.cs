using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Resources : MonoBehaviour
{
    public int Wood = 0;
    public int Stone = 0;
    public int Wheat = 0;
    public int Vilager = 1;

    public int Wood_Storage = 2500;
    public int Stone_Storage = 2500;
    public int Wheat_Storage = 2500;
    public int Villager_Huts = 1;

    public int Lumber_Mills = 1;
    public int Mines = 1;
    public int Fields = 1;

    public int Wood_Worker = 0;
    public int Stone_Worker = 0;
    public int Wheat_Worker = 0;

    public int Statprog = 0;
    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Wood = Wood + (50 * Wood_Worker);
            Stone = Stone + (50 * Stone_Worker);
            Wheat = Wheat + (50 * Wheat_Worker);
            if (Wood > Wood_Storage)
            {
                Wood = Wood_Storage;
            }
            if (Stone > Stone_Storage)
            {
                Stone = Stone_Storage;
            }
            if (Wheat > Wheat_Storage)
            {
                Wheat = Wheat_Storage;
            }
        }
    }

    void Update()
    {

    }

    //Statue Section
    public void StatButton()
    {
        if (Statprog < 6)
        {
            if (Wood >= 1000 * (5 * (Statprog + 1)) && Stone >= 1000 * (5 * (Statprog + 1)) && Wheat >= 1000 * (5 * (Statprog + 1)) && Vilager >= 1000 * (5 * (Statprog + 1)))
            {
                Wood -= 1000 * (5 * (Statprog + 1));
                Stone -= 1000 * (5 * (Statprog + 1));
                Wheat -= 1000 * (5 * (Statprog + 1));
                Vilager -= 10 * (5 * (Statprog + 1));
                Villager_Huts -= 10 * (5 * (Statprog + 1));
                Statprog += 1;
            }
        }
    }

    //Villager Section
    public void Huts()
    {
        if (Wood >= 200 && Stone >= 200 && Wheat >= 200)
        {
            Villager_Huts++;
            Vilager++;
            Wood -= 200;
            Stone -= 200;
            Wheat -= 200;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }
    
    //Wood Section

    public void Wood_Worker_Increase()
    {
        if (Wood_Worker < Lumber_Mills && Vilager > 0)
        {
            Wood_Worker++;
            Vilager--;
        }
        else
        {
            Debug.Log("not enough lumber mills");
        }
    }
    public void Wood_Worker_Decrease()
    {
        if (Wood_Worker > 0)
        {
            Wood_Worker--;
            Vilager++;
        }
        else
        {
            Debug.Log("not enough Villagers in building");
        }
    }
    public void LumberMillS()
    {
        if (Wood >= 200)
        {
            Lumber_Mills++;
            Wood -= 200;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }
    public void LumberMax()
    {
        if (Wood >= Convert.ToInt32(Wood_Storage*0.8))
        {
            Wood -= Convert.ToInt32(Wood_Storage * 0.8);
            Wood_Storage += 2500;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }

    //Stone Section

    public void Stone_Worker_Increase()
    {
        if (Stone_Worker < Mines && Vilager > 0)
        {
            Stone_Worker++;
            Vilager--;
        }
        else
        {
            Debug.Log("not enough Mines");
        }
    }
    public void Stone_Worker_Decrease()
    {
        if (Stone_Worker > 0)
        {
            Stone_Worker--;
            Vilager++;
        }
        else
        {
            Debug.Log("not enough Villagers in building");
        }
    }
    public void MineS()
    {
        if (Stone >= 200)
        {
            Mines++;
            Stone -= 200;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }
    public void StoneMax()
    {
        if (Stone >= Convert.ToInt32(Stone_Storage * 0.8))
        {
            Stone -= Convert.ToInt32(Stone_Storage * 0.8);
            Stone_Storage += 2500;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }
    //Wheat Section

    public void Wheat_Worker_Increase()
    {
        if (Wheat_Worker < Fields && Vilager > 0)
        {
            Wheat_Worker++;
            Vilager--;
        }
        else
        {
            Debug.Log("not enough Fields");
        }
    }
    public void Wheat_Worker_Decrease()
    {
        if (Wheat_Worker > 0)
        {
            Wheat_Worker--;
            Vilager++;
        }
        else
        {
            Debug.Log("not enough Villagers in building");
        }
    }
    public void FieldS()
    {
        if (Wheat >= 200)
        {
            Fields++;
            Wheat -= 200;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }
    public void WheatMax()
    {
        if (Wheat >= Convert.ToInt32(Wheat_Storage * 0.8))
        {
            Wheat -= Convert.ToInt32(Wheat_Storage * 0.8);
            Wheat_Storage += 2500;
        }
        else
        {
            Debug.Log("not enough resources");
        }
    }
}