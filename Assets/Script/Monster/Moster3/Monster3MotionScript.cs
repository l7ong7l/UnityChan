using UnityEngine;
using System.Collections;

public class Monster3MotionScript : MonoBehaviour {
    Animator anime;
    Monster3StatusScript status;
    public GameObject player;
    GameControlScript control;

    float rotateSpeed = 30f;
    bool isDeath = false;
    bool isSight = false;
    // Use this for initialization
    void Start () {
         control= GetComponent<GameControlScript>();
	}
	
	// Update is called once per fram
	void Update () {
        player.GetComponent<PlayerControllerScript>().control = control;
        mind(player);
	}
    
    void walk(GameObject Player)
    {
        if(Vector3.Distance(transform.position, Player.transform.position) >2)
            anime.SetBool("Walk",true);
        else
            anime.SetBool("Walk", false);
    }
    void roar()
    {
        anime.SetBool("Roar",true);
        anime.SetBool("Roar", false);
    }
    void attack()
    {
    }
    void mind(GameObject Player)
    {
        if (Vector3.Distance(transform.position, Player.transform.position) <= 10)
        {
            //   Vector3 mDir = Vector3.RotateTowards(this.transform.forward,Player.transform.position,rotateSpeed*Time.deltaTime,0.0f);
            Vector3 mDir = transform.forward - Player.transform.position;
            transform.rotation = Quaternion.LookRotation(mDir);
            roar();
            walk(Player);
        }
    }
    void death()
    {
        
    }
}
