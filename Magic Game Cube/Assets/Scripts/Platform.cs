using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Platform : MonoBehaviour
{
    int valueToSend = 9;

    private void Start()
    {
        string stringFromOutside = FindObjectOfType<Cube>().PrintingFromOutside(valueToSend);
        Debug.Log(stringFromOutside);
    }

    private void Update()
    {

    }
}