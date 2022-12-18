using DG.Tweening;
using System.Collections;
using UnityEngine;


public class GateController : MonoBehaviour
{
    [SerializeField] GameObject kapi;
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("player"))
            {
                kapi.transform.DORotate(new Vector3(0, -45, 0), 0.5f, RotateMode.WorldAxisAdd);
                GameManager.manager.AddMoney(other.GetComponent<Balls>().Income);
                StopAllCoroutines();
                StartCoroutine(ReturnGate());
            }


        }

        IEnumerator ReturnGate()
        {
            yield return new WaitForSeconds(0.5f);
            kapi.transform.DORotate(new Vector3(0, 0, 0), 0.5f, RotateMode.Fast);
        }
}
