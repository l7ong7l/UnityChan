using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {
    PlayerStatusScript status;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Label(new Rect(110, 10, 204, 20), "HP");
        GUI.Box(new Rect(10, 10, 204, 20), "");
        GUI.Box(new Rect(12, 11, 2 * (int)status.status(), 18),"");
    }
}
