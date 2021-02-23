using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode rotateUp, rotateDown, rotateLeft, rotateRight; //klawisze sterujące
    public float rotationSpeed = 15f; //prędkość obrotu
    Vector3 currentEulerAngles; //wektor o który ma zostać obrócona mapa

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Vertical"); //kąt względem osi x
        float moveZ = Input.GetAxis("Horizontal"); //kąt względem osi z

        currentEulerAngles += new Vector3(moveX, 0.0f, moveZ) * Time.deltaTime * rotationSpeed; //oblicz kąt obrotu mapy z uwzględnieniem liczby klatek na sekundę
        transform.eulerAngles = currentEulerAngles; //obróć mapę
    }

    public void ResetRotation()
    {
        currentEulerAngles = new Vector3(0, 0, 0); //zresetuj obrót mapy
    }
}
