namespace VRTK.Examples
{
    using UnityEngine;

    public class InteractableWhirlyGig : MonoBehaviour
    {
        public VRTK_InteractableObject linkedObject;
        public float spinSpeed = 360f;
		public float rotationLimit = 180;

        public Transform spinner;
        protected bool spinning;

        protected virtual void OnEnable()
        {
            spinning = false;
            linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed += InteractableObjectUsed;
                linkedObject.InteractableObjectUnused += InteractableObjectUnused;
            }
            if (spinner == null)
            {
                spinner = transform.Find("Capsule");
            }
           
        }

        protected virtual void OnDisable()
        {
            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
                linkedObject.InteractableObjectUnused -= InteractableObjectUnused;
            }
        }

        protected virtual void Update()
        {
            if (spinning)
            {
                spinner.transform.Rotate(new Vector3(0f, spinSpeed * Time.deltaTime, 0f));
            }
        }

        protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
        {
            spinning = true;
        }

        protected virtual void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
        {
            spinning = false;
        }
    }
}