using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour
{
	public float scalingSpeed = 0.1f;
	public float rotationSpeed = 70.0f;
//	public GameObject Model;
	bool repeatScaleUp = false;
	bool repeatScaleDown = false;
	bool repeatRotateLeft = false;
	bool repeatRotateRight = false;
	
	void Update ()
	{
		if (repeatScaleUp) {
			ScaleUpButton ();
		}

		if (repeatScaleDown) {
			ScaleDownButton ();
		}

		
		if (repeatRotateRight) {
			Debug.Log("ya");
			RotationRightButton();
		}

		if (repeatRotateLeft) {
			Debug.Log(repeatRotateLeft);
			RotationLeftButton();
		}

	}

	public void CloseAppButton ()
	{
		Application.Quit ();
	}

	public void RotationRightButton ()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);

		foreach (GameObject m in GameObject.FindGameObjectsWithTag("Model"))
         {
             m.transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0,Space.World);
         }
	}

	public void RotationLeftButton ()
	{
		
		// transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		foreach (GameObject m in GameObject.FindGameObjectsWithTag("Model"))
         {
             m.transform.Rotate (0, rotationSpeed * Time.deltaTime, 0,Space.World);
         }
	}

	public void RotationRightButtonRepeat ()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		repeatRotateRight=true;
	}
	
	public void RotationLeftButtonRepeat ()
	{
		// transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		repeatRotateLeft=true;
	}

	public void ScaleUpButton ()
	{
		// transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
		foreach (GameObject m in GameObject.FindGameObjectsWithTag("Model"))
         {
             m.transform.localScale += new Vector3 (scalingSpeed, scalingSpeed, scalingSpeed);
         }
		}

	public void ScaleUpButtonRepeat ()
	{
		repeatScaleUp = true;
		Debug.Log ("Up");
	}
	public void ScaleDownButtonRepeat ()
	{
		repeatScaleDown = true;
		Debug.Log ("Down");
	}
	
	public void ScaleUpButtonOff ()
	{
		repeatScaleUp = false;
		Debug.Log ("Off");
	}
	public void ScaleDownButtonOff ()
	{
		repeatScaleDown = false;
		Debug.Log ("Off");
	}

	public void RotateLeftButtonOff ()
	{
		repeatRotateLeft = false;
		Debug.Log ("Off");
	}

	public void RotateRightButtonOff ()
	{
		repeatRotateRight = false;
		Debug.Log ("Off");
	}
	
	public void ScaleDownButton ()
	{
		// transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
		
		foreach (GameObject m in GameObject.FindGameObjectsWithTag("Model"))
         {
             m.transform.localScale += new Vector3 (-scalingSpeed, -scalingSpeed, -scalingSpeed);
         }
	}


}
