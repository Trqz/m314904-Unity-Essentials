using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField]
    private float carSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 100)
            transform.position = new Vector3(-100, transform.position.y, transform.position.z);

        transform.Translate(Vector3.right * carSpeed * Time.deltaTime);
    }
}
