FROM  mcr.microsoft.com/dotnet/sdk:6.0

# Download .NET Framework 4.8 web installer
ADD https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-web-installer C:\\dotnet-installer.exe

# Run .NET Framework 4.8 installer
RUN C:\\dotnet-installer.exe /q

# Clean up the installer
RUN del C:\\dotnet-installer.exe

# Set environment variables for .NET 6
RUN setx /M PATH "%PATH%;C:\Program Files\dotnet"

# Build and run your application as needed