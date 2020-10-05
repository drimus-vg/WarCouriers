using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float Forward = 2000f;
    //[HideInInspector]
    public bool canMove;
    public float Up = 100;
    public float speed;
    public float speedlimit;
    private bool grounded;


    private void Start()
    {
        canMove = true;
        rb = GetComponent<Rigidbody>();
        grounded = true;
    }


    void FixedUpdate()
        {
        int layerMask = 1 << 8;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 0.5f, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        float Side = Input.GetAxis("Horizontal");
        bool a = Input.GetKey(KeyCode.A);
        bool d = Input.GetKey(KeyCode.D);
        bool space = Input.GetKey(KeyCode.Space);

        if (canMove)
            {

            if (rb.velocity.magnitude < speedlimit)
            {
                rb.AddForce(0, 0, Forward * Time.deltaTime, ForceMode.Impulse);
            }

        else rb.AddForce(0, 0, 0);

        if (a)
            {
                Vector3 asideVect = new Vector3(Side, 0, 0);
                asideVect = asideVect.normalized * speed * Time.deltaTime;
                rb.MovePosition(transform.position + asideVect);
            }

            if (d)
            {
                Vector3 dsideVect = new Vector3(Side, 0, 0);
                dsideVect = dsideVect.normalized * speed * Time.deltaTime;
                rb.MovePosition(transform.position + dsideVect);
            }

            if (space && grounded)
            {
                rb.AddForce(0, Up * Time.deltaTime, -Forward * Time.deltaTime, ForceMode.Impulse);
            }


        }
            else
            {
                Debug.Log("NO ME PUEDO MOVER AAA");
            }
        }
}


