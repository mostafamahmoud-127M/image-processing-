# 🖼️ Image Processing Studio

[![Language](https://img.shields.io/badge/Language-C%23-239120.svg?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-.NET%20%7C%20Windows%20Forms-512BD4.svg?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

A lightweight desktop application built with **C#** and **Windows Forms** for digital image analysis, color decomposition, and histogram processing. The tool provides an intuitive interface for inspecting spatial pixel distributions, manipulating individual RGB color planes, and applying fundamental image transformation algorithms.

---

##  Key Features

* **Color Plane Decomposition (`FormRGB`)**
  * Split composite color images into distinct Red, Green, and Blue component channels.
  * Inspect isolated channel intensities and color weights.
* **Histogram Computation & Visualization (`FormHistogram`)**
  * Real-time calculation of intensity frequency distributions across standard 8-bit dynamic ranges (0–255).
  * Graphical frequency representation across individual or combined color bands.
* **Core Processing & Transformation (`Form1`)**
  * Support for standard raster formats (`.png`, `.jpg`, `.jpeg`, `.bmp`).
  * Foundation for point-wise operations, contrast adjustment, and spatial domain filtering.
* **Direct Desktop GUI**
  * Built natively using Windows Forms for minimal resource overhead and rapid local execution.

---

##  Project Architecture

```text
ImageProcessing/
├── Form1.cs                # Core application dashboard & image workspace
├── Form1.Designer.cs       # Form1 UI layout and component declarations
├── FormHistogram.cs        # Histogram calculation logic & graphical display
├── FormRGB.cs              # Channel extraction and color plane inspection
├── ImageProcessing.csproj  # Build configurations, assembly metadata & targets
└── Program.cs              # Application runtime bootstrap
