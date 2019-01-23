using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    when player hit the cube, the canvas shows up
*/
public class ShowUI : MonoBehaviour {

    private GameObject UIs;
    private Transform[] uiObjects;

    void Start()
    {
        UIs = GameObject.Find("UIs");
        uiObjects = GetTopLevelChildren(UIs.transform);

    	for (int i = 0; i < uiObjects.Length; i++) {
    		uiObjects[i].GetChild(1).gameObject.SetActive(false);
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
    
     private static Transform[] GetTopLevelChildren(Transform Parent)
     {
         Transform[] Children = new Transform[Parent.childCount];
         for (int ID = 0; ID < Parent.childCount; ID++)
         {
             Children[ID] = Parent.GetChild(ID);
         }
         return Children;
     }
}