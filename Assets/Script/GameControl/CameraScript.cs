using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        View();
	}
    void View()
    {
        var MouseZoomMin = 2;
        var MouseZoomMax = 10;
        var MouseScollSensitivity = 5;
        float Scoller = Input.GetAxis("Mouse ScollWheel");
        if (Scoller != 0)
        {
            if(Scoller *MouseScollSensitivity <= MouseZoomMax && Scoller>=MouseZoomMin)
                transform.Rotate(0f,Scoller * MouseScollSensitivity, 0f);
            else if (Scoller * MouseScollSensitivity < MouseZoomMin)
                Scoller = MouseZoomMin;
            else
                Scoller = MouseZoomMax;
        }
    }
}
