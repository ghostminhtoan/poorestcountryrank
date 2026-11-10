using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TopPoorestCountries.Models;
using TopPoorestCountries.Services;

namespace TopPoorestCountries.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly List<Country> _allCountries;

    [ObservableProperty]
    private string _searchText = string.Empty;

    [ObservableProperty]
    private string _selectedPoliticalSystem = "Tất cả";

    [ObservableProperty]
    private Country? _selectedCountry;

    [ObservableProperty]
    private bool _isDetailVisible;

    [ObservableProperty]
    private int _totalCountriesCount;

    [ObservableProperty]
    private double _averageGdp;

    public ObservableCollection<Country> FilteredCountries { get; } = new();

    public ObservableCollection<string> PoliticalSystems { get; } = new()
    {
        "Tất cả",
        "Cộng hòa tổng thống",
        "Cộng hòa bán tổng thống",
        "Chính quyền chuyển tiếp quân sự",
        "Cộng hòa liên bang nghị viện",
        "Quân chủ lập hiến nghị viện",
        "Nhà nước thần quyền",
        "Cộng hòa độc đảng"
    };

    public MainViewModel()
    {
        _allCountries = CountryService.GetTopPoorestCountries();
        TotalCountriesCount = _allCountries.Count;
        AverageGdp = _allCountries.Average(c => c.GdpPppPerCapita);
        
        ApplyFilter();
        
        if (FilteredCountries.Count > 0)
        {
            SelectedCountry = FilteredCountries[0];
        }
    }

    partial void OnSearchTextChanged(string value) => ApplyFilter();
    partial void OnSelectedPoliticalSystemChanged(string value) => ApplyFilter();

    [RelayCommand]
    private void SelectCountry(Country? country)
    {
        if (country != null)
        {
            SelectedCountry = country;
            IsDetailVisible = true;
        }
    }

    [RelayCommand]
    private void CloseDetail()
    {
        IsDetailVisible = false;
    }

    [RelayCommand]
    private void ResetFilter()
    {
        SearchText = string.Empty;
        SelectedPoliticalSystem = "Tất cả";
    }

    private void ApplyFilter()
    {
        var query = _allCountries.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(SearchText))
        {
            var term = SearchText.Trim().ToLowerInvariant();
            query = query.Where(c => 
                c.FormattedName.ToLowerInvariant().Contains(term) ||
                c.PoliticalSystem.ToLowerInvariant().Contains(term) ||
                c.Capital.ToLowerInvariant().Contains(term) ||
                c.Continent.ToLowerInvariant().Contains(term));
        }

        if (SelectedPoliticalSystem != "Tất cả")
        {
            query = query.Where(c => c.PoliticalSystem.Equals(SelectedPoliticalSystem, StringComparison.OrdinalIgnoreCase));
        }

        FilteredCountries.Clear();
        foreach (var country in query.OrderBy(c => c.Rank))
        {
            FilteredCountries.Add(country);
        }
    }
}