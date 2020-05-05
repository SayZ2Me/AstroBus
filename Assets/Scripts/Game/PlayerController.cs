using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Camera cam;
    [SerializeField]
    Rigidbody Rig;
    public float Pos;
    Transform Bus;
    float PosDiff,Damage;

    void Start()
    {
        Pos = 0;
        Rig = gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody;
        Bus = gameObject.GetComponent(typeof(Transform)) as Transform;
        PlayerPrefs.SetInt("Damage", 1);
        Damage = PlayerPrefs.GetInt("Damage");
    }
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            Ray ray = cam.ScreenPointToRay(touch.position);
            RaycastHit hit;

            Debug.DrawRay(cam.ScreenToWorldPoint(touch.position), Vector3.forward*1000f,Color.cyan);

            if (Physics.Raycast(cam.ScreenToWorldPoint(touch.position),Vector3.forward*1000f, out hit))
            {

                GameObject obj = hit.transform.gameObject;
                if (obj.tag == "Asteroid" && touch.phase == TouchPhase.Began)
                {
                    obj.SendMessage("ReceiveDamage",Damage);
                }

            }
        }

        if (Pos < -240)
            Pos = -240;

        if (Pos > 240)
            Pos = 240;

        Rig.velocity = new Vector3((Pos - transform.position.x) * 2 + Pos * Time.fixedDeltaTime, -200,0);
        PosDiff = Pos - transform.position.x;
        Bus.transform.localRotation = Quaternion.Euler(0, 0, -PosDiff/5);
    }
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Asteroid")
        {
            if (PosDiff > 0)
            {
                Pos = Bus.transform.position.x-20;
            }
            else
            {
                Pos = Bus.transform.position.x+20;
            }
        }
    }
}
