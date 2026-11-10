using System.Collections.Generic;
using TopPoorestCountries.Models;

namespace TopPoorestCountries.Services;

public class CountryService
{
    public static List<Country> GetTopPoorestCountries()
    {
        return new List<Country>
        {
            new Country
            {
                Rank = 1,
                EnglishName = "South Sudan",
                VietnameseName = "Nam Sudan",
                Code = "SS",
                FlagEmoji = "🇸🇸",
                GdpPppPerCapita = 455,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Tập trung quyền lực vào Tổng thống; nội chiến kéo dài và chia sẻ quyền lực mong manh.",
                RulingPartyOrLeader = "Salva Kiir Mayardit",
                Capital = "Juba",
                Population = 11090000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Nội chiến sắc tộc", "Lũ lụt biến đổi khí hậu", "Phụ thuộc 98% vào dầu thô"]
            },
            new Country
            {
                Rank = 2,
                EnglishName = "Burundi",
                VietnameseName = "Burundi",
                Code = "BI",
                FlagEmoji = "🇧🇮",
                GdpPppPerCapita = 916,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Tổng thống nắm quyền hành pháp tối cao; nông nghiệp tự cấp tự túc chiếm 80%.",
                RulingPartyOrLeader = "Évariste Ndayishimiye",
                Capital = "Gitega",
                Population = 13240000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Mật độ dân số quá đông", "Thiếu đất canh tác", "Thiếu điện năng và hạ tầng"]
            },
            new Country
            {
                Rank = 3,
                EnglishName = "Central African Republic",
                VietnameseName = "Cộng hòa Trung Phi",
                Code = "CF",
                FlagEmoji = "🇨🇫",
                GdpPppPerCapita = 1123,
                PoliticalSystem = "Cộng hòa bán tổng thống",
                PoliticalSystemDetails = "Chính quyền kiểm soát thủ đô, vùng ngoại vi nhiều nhóm vũ trang kiểm soát.",
                RulingPartyOrLeader = "Faustin-Archange Touadéra",
                Capital = "Bangui",
                Population = 5740000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Bạo lực phe phái phiến quân", "Khai thác tài nguyên lậu", "Y tế kiệt quệ"]
            },
            new Country
            {
                Rank = 4,
                EnglishName = "Democratic Republic of the Congo",
                VietnameseName = "Cộng hòa Dân chủ Congo",
                Code = "CD",
                FlagEmoji = "🇨🇩",
                GdpPppPerCapita = 1552,
                PoliticalSystem = "Cộng hòa bán tổng thống",
                PoliticalSystemDetails = "Chiến tranh khoáng sản miền Đông (coban, coltan) khiến dân thường chịu nghèo khổ cùng cực.",
                RulingPartyOrLeader = "Félix Tshisekedi",
                Capital = "Kinshasa",
                Population = 102260000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Chiến tranh tài nguyên", "Tham nhũng cơ cấu", "Di cư nội địa khổng lồ"]
            },
            new Country
            {
                Rank = 5,
                EnglishName = "Mozambique",
                VietnameseName = "Mozambique",
                Code = "MZ",
                FlagEmoji = "🇲🇿",
                GdpPppPerCapita = 1649,
                PoliticalSystem = "Cộng hòa bán tổng thống",
                PoliticalSystemDetails = "Đảng FRELIMO cầm quyền lâu dài; nổi dậy tại Cabo Delgado ảnh hưởng dự án khí đốt.",
                RulingPartyOrLeader = "Daniel Chapo",
                Capital = "Maputo",
                Population = 33890000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Bão lũ nhiệt đới liên tiếp", "Khủng bố Cabo Delgado", "Nợ công ngoại tệ cao"]
            },
            new Country
            {
                Rank = 6,
                EnglishName = "Malawi",
                VietnameseName = "Malawi",
                Code = "MW",
                FlagEmoji = "🇲🇼",
                GdpPppPerCapita = 1712,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Dân chủ đa đảng tương đối hòa bình, chịu áp lực khủng hoảng tài chính và hạn hán El Niño.",
                RulingPartyOrLeader = "Lazarus Chakwera",
                Capital = "Lilongwe",
                Population = 20930000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Hạn hán El Niño", "Phụ thuộc độc canh thuốc lá", "Mất giá đồng tiền Kwacha"]
            },
            new Country
            {
                Rank = 7,
                EnglishName = "Niger",
                VietnameseName = "Niger",
                Code = "NE",
                FlagEmoji = "🇳🇪",
                GdpPppPerCapita = 1738,
                PoliticalSystem = "Chính quyền chuyển tiếp quân sự",
                PoliticalSystemDetails = "Chính quyền quân sự CNSP lên nắm quyền sau cuộc đảo chính tháng 7/2023.",
                RulingPartyOrLeader = "Abdourahamane Tchiani",
                Capital = "Niamey",
                Population = 26200000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Đảo chính và cấm vận kinh tế", "Sa mạc hóa vùng Sahel", "Khủng bố Boko Haram"]
            },
            new Country
            {
                Rank = 8,
                EnglishName = "Chad",
                VietnameseName = "Chad",
                Code = "TD",
                FlagEmoji = "🇹🇩",
                GdpPppPerCapita = 1865,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Chính quyền chuyển giao sau khi cựu Tổng thống qua đời năm 2021; đắc cử tổng thống 2024.",
                RulingPartyOrLeader = "Mahamat Déby",
                Capital = "N'Djamena",
                Population = 18270000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Hồ Chad cạn kiệt", "Gánh nặng 1 triệu người tị nạn Sudan", "Quản trị dầu mỏ kém"]
            },
            new Country
            {
                Rank = 9,
                EnglishName = "Liberia",
                VietnameseName = "Liberia",
                Code = "LR",
                FlagEmoji = "🇱🇷",
                GdpPppPerCapita = 1882,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Cộng hòa mô phỏng hiến pháp Mỹ; chuyển giao quyền lực hòa bình năm 2024.",
                RulingPartyOrLeader = "Joseph Boakai",
                Capital = "Monrovia",
                Population = 5410000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Di chứng 14 năm nội chiến", "Dịch bệnh Ebola tàn phá", "Tham nhũng công vụ"]
            },
            new Country
            {
                Rank = 10,
                EnglishName = "Madagascar",
                VietnameseName = "Madagascar",
                Code = "MG",
                FlagEmoji = "🇲🇬",
                GdpPppPerCapita = 1979,
                PoliticalSystem = "Cộng hòa bán tổng thống",
                PoliticalSystemDetails = "Hệ thống cộng hòa bán tổng thống; khủng hoảng hiến pháp quanh các kỳ bầu cử.",
                RulingPartyOrLeader = "Andry Rajoelina",
                Capital = "Antananarivo",
                Population = 30320000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Bão nhiệt đới và hạn hán miền Nam", "Phá rừng xói mòn", "Đường sá xuống cấp"]
            },
            new Country
            {
                Rank = 11,
                EnglishName = "Yemen",
                VietnameseName = "Yemen",
                Code = "YE",
                FlagEmoji = "🇾🇪",
                GdpPppPerCapita = 2078,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Chính quyền bị chia rẽ giữa Hội đồng Lãnh đạo Tổng thống (Aden) và Houthi (Sanaa).",
                RulingPartyOrLeader = "Rashad al-Alimi",
                Capital = "Sana'a / Aden",
                Population = 34440000,
                Continent = "Châu Á",
                PrimaryCauses = ["Nội chiến tàn phá suốt thập kỷ", "Phong tỏa không hải phận", "Đồng tiền phân liệt"]
            },
            new Country
            {
                Rank = 12,
                EnglishName = "Somalia",
                VietnameseName = "Somalia",
                Code = "SO",
                FlagEmoji = "🇸🇴",
                GdpPppPerCapita = 2126,
                PoliticalSystem = "Cộng hòa liên bang nghị viện",
                PoliticalSystemDetails = "Liên bang đa bang; cơ chế đại cử tri bộ tộc; nhóm Al-Shabaab liên tục quấy rối.",
                RulingPartyOrLeader = "Hassan Sheikh Mohamud",
                Capital = "Mogadishu",
                Population = 18140000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Khủng bố Hồi giáo Al-Shabaab", "Hạn hán sừng châu Phi", "Phân rã nhà nước"]
            },
            new Country
            {
                Rank = 13,
                EnglishName = "Sierra Leone",
                VietnameseName = "Sierra Leone",
                Code = "SL",
                FlagEmoji = "🇸🇱",
                GdpPppPerCapita = 2189,
                PoliticalSystem = "Cộng hòa tổng thống",
                PoliticalSystemDetails = "Dân chủ đa đảng theo hiến pháp 1991; áp lực lớn về lạm phát thực phẩm.",
                RulingPartyOrLeader = "Julius Maada Bio",
                Capital = "Freetown",
                Population = 8790000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Di chứng chiến tranh kim cương", "Lũ quét sạt lở mùa mưa", "Mất giá đồng tiền"]
            },
            new Country
            {
                Rank = 14,
                EnglishName = "Mali",
                VietnameseName = "Mali",
                Code = "ML",
                FlagEmoji = "🇲🇱",
                GdpPppPerCapita = 2789,
                PoliticalSystem = "Chính quyền chuyển tiếp quân sự",
                PoliticalSystemDetails = "Chính quyền quân sự sau 2 lần đảo chính; thành lập Liên minh các nước Sahel (AES).",
                RulingPartyOrLeader = "Assimi Goïta",
                Capital = "Bamako",
                Population = 23290000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Xung đột vũ trang ly khai Tuareg và IS", "Hạn hán lưu vực sông Niger", "Thiếu điện"]
            },
            new Country
            {
                Rank = 15,
                EnglishName = "Burkina Faso",
                VietnameseName = "Burkina Faso",
                Code = "BF",
                FlagEmoji = "🇧🇫",
                GdpPppPerCapita = 2842,
                PoliticalSystem = "Chính quyền chuyển tiếp quân sự",
                PoliticalSystemDetails = "Đại úy Ibrahim Traoré nắm quyền từ 2022; thúc đẩy kinh tế tự lực nông nghiệp.",
                RulingPartyOrLeader = "Ibrahim Traoré",
                Capital = "Ouagadougou",
                Population = 23250000,
                Continent = "Châu Phi",
                PrimaryCauses = ["Khủng bố thánh chiến chiếm đóng", "2 triệu người mất đất", "Đứt gãy cung ứng lương thực"]
            },
            new Country
            {
                Rank = 22,
                EnglishName = "Afghanistan",
                VietnameseName = "Afghanistan",
                Code = "AF",
                FlagEmoji = "🇦🇫",
                GdpPppPerCapita = 3845,
                PoliticalSystem = "Nhà nước thần quyền",
                PoliticalSystemDetails = "Tiểu vương quốc Hồi giáo dưới luật Sharia và sự lãnh đạo của Lãnh tụ Tinh thần Emir.",
                RulingPartyOrLeader = "Hibatullah Akhundzada",
                Capital = "Kabul",
                Population = 42240000,
                Continent = "Châu Á",
                PrimaryCauses = ["Đóng băng dự trữ ngoại tệ", "Cấm phụ nữ làm việc/học tập", "Cắt đứt viện trợ quốc tế"]
            },
            new Country
            {
                Rank = 26,
                EnglishName = "Solomon Islands",
                VietnameseName = "Quần đảo Solomon",
                Code = "SB",
                FlagEmoji = "🇸🇧",
                GdpPppPerCapita = 4250,
                PoliticalSystem = "Quân chủ lập hiến nghị viện",
                PoliticalSystemDetails = "Quốc vương Charles III là nguyên thủ; Thủ tướng lãnh đạo nội các từ đa số Quốc hội.",
                RulingPartyOrLeader = "Jeremiah Manele",
                Capital = "Honiara",
                Population = 740000,
                Continent = "Châu Đại Dương",
                PrimaryCauses = ["Hải đảo phân tán 900 hòn đảo", "Biến đổi khí hậu nước biển dâng", "Cạn kiệt lâm sản"]
            },
            new Country
            {
                Rank = 32,
                EnglishName = "Haiti",
                VietnameseName = "Haiti",
                Code = "HT",
                FlagEmoji = "🇭🇹",
                GdpPppPerCapita = 4720,
                PoliticalSystem = "Cộng hòa bán tổng thống",
                PoliticalSystemDetails = "Hội đồng chuyển tiếp điều hành trong bối cảnh các băng nhóm tội phạm vũ trang kiểm soát thủ đô.",
                RulingPartyOrLeader = "Hội đồng Chuyển tiếp CPT",
                Capital = "Port-au-Prince",
                Population = 11720000,
                Continent = "Châu Mỹ",
                PrimaryCauses = ["Băng đảng tội phạm tê liệt kinh tế", "Động đất bão lũ liên tiếp", "Khủng hoảng thể chế"]
            }
        };
    }
}