using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float Forward = 2000f;
    //[HideInInspector]
    public bool canMove;
    public float Up = 100;
    public float speed;


    private void Start()
    {
        canMove = true;
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
        {
        float Side = Input.GetAxis("Horizontal");
        bool a = Input.GetKey(KeyCode.A);
        bool d = Input.GetKey(KeyCode.D);
        bool space = Input.GetKey(KeyCode.Space);




        if (canMove)
            {

            if (rb.velocity < new Vector3(0,0,15)
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

            if (space)
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


