using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool openInwards;
    [SerializeField] private float openingSpeed;

    private bool isOpen;
    private float targetAngle;

    // Start is called before the first frame update
    void Start()
    {
        // Interact();
    }

    // Update is called once per frame
    void Update()
    {
        // params: start from, go to, the speed
        Quaternion smoothRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, targetAngle, 0), openingSpeed * Time.deltaTime);
        transform.localRotation = smoothRotation;
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            if (openInwards)
            {
                targetAngle = -90.0f;
            }
            else
            {
                targetAngle = 90.0f;
            }
        }
        else
        {
            targetAngle = 0;
        }
    }
}
