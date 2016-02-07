using UnityEngine;
using System.Collections;

public class PlanetScript : MonoBehaviour {

    public float strengthOfAttraction = 0;

    void Start () {

    }

    void Update()
    {
        Vector3 direction = transform.position - PlayerScript.S.gameObject.transform.position;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
        {
            PlayerScript.S.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
        }
    }
}
