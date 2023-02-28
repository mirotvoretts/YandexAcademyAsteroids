namespace Asteroids.Model
{
    public class ShipSurvivability
    {
        private static ShipSurvivability _instance;
        
        public uint Health { get; set; }

        private ShipSurvivability()
        {
            SetFieldsToDeffaults();
        }
        
        public static ShipSurvivability GetInstance()
        {
            if (_instance == null)
                _instance = new ShipSurvivability();
            
            return _instance;
        }

        public void SetFieldsToDeffaults()
        {
            Health = Config.ShipHealth;
        }
    }
}
