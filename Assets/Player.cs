using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Target Sphere
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        HasWon();
    }

    // Player Move
    public void Move() {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z != 1) {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z != -1) {
            transform.Translate(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -1) {
            transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != 1) {
            transform.Translate(Vector3.right);
        }
    }

    // Player Win
    public void HasWon() {
        if (transform.position == target.transform.position) {
            print("You Win!");
        }
    }
}
