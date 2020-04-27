using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAreaScript : MonoBehaviour
{

    // эта штука удаляет астероиды при выходе их из GameArea
    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Asteroid") {
            Destroy(other.gameObject);
        }
    }
}
