using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    private CharacterController boyController;
    public float Speed;

    void Start()
    {
        boyController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        boyController.Move(move * Time.deltaTime * Speed);
    }
}
