using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject third;
    public GameObject first;

    public GameObject thirdposition;
    public GameObject firstposition;

    public GameObject thirdcam;
    public GameObject firstcam;

    //value to represent which camera view is being used 0 - Third Person and 1 - First Person
    public int CamMode;


	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown ("Camera"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine (CamChange());
        }

    }

    IEnumerator CamChange ()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {

            thirdposition.transform.position = firstposition.transform.position;
            thirdcam.transform.rotation = first.transform.rotation;

            third.SetActive(true);
            first.SetActive(false);
        }
        if (CamMode == 1)
        {

            firstposition.transform.position = thirdposition.transform.position;
            firstcam.transform.rotation = thirdcam.transform.rotation;

            first.SetActive(true);
            third.SetActive(false);
        }
    }

}
