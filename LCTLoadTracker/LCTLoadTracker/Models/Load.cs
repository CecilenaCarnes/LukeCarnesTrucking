namespace LCTLoadTracker.Models
{
    public class Load
    {
        public Guid LoadID { get; set; } = Guid.NewGuid();
        public DriverList? Driver { get; set; }
        public DateTime? Date {get; set;}
        public int?  LoadCount { get; set;}   //Enter 1 for each full load so that it can be calculated
        public int?  BOL { get; set;}    
        public TerminalList? TerminalLoaded { get; set;} 
        public CustomerList? CustomerUnloaded { get; set;}

        public ProductList Product1 { get; set;}
        public int? Gallons1 { get; set;}

        public ProductList? Product2 { get; set;}
        public string? Gallons2 {get; set;}
        public ProductList? Product3 { get; set;}
        public string? Gallons3 { get; set;}
        public ProductList? Product4 { get; set;}
        public string? Gallons4 { get; set;}
        public ProductList? Product5 { get; set;}
        public string? Gallons5 { get; set;}
        public string? Split     { get; set;}
        public string? Pump { get; set;} 

        public string? Comment { get; set;}  


    

        //create a method to return a list of product
       
    }
    public enum ProductList
    {
        Gas,
        Premium,
        Plus,
        Diesel,
        Kerosene,
        Transmix,
        Ethanol,
        E85,
        BioDiesel,
        FattyAcids,
        LubeOil


    }

    public enum DriverList
    {

        Matt,
        John,
        Luke
        //can I pull drivers from the Person table in a list
    }

    public enum TerminalList
    {
        KnoxvilleShell,
        KnoxvilleCummins,
        KnoxvilleMag1,
        KnoxvilleMag2,
        LexingtonShell,
        LexingtonVelaro

    }

    public enum CustomerList
    {
        AllenShell,
        AllenBros,
        BandLMarathon,
        BarnesMill,
        BellLane,
        BellPlace,
        BurkevilleShell,
        Burnside,
        ChillsShell,
        Citation,
        ClaysMill,
        CornerShell,
        CornerExpress,
        CrocketTrail,
        CrossRoadsIGA,
        CumberlandFoodMart,
        DandDShell,
        DeliMartShell,
        DocsColumbia,
        EasyStop,
        EliFoodMart,
        EvermanGulf,
        Everts,
        EzMart,
        FastwayFuelMart,
        FortLogan,
        GeorgeTownRdDeliMart,
        Hamburg,
        Hamptons,
        Henderlite,
        HorsePark,
        Huntertown,
        IansMarketSomerset,
        IGAShell,
        Jackos1Marathon,
        Kingston,
        LancasterSunoco,
        Leaches,
        LittleMart,
        LondonFoodMart,
        LondonSunoco,
        ManchisMarathon,
        MandMMarathon,
        MainStop,
        MerrickShell,
        Midtown,
        Mikes,
        MtSterlingShell,
        Moberly,
        NewTown,
        NelsonValleySunoco,
        NineFourteenExpress,
        ParisShell,
        Payless,
        PineKnotSunoco,
        QuickMart,
        RediMartLebanon,
        Robs2,
        RockyTop,
        RubyMart,
        SeaShell,
        SilverCreek,
        SilverStar,
        SomersetBulk,
        South27Shell,
        StarFoodMart,
        StopAndSaveWburg,
        Sunshine,
        SuperShell,
        TownAndCountry,
        TwelveFortySevenPantrySunoco,
        TwoWayStopandGo,
        University,
        XpressMart





    }
}
