using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 movement = GetInput();
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            //gerakan ke atas
           return Vector2.up*speed;
        }

        else if (Input.GetKey(downKey))
        {
            //gerakan ke bawah
           return Vector2.down*speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {

        rig.velocity=movement;
    }
}
