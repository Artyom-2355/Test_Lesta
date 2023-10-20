using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public int hp;
    public Text hpT;
    public int hpDmg;
    public int Dmg;
    bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        hpT.text = hp.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy body")
        {
          Damag();
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Blast"))
        {
            StartCoroutine(Blast(0f, 1f));

        }

        IEnumerator Blast(float time1, float time2)
        {
            yield return new WaitForSeconds(time1);
            collision.gameObject.GetComponent<MeshRenderer>().material.color = new Color(241, 76, 0, 1);

            yield return new WaitForSeconds(time2);
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

             Damag();

        }

    }


    void Die()
    {
        dead = true;
        SceneManager.LoadScene(3);
       // Invoke(nameof(ReloadLevel), 1.3f);
    }

    void Damag()
    {
        hp = hp - hpDmg;
        hpT.text = hp.ToString();
        if(hp <= 0)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            hpT.text = "0";
            Die();
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }
}
