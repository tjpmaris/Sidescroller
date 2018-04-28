using UnityEngine;
using System.Collections;

public class CameraOnObject : MonoBehaviour {

    public GameObject obj;
    public int zoom;

	// Use this for initialization
	void Start () {
        SetPosition(obj.transform);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        SetPosition(obj.transform);
	}

    private void SetPosition(Transform t)
    {
        this.transform.position = new Vector3(t.transform.position.x, t.transform.position.y, zoom);

    }
}
