namespace TopPoorestCountries.Models;

public class Country
{
    public int Rank { get; set; }
    
    // Tên tiếng Anh gốc
    public string EnglishName { get; set; } = string.Empty;
    
    // Tên tiếng Việt
    public string VietnameseName { get; set; } = string.Empty;
    
    // Yêu cầu: Tên quốc gia có thêm tên tiếng Việt trong ngoặc đơn
    // Ví dụ: "South Sudan (Nam Sudan)"
    public string FormattedName => EnglishName + " (" + VietnameseName + ")";
    
    public string Code { get; set; } = string.Empty;
    public string FlagEmoji { get; set; } = string.Empty;
    
    // GDP bình quân đầu người theo sức mua tương đương (PPP, USD)
    public double GdpPppPerCapita { get; set; }
    public string FormattedGdp => "$" + GdpPppPerCapita.ToString("N0");
    
    // Cột Thể chế chính trị theo yêu cầu
    public string PoliticalSystem { get; set; } = string.Empty;
    public string PoliticalSystemDetails { get; set; } = string.Empty;
    public string RulingPartyOrLeader { get; set; } = string.Empty;
    
    public string Capital { get; set; } = string.Empty;
    public long Population { get; set; }
    public string FormattedPopulation => Population.ToString("N0");
    public string Continent { get; set; } = string.Empty;
    
    public string[] PrimaryCauses { get; set; } = [];
    public string HdiCategory { get; set; } = string.Empty;
    public string EconomicHighlights { get; set; } = string.Empty;
}