using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSettings : MonoBehaviour {

	void Awake ()
    {
        Application.targetFrameRate = 10;
	}

}
