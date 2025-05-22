using System.Collections;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Transform CameraDiraction;
    public float rotationSpeed = 10f;
    void Start()
    {
        CameraDiraction = GetComponent<Transform>();
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
        Vector3 currentRotation = transform.eulerAngles;
        float newY = Mathf.LerpAngle(currentRotation.y, CameraDiraction.eulerAngles.y, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, newY, 0f);
        Debug.Log(CameraDiraction.eulerAngles.y);
        
    }

}
