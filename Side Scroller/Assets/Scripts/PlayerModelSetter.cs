using UnityEngine;
using System.Collections;

public class PlayerModelSetter : MonoBehaviour {

    public float speed;
    public float jumpSpeed;
    // Use this for initialization
    void Start () {
        PlayerModel.jumpSpeed = jumpSpeed;
        PlayerModel.speed = speed;
        PlayerModel.isGrounded = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
