using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public static GameObject S;
    public List<GameObject> planets;

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

	}
	
	// Update is called once per frame
	void Update () {

    }
}
