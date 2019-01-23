using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    when player hit the cube, the canvas shows up
*/
public class ShowUI : MonoBehaviour {

    public GameObject[] uiObject;
    void Start()
    {
    	for (int i = 0; i < uiObject.Length; i++) {
    		uiObject[i].transform.GetChild(1).gameObject.SetActive(false);
    	}
    }
	// Update is called once per frame
	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "uiObject")
        {
        	collision.gameObject.SetActive(false);
            collision.gameObject.transform.parent.transform.GetChild(1).gameObject.SetActive(true);
            StartCoroutine(WaitForSec(collision));
        }
	}
    IEnumerator WaitForSec(Collision collision)
    {
        yield return new WaitForSeconds(5);
        Destroy(collision.gameObject.transform.parent.gameObject);
    }
    
}