# Top Quốc Gia Nghèo Nhất Thế Giới - .NET Avalonia Multi-Platform

Ứng dụng đa nền tảng viết bằng **Avalonia UI 11 (.NET 8)** hỗ trợ chạy đồng thời trên cả **Windows Desktop** và **Android Mobile**.

## Yêu cầu môi trường
- .NET 8.0 SDK hoặc .NET 9.0 SDK
- Visual Studio 2022 (với Workload Desktop & Mobile) hoặc JetBrains Rider hoặc VS Code + C# Dev Kit.
- Nếu chạy Android: Cài đặt workload Android bằng lệnh:
  ```bash
  dotnet workload install android
  ```

## Cách chạy trên Windows Desktop
```bash
dotnet run --project TopPoorestCountries.Desktop
```

## Cách chạy trên Android
```bash
# Chạy trên máy ảo (Emulator) hoặc thiết bị thật đã bật USB Debugging:
dotnet build -t:Run -f net8.0-android TopPoorestCountries.Android\TopPoorestCountries.Android.csproj
```

## Xuất bản (Publish)
- **Windows (Single File Exe):**
  ```bash
  dotnet publish TopPoorestCountries.Desktop -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
  ```
- **Android APK:**
  ```bash
  dotnet publish TopPoorestCountries.Android -c Release -f net8.0-android
  ```
