using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public Transform respawnPoint; // äŞØÉ ÅÚÇÏÉ ÇáßÑÉ (ãËáÇğ ãßÇä ÇááÇÚÈ)

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // äØÈÚ ÇÓã ÇáÜ Tag ááÔíÁ Çááí ÏÎá ÇáãÑãì (ááÊÃßÏ)
        Debug.Log("Entered Trigger with tag: " + other.gameObject.tag);

        // äÊÍŞŞ ÅĞÇ ÇáÔíÁ ÏÎá ÇáãÑãì¡ áÇÒã íßæä Tag ÇáãÑãì "Goal"
        if (other.gameObject.CompareTag("Goal"))
        {
            Debug.Log("GOAL!");  // ÑÓÇáÉ ÊÓÌíá ÇáåÏİ

            // äæŞİ ÊÃËíÑ ÇáİíÒíÇÁ ãÄŞÊÇğ áÅÚÇÏÉ ÇáßÑÉ ÈÏæä ãÔÇßá
            rb.isKinematic = true;

            // äÑÌÚ ÇáßÑÉ áäŞØÉ ÇáÅÚÇÏÉ
            transform.position = respawnPoint.position;

            

            // äÔÛá ÇáİíÒíÇÁ ãÑÉ ËÇäíÉ
            rb.isKinematic = false;
        }
    }
}
