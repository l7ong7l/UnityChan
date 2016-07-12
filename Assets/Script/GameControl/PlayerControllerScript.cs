using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour
{
    public GameControlScript control;
    public Animator anime;
    float RunSpeed = 8f;
    float RotateSpeed = 40f;
    float angle = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Run();
        attack();
    }

    void Run()
    {
        Vector3 mDir = Vector3.zero;
        if (Input.GetAxis("Horizontal") > 0.3)
        {
            Vector3 mTarget = new Vector3(0, RotateSpeed * Time.deltaTime, 0);
            transform.Rotate(mTarget);
        }
        if (Input.GetAxis("Horizontal") < -0.3)
        {
            Vector3 mTarget = new Vector3(0, -RotateSpeed * Time.deltaTime, 0);
            transform.Rotate(mTarget);
        }

        if (Input.GetAxis("Vertical") > 0.1)
        {
            mDir = Vector3.forward * RunSpeed * Time.deltaTime;
            this.transform.Translate(mDir);
            anime.SetBool("Run", true);
        }
        else
        {
            anime.SetBool("Run", false);
        }
    }

    void attack()
    {
        if (Input.GetButton("Fire1") == true)
            anime.SetBool("Jab", true);

        else
            anime.SetBool("Jab", false);


        if (Input.GetButton("Fire2") == true)
            anime.SetBool("Hikick", true);
        else
            anime.SetBool("Hikick", false);



        if (Input.GetButton("Jump") == true)
            anime.SetBool("Rising_P", true);
        else
            anime.SetBool("Rising_P", false);
    }

    
}