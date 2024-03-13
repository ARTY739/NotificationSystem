using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Transform NotificationWindow;
    public NotificationSO notification;
    public NotificationSO notification1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NotificationsManager.Instance.SendNotification(notification, NotificationWindow);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            NotificationsManager.Instance.SendNotification(notification1, NotificationWindow);
        }
    }
}
