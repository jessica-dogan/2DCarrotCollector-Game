using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;
    float hInput, vInput;
    int score = 0;
    public GameObject winText;
    public int winScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //joystick
    private void FixedUpdate()
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;
        transform.Translate(hInput, vInput, 0);
    }
//check if  palyer colided with carrot
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Carrot")
        {
            //when player touches carrot
            score++;
            Destroy(collision.gameObject);
            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
