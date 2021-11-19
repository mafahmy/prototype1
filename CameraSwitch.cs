using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
     Camera m_Maincamera;
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {
        m_Maincamera = Camera.main;
        m_Maincamera.enabled = true;
        camera2.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.C) )

        {
           if (m_Maincamera.enabled)
            {
                camera2.enabled = true;

                m_Maincamera.enabled = false;
            }
           else if (!m_Maincamera.enabled)
            {
                camera2.enabled = false;

                m_Maincamera.enabled = true;
            }
           
            
        }
        
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
            
              
        }*/
            

        
            
        
            

        

        
        
    }
}
