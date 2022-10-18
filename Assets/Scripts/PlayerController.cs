using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    private float playerXrange = 20;
    private Vector3 offset = new Vector3(0, 2, 3);
    public float speed = 10;
    public GameObject bottlePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -playerXrange) {
            transform.position = new Vector3(-playerXrange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > playerXrange) {
            transform.position = new Vector3(playerXrange, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bottlePrefab, transform.position + offset, bottlePrefab.transform.rotation);
        }
        
    }
}
