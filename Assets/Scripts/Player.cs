using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private Transform _cam;

    private CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        Vector3 Movement = _cam.transform.right * Horizontal + _cam.transform.forward * Vertical;
        Movement.y = 0f;


        _controller.Move(Movement);

        if (Movement.magnitude != 0f)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * _cam.GetComponent<Camera>().sensivity * Time.deltaTime);


            Quaternion CamRotation = _cam.rotation;
            CamRotation.x = 0f;
            CamRotation.z = 0f;

            transform.rotation = Quaternion.Lerp(transform.rotation, CamRotation, 0.1f);

        } 
    }
}
