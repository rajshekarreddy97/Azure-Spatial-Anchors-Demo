using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using System.Runtime.InteropServices;
#if UNITY_ANDROID || UNITY_IOS
using UnityEngine.XR.ARFoundation;
using System.IO;
#endif
#if UNITY_IOS
using Microsoft.Azure.SpatialAnchors.Unity.IOS;
#endif
#if UNITY_ANDROID
using Microsoft.Azure.SpatialAnchors.Unity.Android;
#endif
#if UNITY_WSA || WINDOWS_UWP
using UnityEngine.XR.WSA;
#endif

namespace Microsoft.Azure.SpatialAnchors.Unity
{
    public class SpatialAnchorSession : MonoBehaviour
    {
        private CloudSpatialAnchorSession cloudSession;

        private void Awake() 
        {
            this.cloudSession = new CloudSpatialAnchorSession();
            this.cloudSession.Configuration.AccountKey = @"1I6I4WyASzl79MLFWDPuBXeBPWm9xbPh4qiY4WLYj70=";
            
        }
        
    }
}


