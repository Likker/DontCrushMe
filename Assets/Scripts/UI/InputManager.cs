using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastTouch();
    }

    bool RaycastTouch()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.CompareTag("Arrow"))
                    hit.transform.gameObject.SendMessage("OnMouseDown", hit.transform.GetComponent<ArrowButton>().dir, SendMessageOptions.DontRequireReceiver);
            }
        }
        return false;
    }

}
