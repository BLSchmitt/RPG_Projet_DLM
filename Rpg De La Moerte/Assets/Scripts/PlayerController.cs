using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;
    private string movementAxeHorizontal;
    private string movementAxeVertical;

    // Start is called before the first frame update
     void Start()
    {
        movementAxeHorizontal = "Horizontal";
        movementAxeVertical = "Vertical";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis(movementAxeHorizontal);
        float movementVertical = Input.GetAxis(movementAxeVertical);
        Vector3 movement = new Vector3(movementHorizontal,movementVertical,0.0f);

        rb.MovePosition(transform.position + movement*speed*Time.deltaTime);
    }

}
