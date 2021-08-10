using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggIdle : MonoBehaviour
{
    // Start is called before the first frame update
            private readonly float FullRotation = 360f;
        [SerializeField]
        private float speed = 1f;
        private float currentRotation = 0f;

        public event EventHandler FullyRotated;
        private bool IsFullRotation
        {
            get { return Mathf.Abs(currentRotation) >= FullRotation; }
        } 

    // Update is called once per frame
    void Update()
    {
        Rotate();
        RaiseEventOnFullRotation();
        ResetRotationOnFullRotation();
    }
    private void Rotate()
    {
        transform.Rotate(0, speed, 0);
        currentRotation += speed;
    }
    private void RaiseEventOnFullRotation()
    {
    if (IsFullRotation)
    {
        if (FullyRotated!=null)
        {
            FullyRotated(this, new EventArgs());
        }
    }
    }
    private void ResetRotationOnFullRotation()
    {
        if (IsFullRotation)
        {
        currentRotation -= FullRotation * Mathf.Sign(currentRotation);
        }
    }
}