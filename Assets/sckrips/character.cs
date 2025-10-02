using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    // Start is called before the first frame update
    bool play = false;
    bool ded = false;
    int direction = 180;
    public GameObject Camera;
    Vector3 startPos;
    Vector3 startRot;
    Vector3 CameraOffsetStart;

    public Vector3 CameraOffset;

    void Start()
    {
        Camera = GameObject.Find("Camera");
        CameraOffsetStart = Camera.transform.position - gameObject.transform.position;
        CameraOffset = CameraOffsetStart;
        startPos = gameObject.transform.position;
        startRot = gameObject.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (play == false)
            {
                play = true;
            }
        }
        if (play == true)
        {
            if (gameObject.transform.position.y < 0)
            {
                die();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                direction = direction - 90;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                direction = direction + 90;
            }
            gameObject.transform.eulerAngles = new Vector3(-90, 0, direction);
        }
        if (play == true)
        {
            gameObject.transform.position = gameObject.transform.position + gameObject.transform.right * Time.deltaTime * 10f;
        }
        Camera.transform.position = gameObject.transform.position + CameraOffset;
        Camera.transform.LookAt(gameObject.transform.position + new Vector3(0, 0.5f, 0));
    }
    void FixedUpdate()
    {
        
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Crash")
        {
            die();
        }
    }
    void die()
    {
        direction = 180;
        gameObject.transform.eulerAngles = startRot;
        gameObject.transform.position = startPos;
        CameraOffset = CameraOffsetStart;
        play = false;
    }
}