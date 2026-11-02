
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [Header("移動先のテレポーター")]
    public Transform target;

    private bool isUsed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isUsed || !other.CompareTag("Player"))
            return;

        if (target == null)
            return;

        isUsed = true;

        Debug.Log("テレポーターで移動");

        other.transform.position = target.position;

        isUsed = false;
    }
}
