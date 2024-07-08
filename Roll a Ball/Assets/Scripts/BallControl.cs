using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public int hiz;
    public int skor;
    public int crystals;
    public Text pointText;
    public Text finishText;
    public Button exitButton;


    public Rigidbody fizik;
    
    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float dikey = Input.GetAxisRaw("Vertical");
        float yatay = Input.GetAxisRaw("Horizontal");

        Vector3 vektor = new Vector3 ( yatay , 0 , dikey );

        fizik.AddForce(vektor * hiz);

           
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        skor++;
        pointText.text = "Point : " + skor;

        if (skor == crystals)
        {
            finishText.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
        }

    }
}
