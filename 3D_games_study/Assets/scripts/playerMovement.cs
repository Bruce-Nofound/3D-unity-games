using System.Collections;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject CameraDiraction;
    public float rotationSpeed = 10f;
    void Start()
    {
        CameraDiraction = GetComponent<GameObject>();
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
        WaitForSeconds(0.1f);
        transform.rotation = Quaternion.Euler(0f, CameraDiraction.transform.eulerAngles.y, 0f);
        Debug.Log(CameraDiraction.transform.rotation);
        
    }

}
