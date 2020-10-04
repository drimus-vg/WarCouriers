using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public Movement movement;
    public Transform player;
    public PlayerStatus PS;
    Movement _movement;


    private void Start()
    {
        _movement = gameObject.GetComponent<Movement>();
    }



    void OnCollisionEnter(Collision collisionInfo)
    {
        if (PS.godmode) { }
        else

        {
            if (collisionInfo.collider.tag == "spearman")
            {
                _movement.canMove = false;

            }

            if (collisionInfo.collider.tag == "swordman")
            {
                _movement.canMove = false;
            }

        }
    }

}

