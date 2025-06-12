using System.Collections.Generic;
using UnityEngine;

public class attacks : MonoBehaviour
{
    public string mudra;
    public Animator anim;
    public Dictionary<string, string> NinjiaAttack;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        结印();
    }
    public void 结印()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            mudra = "";
            while (Input.GetKeyDown(KeyCode.Q) == false)
            {
                if (Input.GetKey(KeyCode.U))
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
                if (Input.GetKey(KeyCode.J))
                {
                    mudra = mudra + "丑";
                }
                if (Input.GetKey(KeyCode.K))
                {
                    mudra = mudra + "丑";
                }
                if (Input.GetKey(KeyCode.L))
                {
                    mudra = mudra + "丑";
                }
            }
            anim.SetTrigger("");
        }
    }
}

