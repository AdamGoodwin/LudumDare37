using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour
{
    public GameObject[] walls;

    public bool hasWon = false;
    public GameObject WinOrLose;

    public bool fire = false;
    public bool water = false;
    public bool air = false;
    public bool earth = false;

    void Update()
    {
        //win condition find all the elements
        if(fire && water && air && earth)
        {
            hasWon = true;
        }

        //loss condition get squished
        if (walls[0].transform.position == walls[1].transform.position && walls[2].transform.position == walls[3].transform.position)
        {
            Text text = WinOrLose.GetComponent<Text>();
            text.text = "You Lose!";
        }
    }

    public void SetFire()
    {
        fire = true;
    }

    public void SetWater()
    {
        water = true;
    }

    public void SetAir()
    {
        air = true;
    }

    public void SetEarth()
    {
        earth = true;
    }
}
