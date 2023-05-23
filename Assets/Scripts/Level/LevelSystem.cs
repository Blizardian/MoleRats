using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int Experience;//Het aantal Experience die de speler heeft
    public int PlayerLevel;//Het level van de speler
    // Start is called before the first frame update
    void Start()
    {
        PlayerLevel = 1;
    }

    // Update is called once per frame
    public void Update()
    {
        LevelReminder();
        ButtonPressed();    }


    public void ButtonPressed()
    {
        //Als de E op het toetsenbord wordt gedrukt gebeurd er het volgende
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("You Gained 1000 Experience!");
            Experience += 1000;
        }
    }

    public void LevelReminder()
    {
        //Switch Statement Houd bij welk level je bent en wat er vervolgens moet gebeuren
        switch (PlayerLevel)
        {
        case 5:
            if(Experience == 15000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            }
            break;
        case 4:
            if(Experience == 10000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            }
            break;
        case 3:
            if(Experience == 6000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            }
            break;
        case 2:
            if(Experience == 4000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            }
            break;
        case 1:
             if(Experience == 2000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            }
            break;
        default:
            print ("Je level kan niet hoger");
            break;
        }



        /*
        if (PlayerLevel == 1)
        {
            if(Experience == 2000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            } 
        }

        if (PlayerLevel == 2)
        {
          if(Experience == 4000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            } 

        }

        if (PlayerLevel == 3)
        {
            if(Experience == 6000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            } 
        }

        if (PlayerLevel == 4)
        {
            if(Experience == 10000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            } 
        }
        if (PlayerLevel == 5)
        {
            if(Experience == 15000)
            {
            PlayerLevel++;
            print("You are now level" + PlayerLevel);
            Experience = 0;
            } 
        }
        }*/
    }
}


