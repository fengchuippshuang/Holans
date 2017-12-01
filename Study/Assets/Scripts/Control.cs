using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private void Awake()
    {
        Text.m.Health();
        Text.m.changeHealth(50);
    }
    // Use this for initialization
    void Start () {
        //Text a = new Text();
        //a.Health();
        //Debug.Log("a修改了生命");
        //a.changeHealth(50);
        //a.Health();
        //Text b = new Text();
        //b.Health();
     

    }

    // Update is called once per frame
    void Update () {
		
	}
}
