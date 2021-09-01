using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    private int count;
    private Rigidbody rb;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Count: 0";
        winText.text = "";
    }
    // 物理演算の度にコールされます。
    void FixedUpdate ()
    {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical= Input.GetAxis("Vertical");
    Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Count: " + count.ToString();
            if (count >= 12) {
                winText.text = "Your Win!";
            }
        }
    }
}