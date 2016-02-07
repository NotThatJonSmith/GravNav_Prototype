using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public static GameObject S;
    public List<GameObject> planets;
    public int pickups = 0;

    // Use this for initialization
    void Awake()
    {
        if (S)
        {
            Debug.Log("Multiple players. Error.");
            return;
        }
        S = gameObject;
    }

	void Start ()
    {
        S = gameObject;
    }
	
	// Update is called once per frame
	void Update () {

    }
}
