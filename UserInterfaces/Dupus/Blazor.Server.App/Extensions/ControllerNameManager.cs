namespace Dupus.UI.Extensions
{
    public class ControllerNameManager
    {

        private static ControllerNameManager instance = null;
        public static ControllerNameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ControllerNameManager();
                }
                return instance;
            }
        }
        public ControllerNameManager() { }


        public string GetControllerName(string controllerName)
        {
            if (controllerName.Contains("Controller"))
            {
                return controllerName.Replace("Controller", "");
            }
            return controllerName;
        }
    }
}
