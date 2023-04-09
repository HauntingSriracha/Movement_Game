using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SpeedOg;
    public float SpeedCurrent;
    public float BackSpeed;
    public float UpSpeed;
    public float DownSpeed;
    public float HorizontalInput;
    public float VerticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

        // Update is called once per frame
        void Update()
        {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        SpeedCurrent = SpeedOg;

        if (HorizontalInput < 0.00f)
            SpeedCurrent = BackSpeed;

        if (VerticalInput > 0.00f & HorizontalInput > 0.00f)
            SpeedCurrent = UpSpeed;
        
        if (VerticalInput < 0.00f)
            SpeedCurrent = DownSpeed;
       
      


        transform.Translate(Vector3.right * Time.deltaTime * HorizontalInput * SpeedCurrent);

    }
}
