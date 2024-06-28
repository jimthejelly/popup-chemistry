using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creationUser : MonoBehaviour
{
    GameObject molecule;
    public float turnSpeed; // Look speed modifier
    float xRotation = 0;
    float yRotation = 0;
    float zoom = 4;
    void Start()
    {
        molecule = GameObject.Find("Editor");

        transform.position = new Vector3(molecule.transform.position.x,molecule.transform.position.y+1,molecule.transform.position.z-4);
        transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1)) {
            Turning();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Debug.Log("PLEasE");
            transform.position = new Vector3(molecule.transform.position.x,molecule.transform.position.y+1,molecule.transform.position.z-zoom);
            transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            Debug.Log("KILL");
            transform.position = new Vector3(molecule.transform.position.x+zoom,molecule.transform.position.y+1,molecule.transform.position.z);
            transform.Rotate(90.0f, 90.0f, 0.0f, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            Debug.Log("HeLp");
            transform.position = new Vector3(molecule.transform.position.x+zoom,molecule.transform.position.y+1,molecule.transform.position.z);
            transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            Debug.Log("AHHGHHAh");
            transform.position = new Vector3(molecule.transform.position.x,molecule.transform.position.y+1,molecule.transform.position.z+zoom);
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
        }
        zoom -= (Input.mouseScrollDelta.y * 1);
        
        
    }

    void Turning() {
        float xChange = Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        float yChange = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;
        
        yRotation += yChange;
        xRotation -= xChange;
        molecule.transform.localEulerAngles = (Vector3.right * yRotation) + (Vector3.up * xRotation);
    }
}
