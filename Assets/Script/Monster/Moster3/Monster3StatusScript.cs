using UnityEngine;
using System.Collections;

public class Monster3StatusScript : MonoBehaviour {

    float status()
    {
        float HP = 100;
        float ATK = 10;
        float DEF = 10;

        return HP;
        return ATK;
        return DEF;
    }
    float damage(float HP,float ATK,float DEF)
    {
        if (ATK > 0.75 * DEF)
            HP = HP - ATK + 0.75f * DEF;
        else
            HP = HP - 1;
        return HP;
    }
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGuI()
    {
       
    }
}
