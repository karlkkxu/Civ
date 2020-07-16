using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    private Player[] players;
    private int turnCount;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        this.cam = Camera.main;
        Debug.Log("GameLogic aloitettu");
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    //TODO tämä toimivaksi ekana
    private void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //GetActivePlayer
            //GetNearestLocation
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Debug.Log(Input.mousePosition.ToString());
            if (Physics.Raycast(ray, out hit, 100))
                if (hit.transform != null)
                {
                    Debug.Log("Osui");
                }
        }
    }
}
