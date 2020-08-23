using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OrganicButtons : MonoBehaviour
{
    //Making UI buttons be active only within their pixels allowing organic shapes to be buttons
    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }

}
