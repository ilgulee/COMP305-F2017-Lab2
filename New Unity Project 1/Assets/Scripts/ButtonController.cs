using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    public GameObject[] bodies;
    public GameObject[] buttons;
    // Use this for initialization
    void Start() {
        bodies = GameObject.FindGameObjectsWithTag("Player");
        buttons = GameObject.FindGameObjectsWithTag("GameController");

        foreach (var a in buttons)
        {
            print(a.name);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        foreach (var body in bodies)
        {
            body.SetActive(false);
        }

        if (this.name == "btnRed")
        {
            bodies[2].SetActive(true);
        } else if (this.name == "btnBlue")
        {
            bodies[1].SetActive(true);
        } else if (this.name == "btnYellow")
        {
            bodies[0].SetActive(true);
        }
    }
}
