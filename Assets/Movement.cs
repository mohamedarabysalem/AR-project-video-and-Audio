﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using System.IO;

public class Movement : MonoBehaviour {



    public float scalingSpeed = 0.03f;
    public float rotationSpeed = 70.0f;
    public float translationSpeed = 5.0f;
    //    public GameObject Model;
    bool repeatScaleUp = false;
    bool repeatScaleDown = false;
    bool repeatRotateLeft = false;
    bool repeatRotateRight = false;
    bool repeatPositionUp = false;
    bool repeatPositionDown = false;
    bool repeatPositionLeft = false;
    bool repeatPositionRight = false;

    void Update()
    {
        if (repeatScaleUp)
        {
            ScaleUpButton();
        }

        if (repeatScaleDown)
        {
            ScaleDownButton();
        }

        if (repeatRotateRight)
        {
            RotationRightButton();
        }

        if (repeatRotateLeft)
        {
            RotationLeftButton();
        }

        if (repeatPositionUp)
        {
            PositionUpButton();
        }

        if (repeatPositionDown)
        {
            PositionDownButton();
        }

        if (repeatPositionLeft)
        {
            PositionLeftButton();
        }

        if (repeatPositionRight)
        {
            PositionRightButton();
        }

    }

    public void CloseAppButton()
    {
        Application.Quit();
    }

    public void RotationRightButton()
    {
        // transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
        GameObject.FindWithTag("house").transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        GameObject.FindWithTag("house1").transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        GameObject.FindWithTag("house2").transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }

    public void RotationLeftButton()
    {
        // transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
        GameObject.FindWithTag("house").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        GameObject.FindWithTag("house1").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        GameObject.FindWithTag("house2").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    public void RotationRightButtonRepeat()
    {
        // transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
        repeatRotateRight = true;
    }

    public void RotationLeftButtonRepeat()
    {
        // transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
        repeatRotateLeft = true;
    }

    public void ScaleUpButton()
    {
        // transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
        GameObject.FindWithTag("house").transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
        GameObject.FindWithTag("house1").transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
        GameObject.FindWithTag("house2").transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
    }

    public void ScaleUpButtonRepeat()
    {
        repeatScaleUp = true;
        Debug.Log("Up");
    }
    public void ScaleDownButtonRepeat()
    {
        repeatScaleDown = true;
        Debug.Log("Down");
    }
    public void PositionDownButtonRepeat()
    {
        repeatPositionDown = true;
    }
    public void PositionUpButtonRepeat()
    {
        repeatPositionUp = true;
    }
    public void PositionLeftButtonRepeat()
    {
        repeatPositionLeft = true;
    }
    public void PositionRightButtonRepeat()
    {
        repeatPositionRight = true;
    }

    public void ScaleUpButtonOff()
    {
        repeatScaleUp = false;
        Debug.Log("Off");
    }
    public void ScaleDownButtonOff()
    {
        repeatScaleDown = false;
        Debug.Log("Off");
    }

    public void RotateLeftButtonOff()
    {
        repeatRotateLeft = false;
        Debug.Log("Off");
    }

    public void RotateRightButtonOff()
    {
        repeatRotateRight = false;
        Debug.Log("Off");
    }
    public void PositionRightButtonOff()
    {
        repeatPositionRight = false;
        Debug.Log("Off");
    }
    public void PositionLeftButtonOff()
    {
        repeatPositionLeft = false;
        Debug.Log("Off");
    }
    public void PositionUpButtonOff()
    {
        repeatPositionUp = false;
        Debug.Log("Off");
    }
    public void PositionDownButtonOff()
    {
        repeatPositionDown = false;
        Debug.Log("Off");
    }

    public void ScaleDownButton()
    {
        // transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
        GameObject.FindWithTag("house").transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
        GameObject.FindWithTag("house1").transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
        GameObject.FindWithTag("house2").transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
    }

    public void PositionUpButton()
    {
        GameObject.FindWithTag("house").transform.Translate(0, 0, -translationSpeed * Time.deltaTime);
    }

    public void PositionDownButton()
    {

        GameObject.FindWithTag("house").transform.Translate(0, 0, translationSpeed * Time.deltaTime);
    }

    public void PositionRightButton()
    {
        GameObject.FindWithTag("house").transform.Translate(-translationSpeed * Time.deltaTime, 0, 0);
    }

    public void PositionLeftButton()
    {
        GameObject.FindWithTag("house").transform.Translate(translationSpeed * Time.deltaTime, 0, 0);  // backward
    }

    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }

    public void AnyButton()
    {
        Debug.Log("Any");
    }
}