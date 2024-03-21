using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float _yAngle = 0.0f;
    // Update is called once per frame
    void Update()
    {
        _yAngle += Time.deltaTime * 100.0f;
        //transform.eulerAngles = new Vector3(0.0f,_yAngle,0.0f);
        //transform.Rotate(new Vector3(0.0f,Time.deltaTime * 100.0f,0.0f));
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward),0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);


        }
        //transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        }
        //transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        }
        //transform.Translate(Vector3.right * Time.deltaTime * _speed);
        //transform 
    }
}
