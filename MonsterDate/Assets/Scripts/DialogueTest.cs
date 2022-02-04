using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DialogueTest : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnMouseOver()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
