FROM  mcr.microsoft.com/dotnet/sdk:6.0

# Download .NET Framework 4.8 web installer
ADD https://download.microsoft.com/download/3/5/7/3576AAED-63D3-4BF2-ADD4-BC72D25DA8E1/NDP48-KB4503548-Web.exe C:\\dotnet-installer.exe

# Run .NET Framework 4.8 installer
RUN C:\\dotnet-installer.exe /q

# Clean up the installer
RUN del C:\\dotnet-installer.exe

# Set environment variables for .NET 6
RUN setx /M PATH "%PATH%;C:\Program Files\dotnet"

# Build and run your application as needed