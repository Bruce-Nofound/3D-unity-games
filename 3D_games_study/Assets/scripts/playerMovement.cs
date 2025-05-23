using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject CameraDiraction;
    public Animator anim;
    public float rotationSpeed = 10f;
    public Dictionary<string, string> NinjiaAttack;
    public string mudra;
    void Start()
    {
        CameraDiraction = GameObject.FindWithTag("MainCamera");
        anim = GetComponent<Animator>();
        NinjiaAttack = new Dictionary<string, string>()
        {
            {"","水龙弹"}
        };
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
        if (Input.GetKey(KeyCode.W))
        {
            WaitForSeconds(0.1f);
            while (transform.eulerAngles.y != CameraDiraction.transform.eulerAngles.y)
            {
                float newY = Mathf.LerpAngle(transform.eulerAngles.y, CameraDiraction.transform.eulerAngles.y, rotationSpeed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0f, newY, 0f);
                Debug.Log(CameraDiraction.transform.rotation);
                WaitForSeconds(Time.deltaTime);
            }
        }
    }
    public void 结印()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            mudra = "";
            while (Input.GetKeyDown(KeyCode.Q)==false)
            {
                if (Input.GetKey(KeyCode.Alpha1))
                {
                    mudra = mudra + "子";
                    Debug.Log("子");
                }
                if (Input.GetKey(KeyCode.I))
                {
                    mudra = mudra + "丑";
                }
                if (Input.GetKey(KeyCode.O))
                {
                    mudra = mudra + "寅";
                }
                if (Input.GetKey(KeyCode.P))
                {
                    mudra = mudra + "卯";
                }
                if (Input.GetKey(KeyCode.Semicolon))
                {
                    mudra = mudra + "丑";
                }
            }
            anim.SetTrigger("");
        }
    }
}
