using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;
    public Transform orientation;
    public Transform player;
    public Transform playerobj;
    public float rotationSpeed = 10f;
    public Dictionary<string, string> NinjiaAttack;
    public string mudra;
    public float moveSpeed;
    public float MaxSpeed;
    public Vector3 MovementInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        NinjiaAttack = new Dictionary<string, string>()
        {
            {"","水龙弹"}
        };
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        FollowCameraDiraction();
        
    }
    IEnumerator WaitForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds); 
    }
    public void FollowCameraDiraction()
    {
        Vector3 veiwDiraction = player.position;
        orientation.forward = veiwDiraction.normalized;
        float Xinput = Input.GetAxis("Horizontal");
        float Zinput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * Zinput + orientation.right*Xinput;
        if (inputDir != Vector3.zero)
        {
            player.forward = Vector3.Slerp(transform.forward, inputDir, rotationSpeed * Time.deltaTime);
        }

    }
}
