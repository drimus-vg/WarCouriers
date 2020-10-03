using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float Forward = 2000f;
    public float Side = 500f;
    public float Up = 200f;
    //[HideInInspector]
    public bool canMove;

    private void Start()
    {
        canMove = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            rb.AddForce(0, 0, Forward * Time.deltaTime, ForceMode.VelocityChange);

            if (Input.GetKey("d"))
            {
                rb.AddForce(Side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("a"))
            {
                rb.AddForce(-Side * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            }

            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(0, Up, -Forward/2, ForceMode.VelocityChange);
            }
        }
        else
        {
            Debug.Log("NO ME PUEDO MOVER AAA");
        }
    }
}
