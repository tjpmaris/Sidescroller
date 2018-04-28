using UnityEngine;
using System.Collections;

public class LeftRightMovementController : MonoBehaviour {
    private Transform transform;
	// Use this for initialization
	void Start () {
        transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalMultiplier = Input.GetAxis("Horizontal");
        float horizontalAddition = horizontalMultiplier * PlayerModel.speed;

        transform.position = new Vector3(transform.position.x + horizontalAddition, transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.LogWarning("TriggerEnter");
        Debug.Log(GetComponent<BoxCollider2D>().gameObject.name);
        Debug.Log(other.gameObject.name);
        //canWalk = false;

        //other.transform

    }

    private void LateUpdate()
    {
        //if (physics.velocity.y >= -.001 && physics.velocity.y <= .001)
        //{
        //    PlayerModel.isGrounded = true;
        //}
        //else
        //{
        //    PlayerModel.isGrounded = false;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    if (PlayerModel.isGrounded)
        //    {
        //        Vector2 movement = new Vector2(0, 1);
        //        physics.AddForce(movement * PlayerModel.jumpSpeed, ForceMode2D.Impulse);
        //    }
        //}
    }
}
