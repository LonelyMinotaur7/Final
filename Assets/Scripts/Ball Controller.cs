using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{

    bool Xbool = true;
    bool Ybool;

    public GameObject player;

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        if (Xbool == true) { Xbool = false;
            Ybool = true;
            Debug.Log(Xbool);
            Debug.Log(Ybool);
        }

        else { Ybool = false;
            Xbool = true;
            Debug.Log(Xbool);
            Debug.Log(Ybool);
        }

        

    
    }

    private void FixedUpdate()
    {
        if (Xbool == true)
        {
            player.transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Xbool == false)
        {
            player.transform.position += new Vector3(0, 0, 0.1f);
        }
    }
    
}
