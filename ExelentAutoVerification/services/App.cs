namespace ExelentAutoVerification.services
{
    public class App
    {
        public CurrentAPP currentApp;

        public enum CurrentAPP
        {
            DesktopApp = 0,
            Exelent = 1,
            HourBoost = 2,
        }

        public App(string procName)
        {
            currentApp = Resolve(procName.ToLower())/*CurrentAPP.Exelent*/;
        }

        private static CurrentAPP Resolve(string procName)
        {
            if (procName.Contains("hourboost")) return CurrentAPP.HourBoost;
            if (procName.Contains("autoverification")) return CurrentAPP.DesktopApp;
            return CurrentAPP.Exelent;
        }

        public override string ToString()
        {
            switch (currentApp)
            {
                case CurrentAPP.DesktopApp: return "DesktopApp";
                case CurrentAPP.Exelent: return "Exelent";
                case CurrentAPP.HourBoost: return "HourBoost";
                default: return "Exelent";
            }
        }
    }
}