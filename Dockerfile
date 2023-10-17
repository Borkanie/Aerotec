FROM  mcr.microsoft.com/dotnet/sdk:6.0

# Download and install .NET Framework 4.8
RUN curl -o dotnet-installer.exe https://download.microsoft.com/download/3/5/7/3576AAED-63D3-4BF2-ADD4-BC72D25DA8E1/NDP48-KB4503548-Web.exe && \
    chmod +x ./dotnet-installer.exe && \
    ./dotnet-installer.exe /q && \
    del dotnet-installer.exe

# Set environment variables for .NET 6
RUN setx /M PATH "%PATH%;C:\Program Files\dotnet"

# Create a directory for your application and set it as the working directory
WORKDIR C:\app

# Copy your application files into the container
COPY . .

# Build and run your application as needed