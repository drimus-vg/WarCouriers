using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public UnityEngine.Vector3 offset;
    public Movement _movement;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_movement.canMove)
        {
            transform.position = player.position + offset;
        }
    }
}
