using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleMovement : MonoBehaviour
{
    public string axis = "Vertical";
    [HideInInspector] public float mvmntspeed=5f;
    public Rigidbody2D rb;
    Vector2 movement;
    private void FixedUpdate()
    {
        float a = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, a) * mvmntspeed;
    }
}
