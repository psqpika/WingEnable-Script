using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.Linq;

public class WingsEnable : MonoBehaviour
{

    public GameObject RightWing;
    public GameObject LeftWing;
    private InputDevice LeftControllerDevice;
    private InputDevice RightControllerDevice;
    private Vector3 LeftControllerVelocity;
    private Vector3 RightControllerVelocity;
    public Transform xrCamera;
    public bool disableFlapping = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftControllerDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        RightControllerDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        LeftControllerDevice.TryGetFeatureValue(CommonUsages.deviceVelocity, out LeftControllerVelocity);
        RightControllerDevice.TryGetFeatureValue(CommonUsages.deviceVelocity, out RightControllerVelocity);
        bool primaryButtonDown = false;
        RightControllerDevice.TryGetFeatureValue(CommonUsages.primaryButton, out primaryButtonDown);
        if (disableFlapping == false)
            if (primaryButtonDown)
            {


                RightWing.SetActive(true);
                LeftWing.SetActive(true);


            }
            else if (primaryButtonDown == false)
            {
                RightWing.SetActive(false);
                LeftWing.SetActive(false);
            }
    


    }
}
