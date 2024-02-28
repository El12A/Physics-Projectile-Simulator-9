using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    private Vector3 initialPosition = new Vector3(-258F, 4.47f, -35.24f);
    [SerializeField] TMP_Text ErrorMessageText;
    public void OnDisplacementChange()
    {
        if (ErrorMessageText.text == "Successfull Input")
        {
            transform.position = initialPosition + GameControl.control.displacement;
        }

    }
}
