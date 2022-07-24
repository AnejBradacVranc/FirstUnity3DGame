using UnityEditor;

[CustomEditor(typeof(Interactable),true)]
public class InteractableEditor : Editor //Omogoèa dostop do editorja
{
    public override void OnInspectorGUI()
    {
        Interactable interactable = (Interactable)target; //Inheritamo iz editor zato imamo dostop do target. Je game object ki je trenutno izbran
        if (target.GetType() == typeof(EventOnlyInteractable)) //Èe je objekt interactable samo preko eventa
        {
            interactable.promptMessage = EditorGUILayout.TextField("Prompt Message", interactable.promptMessage);
            EditorGUILayout.HelpBox("EventOnly interactable can ONLY use UnityEvents",MessageType.Info);

            if(interactable.GetComponent<InteractionEvent>()==null) //Doda event
            {
                interactable.useEvents = true;
                interactable.gameObject.AddComponent<InteractionEvent>();
            }
        }
        else
        {
            base.OnInspectorGUI();
            if (interactable.useEvents)  //Da se ne spawna milijon eventov ampak samo en
            {
                if (interactable.GetComponent<InteractionEvent>() == null)
                    interactable.gameObject.AddComponent<InteractionEvent>();
            }
            else
            {
                if (interactable.GetComponent<InteractionEvent>() != null)
                    DestroyImmediate(interactable.GetComponent<InteractionEvent>());
            }
        }
    }
}
