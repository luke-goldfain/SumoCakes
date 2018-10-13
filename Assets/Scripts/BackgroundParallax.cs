using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//while both the foreground labled 'floor' and the 'background' have this script attaached to it,
//only the background can use parallax, the foreground 'floor' can only scroll


public class BackgroundParallax : MonoBehaviour
{      //toggle scrolling/parallax in unity window
    public bool isScrolling,hasParallax;
    //fit size to finialized background (vector3 in unity window)
    public float backgroundSize;
    //slider for speed in unity
    public float parallaxSpeed;

    //most of these are used for scrolling
    private Transform cameraTransform;
    private Transform[] layers;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;
    private float lastCameraX;

    private void Start()
    {
        //updating of the camera in relation to the background
        cameraTransform = Camera.main.transform;
        lastCameraX = cameraTransform.position.x;
        cameraTransform = Camera.main.transform;
        //for scrolling (keeps the background cycling.)
        layers = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            layers[i] = transform.GetChild(i);
        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }
    private void Update()
    {
        //when the parralax box is checked
        if (hasParallax)
        {
            float deltaX = cameraTransform.position.x - lastCameraX;
            transform.position += Vector3.right * (deltaX * parallaxSpeed);
        }
        lastCameraX = cameraTransform.position.x;
        //when scrolling is checked
        if (isScrolling)
        {
            if (cameraTransform.position.x < (layers[leftIndex].transform.position.x + viewZone))
                ScrollLeft();
            if (cameraTransform.position.x > (layers[rightIndex].transform.position.x - viewZone))
                ScrollRight();
        }
    }
    //update while moving left
        private void ScrollLeft()
    {
        int lastRight = rightIndex;
        layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize);
        leftIndex = rightIndex;
        rightIndex--;
        if (rightIndex < 0)
            rightIndex = layers.Length - 1;
    }

    //updates while moving right
    private void ScrollRight()
    {
        int lastLeft = leftIndex;
        layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
        rightIndex = leftIndex;
        leftIndex++;
        if (leftIndex == layers.Length)
            leftIndex = 0;
    }
}