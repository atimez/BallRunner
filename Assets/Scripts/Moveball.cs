using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Moveball : MonoBehaviour
{
	Rigidbody rb;
	public int ballspeed = 0;
	public int jumpspeed = 0;
	private bool istouching = false;
	private int counter = 0;
	public Text cointext;
	public AudioSource Asource;
	public AudioClip  Aclip;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        counter = 0;
        cointext.text = "COINT: " + counter;
    }

    // Update is called once per frame
    void Update()
    {
    	float Hmove = Input.GetAxis("Horizontal");

    	float Vmove = Input.GetAxis("Vertical");

    	Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

    	rb.AddForce(ballmove * ballspeed);

        if(Input.GetKey(KeyCode.Space) && istouching){
        	Vector3 balljump = new Vector3(0.0f, 6.0f, 0.0f);
        	rb.AddForce(balljump * ballspeed);
        }

        istouching = false;
    }

    private void OnCollisionStay()
    {
    	istouching = true;

    }

    private void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.CompareTag("Coinstag")) {
    		other.gameObject.SetActive(false);
    		counter++;
    		Asource.PlayOneShot(Aclip);
    		cointext.text = "COINT: " + counter;

    		if(counter == 12)
    		{
    			SceneManager.LoadScene("EndScene");
    		}
    	}	
    }

}
