using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseController : MonoBehaviour {

    public GameObject Fire;
    public GameObject Water;
    public GameObject Air;
    public GameObject Earth;
    public GameObject WinOrLose;

    public Controller controller;

	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            HandleInput();
        }

        if(controller.fire)
        {
            Text text = Fire.GetComponent<Text>();
            text.text = "Fire";
        }
        if (controller.water)
        {
            Text text = Water.GetComponent<Text>();
            text.text = "Water";
        }
        if (controller.air)
        {
            Text text = Air.GetComponent<Text>();
            text.text = "Air";
        }
        if (controller.earth)
        {
            Text text = Earth.GetComponent<Text>();
            text.text = "Earth";
        }
        if (controller.hasWon)
        {
            Text text = WinOrLose.GetComponent<Text>();
            text.text = "You Win!";
        }
    }

    void HandleInput()
    {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(inputRay, out hit))
        {
            if(hit.collider.name == "Fireplace")
            {
                controller.SetFire();
            }
            if(hit.collider.name == "Fan")
            {
                controller.SetAir();
            }
            if (hit.collider.name == "Plant")
            {
                controller.SetEarth();
            }
            if (hit.collider.name == "Cup")
            {
                controller.SetWater();
            }
        }
    }
}
