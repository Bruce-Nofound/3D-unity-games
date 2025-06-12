using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public GameObject CameraTransform;
    public float rotationSpeed;
    public float movespeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
        CameraTransform = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, CameraTransform.transform.eulerAngles.y, 0), rotationSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, CameraTransform.transform.eulerAngles.y, 0), rotationSpeed * Time.deltaTime);
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }
    }
}
