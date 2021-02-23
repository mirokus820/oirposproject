using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target; //cel skupienia kamery - kulka
    public float lockonspeed=10f; //prędkość skupienia kamery na kulce
    private float yaw, pitch; //kąt obrotu kamery kolejno w poziomie i pionie
    public float speedH = 3.0f;
    public float speedV = 3.0f;
    public float rotationspeedH, rotationspeedV; //prędkość obrotu kamery kolejno w poziomie i pionie

    public Vector3 offset; //przesunięcie kamery

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset; //niech kamera podąża za kulką do żądanej pozycji kulki
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, lockonspeed * Time.deltaTime); //z prędkością dostosowaną do fps
        transform.position = smoothedPosition; //przesuń kamerę
    }

    void Update()
    {
        if (!PauseMenu.ispaused)
        {
            yaw += speedH * Input.GetAxis("Mouse X"); //okreść obrót w poziomie
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
