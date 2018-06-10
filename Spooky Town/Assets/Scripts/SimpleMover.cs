using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    public float WalkSpeed;
    public float CrawlSpeed;

    [SerializeField] public bool Crawling = false;
    [SerializeField] public Vector3 CCamPos;

    //Camera
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;
    private float rotY = 0.0f; // rotation around the right/x axis
    //!Camera
    private int points;
    private int maxPoints = 7;


    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
    }

    void Update()
    {
        if (points <= maxPoints)
        {
            float moveHorizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
            float moveVertical = Input.GetAxis("Vertical") * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                CamSwitch();
                Crawling = !Crawling;
                Debug.Log(Crawling);
            }

            if (Crawling)
            {
                GetComponent<Rigidbody>().transform.Translate(moveHorizontal * WalkSpeed, 0, moveVertical * WalkSpeed);
            }
            else
            {
                GetComponent<Rigidbody>().transform
                    .Translate(moveHorizontal * CrawlSpeed, 0, moveVertical * CrawlSpeed);
            }


            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = -Input.GetAxis("Mouse Y");

            //rotY += mouseX * mouseSensitivity * Time.deltaTime;
            rotY += mouseX * mouseSensitivity * Time.deltaTime;

            //rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

            Quaternion localRotation = Quaternion.Euler(0.0f, rotY, 0.0f);
            transform.rotation = localRotation;
        }
    }

    public void Points(int i)
    {
        points += i;
    }

    void CamSwitch()
    {
        Vector3 CurentPos = GetComponentInChildren<Transform>().position;

        if (Crawling)
        {
            Vector3 newPos = new Vector3(CurentPos.x, CurentPos.y - 1f, CurentPos.z);
            CCamPos = newPos;
        }
        else
        {
            Vector3 newPos = new Vector3(CurentPos.x, CurentPos.y + 1f, CurentPos.z);
            CCamPos = newPos;
        }
    }
}